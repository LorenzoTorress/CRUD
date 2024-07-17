using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabajofinal.Clases;

namespace Trabajofinal.Interfaces
{
    internal interface IABMC<t>: IID
    {
        void Modify(t data);
        void Add(t data);
        void Erase(t data);
        t Find(t data);
    }
}
