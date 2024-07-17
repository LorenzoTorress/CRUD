using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabajofinal.Interfaces;

namespace Trabajofinal.Clases
{
    internal class Carrera : IID , IABMC<Carrera> , ICARRERA
    {
        List<Carrera> Carreras;
        int LastID = 1;
        #region IID
        public int ID { get; set; }
        #endregion
        #region IABMC
        public void Add(Carrera carrera)
        {
            if (NameExists(carrera.Nombre)) { throw new Exception("La carrera ya existe"); }
            if (SiglaExists(carrera.Sigla)) { throw new Exception("La sigla ya existe"); }
            carrera.ID = LastID;
            LastID++;
            Carreras.Add(carrera);
        }

        public void Erase(Carrera carrera)
        {
            foreach (Carrera c in Carreras)
            {
                if (c.ID == carrera.ID)
                {
                    Carreras.Remove(c);
                }
            }
            throw new Exception("La carrera no existe");
        }

        public Carrera Find(Carrera carrera)
        {
            foreach (Carrera c in Carreras)
            {
                if (c.ID == carrera.ID)
                {
                    return c;
                }
            }
            throw new Exception("La carrera no existe");
        }
        public void Modify(Carrera carrera)
        {
            Carrera c = Find(carrera);
            if (c == null) { throw new Exception("La carrera no existe"); }
            c.Nombre = carrera.Nombre;
        }
        #endregion
        #region ICARRERA
        public string Nombre { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Sigla { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Titulo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Duracion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Carrera FindbySigla()
        {
            foreach (Carrera c in Carreras)
            {
                if (c.Sigla == Sigla)
                {
                    return c;
                }
            }
            throw new Exception("La carrera no existe");
        }
        public bool NameExists(string name)
        {
            foreach (Carrera c in Carreras)
            {
                if (c.Nombre == name)
                {
                    return true;
                }
            }
            return false;
        }
        public bool SiglaExists(string name)
        {
            foreach (Carrera c in Carreras)
            {
                if (c.Sigla == name)
                {
                    return true;
                }
            }
            return false;
        }
        #endregion
    }
}
