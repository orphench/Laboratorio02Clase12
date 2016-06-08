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
    class Program
    {
        static void Main(string[] args)
        {
            CajonFrutas cajonDeFrutasUno = new CajonFrutas();
            CajonFrutas cajonDeFrutasDos = new CajonFrutas();
            CajonVerdura cajonDeVerdurasUno = new CajonVerdura();
            CajonVerdura cajonDeVerdurasDos = new CajonVerdura();

            cajonDeVerdurasUno.tipo = "Hortaliza";
            cajonDeVerdurasDos.tipo = "Legumbres";
            cajonDeFrutasUno.tipo = "Frutas De Estacion";
            cajonDeFrutasDos.tipo = "Frutas Exoticas";

            List<Cajon> litaDeCajones = new List<Cajon>();
            litaDeCajones.Add(cajonDeFrutasUno);
            litaDeCajones.Add(cajonDeFrutasDos);
            litaDeCajones.Add(cajonDeVerdurasUno);
            litaDeCajones.Add(cajonDeVerdurasDos);

            foreach (Cajon item in litaDeCajones)
            {
                GuardadoDeCajones.GuardarEnXml(item);
            }

            Console.ReadKey();

            //List<ISerializable> listaSerializable = new List<ISerializable>();
            //listaSerializable.Add(cajonDeFrutasUno);
            //listaSerializable.Add(cajonDeFrutasDos);

            //foreach (ISerializable item in listaSerializable)
            //{
            //    BackUp.HacerBackUp(item);
            //}
        }
    }
}
