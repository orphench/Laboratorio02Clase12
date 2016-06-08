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
    public class CajonFrutas:Cajon//,ISerializable
    {
        public string tipo;

        public CajonFrutas()
        { }

        public override void Mostrar()
        {
            throw new NotImplementedException();
        }

        //public bool GuardarEnXml()
        //{
        //    return ManejadorXml.GuardarEstacionamiento(this);
        //}
        
    }
}
