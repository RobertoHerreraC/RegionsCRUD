using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DRegion
    {
        public List<Region> Listar(string Nombre)
        {
            List<Region> region = new List<Region>();

            using (var connection = new SqlConnection(Conexion.cadena))
            {
  
                SqlCommand cmd = new SqlCommand("sp_ReadRegions", connection);
                cmd.CommandType = CommandType.StoredProcedure;


                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    int RegionID = reader["RegionID"] != DBNull.Value ? Convert.ToInt32(reader["RegionID"]) : 0;
                    string RegionName = reader["RegionName"] != DBNull.Value ? Convert.ToString(reader["RegionName"]) : "";

                    region.Add(new Region { RegionID = RegionID, RegionName = RegionName });


                }
                reader.Close();
            }
            return region;

        }
    }
}
