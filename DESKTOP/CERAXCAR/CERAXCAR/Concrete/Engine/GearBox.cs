using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXCAR
{
    public class GearBox
    {
        UI _ui;
        private Gears gearValue;
        public GearBox(UI ui)
        {
            _ui = ui;
            gearValue = Gears.Zero;
        }
        public enum Gears
        {
            R = -1,
            Zero = 0,
            One = 1,
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7


        }
       
        public Gears GetGearValue()
        {
            return gearValue;
        }

        public void SetGearValue(Gears gear)
        {
            gearValue = gear;
            if (gear == Gears.R)
            {
                _ui.KMUI.GaugeLabels.FindByName("lblGearBox").Text = gear.ToString();
            }
            else
            {
                _ui.KMUI.GaugeLabels.FindByName("lblGearBox").Text = gear.GetHashCode().ToString();
            }
            
        }
    }
}
