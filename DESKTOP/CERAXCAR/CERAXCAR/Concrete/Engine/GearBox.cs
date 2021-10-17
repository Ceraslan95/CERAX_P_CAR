using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXCAR
{
    public class GearBox
    {
        private string gearValue = "0";
       
        public string GetGearValue()
        {
            return gearValue;
        }

        public void SetGearValue(string value)
        {
            gearValue = value;
        }
    }
}
