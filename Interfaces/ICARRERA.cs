using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabajofinal.Clases;

namespace Trabajofinal.Interfaces
{
    internal interface ICARRERA
    {
        string Nombre { get; set; }
        string Sigla { get; set; }
        string Titulo { get; set; }
        int Duracion { get; set; }
        Carrera FindbySigla();
        bool NameExists(string name);
        bool SiglaExists(string name);
    }
}
