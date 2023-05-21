using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXCAR.Abstract
{
    interface IModul
    {
        bool GetStatus();
        void SetStatus(bool value);
        int GetValue();
        void SetValue(int value);
    }
}
