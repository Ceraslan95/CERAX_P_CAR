using CERAXCAR.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXCAR.Concrete
{
    public class Turbo : Modul, IModul
    {
        public bool GetStatus()
        {
            return Status;
        }

        public int GetValue()
        {
            return Value;
        }

        public void SetStatus(bool value)
        {
            Status = value;
        }

        public void SetValue(int value)
        {
            Value = value;
        }
    }
}
