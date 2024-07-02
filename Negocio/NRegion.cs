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
        public List<Region> Listar()
        {
            List<Region> list = new List<Region>();
            list = datos.Listar();
            return list;
        }

        public void Registrar(Entidad.Region region)
        {
            region.Enabled = true;
            datos.Registrar(region);
        }

        public void Eliminar(Entidad.Region region)
        {
            region.Enabled = false;
            datos.Eliminar(region);

        }

        public void Editar(Entidad.Region region)
        {
            region.Enabled = true;
            datos.Editar(region);
        }
    }
}
