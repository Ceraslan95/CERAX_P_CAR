using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXCAR
{
    public class SpeedControlUnit
    {
        private int speed;

        public bool SpeedUp()
        {
            if(speed<240)
            {
                speed++;
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public bool SpeedDown()
        {
            if (speed >0)
            {
                speed--;
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
