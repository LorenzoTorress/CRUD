using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabajofinal.Clases;

namespace Trabajofinal.Interfaces
{
    internal interface IUSUARIO
    {
        string Nombre { get; set; }
        int DNI { get; set; }
        string Mail { get; set; }

        bool DniExist(int dni);
        bool MailExist(string mail);
        Usuario FindByMail(string mail);
        Usuario FindByDni(int dni);
        List<Usuario> List(); 
    }
}
