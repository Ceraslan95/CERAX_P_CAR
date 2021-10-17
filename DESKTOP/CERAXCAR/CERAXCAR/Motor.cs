using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXCAR
{
    public class Motor
    {
        UI ui;
        
        private int _speed;
        private string _gear = "0";

        public Motor(UI ui)
        {
            this.ui = ui;
        }

        public int GetSpeed()
        {
            return _speed;
        }
        public string GetGearStatus()
        {
            return _gear;
        }
        public void SetGearStatus(string gear)
        {
            _gear = gear;
        }

        public void UpSpeed(int type)
        {
            if (_speed < 230)
            {
                switch (type)
                {
                    
                }
               
            }

            if(_speed == 0)
            {
                ui.KMUI.GaugeLabels.FindByName("lblGearBox").Text = "0";
            }

        }
    }
}
