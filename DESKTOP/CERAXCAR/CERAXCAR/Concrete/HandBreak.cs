using CERAXCAR.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXCAR.Concrete
{
    public class HandBreak : Modul, IModul
    {
        private bool handBreak;
        UI _ui;
        public HandBreak(UI ui)
        {
            _ui = ui;
            handBreak = true;
        }

        public bool GetStatus()
        {
            return handBreak;
        }

        public int GetValue()
        {
            throw new NotImplementedException();
        }

        public void SetStatus(bool value)
        {
            handBreak = value;
            _ui.pHandBreak.Visible = value;
        }

        public void SetValue(int value)
        {
            throw new NotImplementedException();
        }
    }
}
