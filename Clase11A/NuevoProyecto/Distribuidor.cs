using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuevoProyecto
{
    class Distribuidor
    {
        private List<Transporte> listadoTransporte;
        public Persona dueño;
        private List<Cajon> listadoCajones;

        public Distribuidor()
        {
            this.listadoTransporte = new List<Transporte>();
            this.listadoCajones = new List<Cajon>();
        }

        public List<Cajon> ListadoDeCajones
        {
            get { return this.listadoCajones; }
        }

        public List<Transporte> ListadoTransporte
        {
            get { return this.listadoTransporte; }
        }


    }
}
