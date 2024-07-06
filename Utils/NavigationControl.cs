using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_winform.Utils
{
    public class NavigationControl
    {
        List <UserControl> _controls;
        Panel _panel;

        public NavigationControl(List<UserControl> controls, Panel panel) {
            this._panel = panel;
            this._controls = controls;
            AddUserControls();
        }

        private void AddUserControls()
        {
            for (int i = 0; i < _controls.Count; i++)
            {
                _controls[i].Dock = DockStyle.Fill;
                _panel.Controls.Add(_controls[i]);
            }
        }

        public void Display(int index)
        {
            if (index < _controls.Count())
            {
                _controls[index].BringToFront();
            }
        }
    }
}
