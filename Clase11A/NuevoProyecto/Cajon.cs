using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using EjemploArchivos;

namespace NuevoProyecto
{
    public abstract class Cajon//:ISerializable
    {
        public int cantidad;       
        public float precio;

        public float Precio
        {
            get { return this.precio; }
            set { this.precio = value; }
        }

        public abstract void Mostrar();

        
            
    }
}
