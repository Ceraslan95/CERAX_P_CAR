using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXCAR.Concrete.Engine
{
    public class Motor
    {
        UI _ui;
        int km;

        private bool motorStatus;
        private bool motorGoStatus;

        public Motor(UI ui)
        {
            _ui = ui;
            motorStatus = false;
            motorGoStatus = false;
        }

        public bool GetMotorStatus()
        {
            return motorStatus;
        }
        public bool GetGoStatus()
        {
            return motorGoStatus;
        }


    }
}
