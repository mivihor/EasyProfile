using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.ApplicationServices;

[assembly: CommandClass(typeof(EP.StartUp))]

namespace EP
{
    class StartUp
    {
        [CommandMethod("EasyP")]

        public void EasyP()
        {
            UControl form = new UControl();
            Application.ShowModalWindow(form);
        }
    }
}
