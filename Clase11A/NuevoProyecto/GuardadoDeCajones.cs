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
    class GuardadoDeCajones
    {

        public static List<Cajon> listaDeCajon(int cantidadDeCajones)
        {
            List<Cajon> listaDeCajones = new List<Cajon>(cantidadDeCajones);

            for (int i = 0; i < 10; i++)
            {
                Random randon = new Random();
                int a = randon.Next(cantidadDeCajones);

                listaDeCajones[i].cantidad = a;
            }

            return listaDeCajones;
        }

        public static bool GuardarEnXml(Cajon Cajon)
        {
            try
            {
                using (XmlTextWriter escritor = new XmlTextWriter("Cajon.xml", Encoding.UTF8))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(Cajon));
                    serializador.Serialize(escritor, Cajon);

                }

            }
            catch (Exception)
            {

                return false;
            }

            return true;
        }
    }
}
