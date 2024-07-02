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
        public List<Region> Listar()
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

                    region.Add(new Region { RegionId = RegionID, RegionName = RegionName });


                }
                reader.Close();
            }
            return region;

        }

        public void Registrar(Entidad.Region region)
        {
            using (var connection = new SqlConnection(Conexion.cadena))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("sp_CreateRegion", connection);
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter parameter = new SqlParameter("@RegionName", SqlDbType.NVarChar, 50);
                parameter.Value = region.RegionName;
                command.Parameters.Add(parameter);

                SqlParameter parameter2 = new SqlParameter("@Enabled", SqlDbType.Bit) ;
                parameter2.Value = region.Enabled;
                command.Parameters.Add(parameter2);
                command.ExecuteNonQuery();

            }
        }

        public void Editar (Entidad.Region region)
        {
            using (var connection = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new("sp_UpdateRegion", connection) { CommandType = CommandType.StoredProcedure };
                SqlParameter parameter = new SqlParameter("@RegionId", SqlDbType.Int);
                parameter.Value =region.RegionId;
                cmd.Parameters.Add(parameter);
                SqlParameter parameter1 = new SqlParameter("@RegionName", SqlDbType.VarChar, 80);
                parameter1.Value = region.RegionName;
                cmd.Parameters.Add(parameter1);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar (Entidad.Region region)
        {
            using (var connection = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new("sp_DeleteRegion", connection) { CommandType = CommandType.StoredProcedure };
                SqlParameter parameter = new SqlParameter("@RegionId", SqlDbType.Int);
                parameter.Value =region.RegionId;
                cmd.Parameters.Add(parameter);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
