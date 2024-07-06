--------------------------------------------------------------------------------
-- STORE PROCEDURE
--------------------------------------------------------------------------------
--

CREATE OR REPLACE PROCEDURE QLHSUT.USER_LOGIN
    (USRNAME VARCHAR2, USR_ROLE NVARCHAR2, CNT OUT INTEGER)
AS
    LaDN NUMBER;
    LaUV NUMBER;
    LaNV NUMBER;

BEGIN
    CNT := 0;
    
    IF USR_ROLE = N'Doanh nghiệp' THEN
        SELECT COUNT(*) INTO LaDN FROM QLHSUT.QLHSUT_DOANH_NGHIEP WHERE TO_CHAR(MADN) = USRNAME;
    END IF;
    
    IF USR_ROLE = N'Ứng viên' THEN
        SELECT COUNT(*) INTO LaUV FROM QLHSUT.QLHSUT_UNG_VIEN WHERE TO_CHAR(MAUV) = USRNAME;
    END IF;
    
    IF USR_ROLE = N'Nhân viên' THEN
        SELECT COUNT(*) INTO LaNV FROM QLHSUT.QLHSUT_NHAN_VIEN WHERE TO_CHAR(MANV) = USRNAME;
    END IF;
    
    IF (LaDN = 1) THEN
        CNT := 1;
    END IF;
    IF (LaUV = 1) THEN
        CNT := 2;
    END IF;
    IF (LaNV = 1) THEN
        CNT := 3;
    END IF;  
    
END;
/
SELECT USERNAME FROM DBA_USERS;

--------------------------------------------------------------------------------
-- FUNCTION
--------------------------------------------------------------------------------


--------------------------------------------------------------------------------
-- TRIGGER
--------------------------------------------------------------------------------
--Trigger kiểm tra ngày kí phải trước ngày hết hạn
CREATE OR REPLACE TRIGGER QLHSUT.CHECK_NGAY_KI
BEFORE INSERT OR UPDATE ON QLHSUT.QLHSUT_HOP_DONG_DANG_TUYEN
FOR EACH ROW
BEGIN
    -- Kiểm tra ngày ký mới so với ngày hết hạn mới
    IF :NEW.NGAYKI > :NEW.NGAYHETHAN THEN
        RAISE_APPLICATION_ERROR(-20002, 'Ngày ký mới phải trước ngày hết hạn mới.');
    END IF;

    -- Kiểm tra ngày ký mới so với ngày hết hạn cũ (trong trường hợp UPDATE)
    IF UPDATING AND :NEW.NGAYKI > :OLD.NGAYHETHAN THEN
        RAISE_APPLICATION_ERROR(-20003, 'Ngày ký mới phải trước ngày hết hạn cũ.');
    END IF;
    
    IF UPDATING AND :OLD.NGAYKI > :NEW.NGAYHETHAN THEN
        RAISE_APPLICATION_ERROR(-20004, 'Ngày ký cũ phải trước ngày hết hạn mới.');
    END IF;
END;
/

--Trigger xóa doanh nghiệp sẽ xóa thông tin đăng tuyển liên quan
CREATE OR REPLACE TRIGGER QLHSUT.TRG_DELETE_THONG_TIN_DANG_TUYEN
AFTER DELETE ON QLHSUT.QLHSUT_DOANH_NGHIEP
FOR EACH ROW
BEGIN
    DELETE FROM QLHSUT.QLHSUT_THONG_TIN_DANG_TUYEN WHERE DN_DANGTUYEN = :OLD.MADN; 
END;
/

--Trigger kiểm tra doanh nghiệp đã tồn tai trong database chưa
CREATE OR REPLACE TRIGGER QLHSUT.TRG_CHECK_DOANH_NGHIEP_EXIST
BEFORE INSERT ON QLHSUT.QLHSUT_DOANH_NGHIEP
FOR EACH ROW
DECLARE
    v_count NUMBER;
BEGIN
    -- Kiểm tra xem mã doanh nghiệp đã tồn tại chưa
    SELECT COUNT(*) INTO v_count FROM QLHSUT.QLHSUT_DOANH_NGHIEP "DN" WHERE DN.TENDN = :NEW.TENDN;

    -- Nếu đã tồn tại, báo lỗi
    IF v_count > 0 THEN
        RAISE_APPLICATION_ERROR(-20005, 'Doanh nghiệp đã tồn tại trong cơ sở dữ liệu.');
    END IF;
END;
/

CREATE OR REPLACE TRIGGER QLHSUT.CHECK_THOIGIAN_PHIEUQUANGCAO
BEFORE INSERT ON QLHSUT.QLHSUT_PHIEU_QUANG_CAO
FOR EACH ROW
BEGIN
    -- Kiểm tra thời gian kết thúc phải sau thời gian bắt đầu
    IF :NEW.TG_BATDAU > :NEW.TG_KETTHUC THEN
        RAISE_APPLICATION_ERROR(-20006, 'Ngày ký mới phải trước ngày hết hạn mới.');
    END IF;
END;
/

--Trigger Kiểm tra thanh toán nếu < 30 ngày phải thanh toán 1 đợt
CREATE OR REPLACE TRIGGER QLHSUT.KIEM_TRA_THANH_TOAN
BEFORE INSERT OR UPDATE ON QLHSUT.QLHSUT_THONG_TIN_THANH_TOAN
FOR EACH ROW
DECLARE
    v_tgbd DATE;
    v_tgkt DATE;
    v_tong_tien NUMBER;
    v_so_ngay NUMBER;
BEGIN
    -- Lấy thông tin thời gian từ bảng phiếu quảng cáo
    SELECT TG_BATDAU, TG_KETTHUC, TONGTIEN INTO v_tgbd, v_tgkt, v_tong_tien
    FROM QLHSUT.QLHSUT_PHIEU_QUANG_CAO
    WHERE MAPQC = :NEW.MAPQC;

    -- Tính số ngày giữa ngày bắt đầu và ngày kết thúc
    v_so_ngay := v_tgkt - v_tgbd;

    -- Kiểm tra điều kiện cho thời gian quảng cáo dưới 30 ngày
    IF v_so_ngay < 30 THEN
        -- Kiểm tra nếu đợt thanh toán không bằng 1
        IF :NEW.DOTTHANHTOAN <> 1 THEN
            RAISE_APPLICATION_ERROR(-20008, 'Đợt thanh toán phải bằng 1 khi thời gian quảng cáo dưới 30 ngày.');
        END IF;

        -- Kiểm tra nếu tổng tiền thanh toán không bằng tổng tiền của phiếu quảng cáo
        IF :NEW.TONGTIEN_THANHTOAN <> v_tong_tien THEN
            RAISE_APPLICATION_ERROR(-20009, 'Tổng tiền thanh toán phải bằng tổng tiền của phiếu quảng cáo.');
        END IF;
    ELSE
        -- Kiểm tra điều kiện cho thời gian quảng cáo từ 30 ngày trở lên
        IF :NEW.DOTTHANHTOAN = 1 OR :NEW.DOTTHANHTOAN = 2 THEN
            -- Kiểm tra nếu tổng tiền thanh toán không bằng 30% tổng tiền của phiếu quảng cáo
            IF :NEW.TONGTIEN_THANHTOAN <> (v_tong_tien * 0.3) THEN
                RAISE_APPLICATION_ERROR(-20010, 'Tổng tiền thanh toán đợt 1 và 2 phải bằng 30% tổng tiền của phiếu quảng cáo.');
            END IF;
        ELSIF :NEW.DOTTHANHTOAN = 3 THEN
            -- Kiểm tra nếu tổng tiền thanh toán không bằng 40% tổng tiền của phiếu quảng cáo
            IF :NEW.TONGTIEN_THANHTOAN <> (v_tong_tien * 0.4) THEN
                RAISE_APPLICATION_ERROR(-20011, 'Tổng tiền thanh toán đợt 3 phải bằng 40% tổng tiền của phiếu quảng cáo.');
            END IF;
        ELSE
            -- Kiểm tra nếu đợt thanh toán không hợp lệ
            RAISE_APPLICATION_ERROR(-20012, 'Đợt thanh toán không hợp lệ.');
        END IF;
    END IF;
END;
/

--Trigger kiểm tra nếu hợp đồng còn hạn thì không thể xóa doanh nghiệp
CREATE OR REPLACE TRIGGER QLHSUT.KIEM_TRA_XOA_DOANH_NGHIEP
BEFORE DELETE ON QLHSUT.QLHSUT_DOANH_NGHIEP
FOR EACH ROW
DECLARE
    v_hopdong_count NUMBER;
BEGIN
    -- Kiểm tra số lượng hợp đồng còn hạn của doanh nghiệp
    SELECT COUNT(*) INTO v_hopdong_count FROM QLHSUT.QLHSUT_HOP_DONG_DANG_TUYEN
    WHERE MADT IN 
    (SELECT MADT FROM QLHSUT.QLHSUT_THONG_TIN_DANG_TUYEN WHERE DN_DANGTUYEN = :OLD.MADN)
      AND SYSDATE BETWEEN NGAYKI AND NGAYHETHAN;

    -- Nếu tồn tại hợp đồng còn hạn thì raise error
    IF v_hopdong_count > 0 THEN
        RAISE_APPLICATION_ERROR(-20013, 'Không thể xóa doanh nghiệp vì còn hợp đồng chưa hết hạn.');
    END IF;
END;