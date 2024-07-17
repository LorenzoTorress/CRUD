using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabajofinal.Interfaces;
using System.IO;

namespace Trabajofinal.Clases
{
    class Usuario : IABMC<Usuario>, IUSUARIO
    {
        List<Usuario> Usuarios;
        private static int LastId = 1;
        #region IID
        public int ID { get; set; }
        #endregion
        #region IUsuario
        public string Nombre { get; set; }
        public int DNI { get; set; }
        public string Mail { get; set; }
        public bool DniExist(int dni)
        {
            foreach (Usuario u in Usuarios)
            {
                if (u.ID == dni)
                {
                    return true;
                }
            }
            return false;
        }
        public Usuario FindByDni(int dni)
        {
            foreach (Usuario u in Usuarios)
            {
                if (u.DNI == dni)
                {
                    return u;
                }
            }
            throw new Exception("El DNI no existe");
        }

        public Usuario FindByMail(string mail)
        {
            foreach (Usuario u in Usuarios)
            {
                if (u.Mail == mail)
                {
                    return u;
                }
                
            }
            throw new Exception("El mail no existe");
        }

        public bool MailExist(string mail)
        {
            foreach (Usuario u in Usuarios)
            {
                if (u.Mail == mail)
                {
                    return true;
                }
            }
            return false;
        }

        // Lista abajo
        public List<Usuario> List()
        {
            return Usuarios;
        }
        #endregion IUsuario
        #region IABMC
        public void Add(Usuario usuario)
        {
            if (MailExist(usuario.Mail)) { throw new Exception("El mail ya esta asociado a otro Usuario"); }
            if (DniExist(usuario.DNI)) { throw new Exception("El DNI ya esta asociado a otro Usuario"); }
            else
            {
                usuario.ID = LastId;
                LastId++;
                Usuarios.Add(usuario);
            }
        }
        public void Erase(Usuario usuario)
        {
            foreach (Usuario u in Usuarios)
            {
                if (u.DNI == usuario.DNI)
                {
                    Usuarios.Remove(u);
                    return;
                }
            }
            throw new Exception("No existe el usuario con el DNI" + usuario.DNI);
        }
        public Usuario Find(Usuario usuario)
        {
            foreach (Usuario u in Usuarios)
            {
                if (u.ID == usuario.ID)
                {
                    return u;
                }
            }
            throw new Exception("No existe el usuario con el ID" + usuario.ID);
        }
        public void Modify(Usuario usuario)
        {
            Usuario u = Find(usuario);
            if (u == null) { throw new Exception("No existe el usuario"); }
            u.Nombre = usuario.Nombre;
        }    
        #endregion IABMC
    }
}