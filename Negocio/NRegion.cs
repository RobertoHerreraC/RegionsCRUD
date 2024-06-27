using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NRegion
    {
        DRegion datos = new DRegion();
        public List<Region> Listar(string Nombre)
        {
            List<Region> list = new List<Region>();
            list = datos.Listar(Nombre);
            return list;
        }
    }
}
