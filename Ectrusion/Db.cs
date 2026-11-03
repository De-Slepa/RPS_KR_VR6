using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Ectrusion
{
    public static class Db
    {
        private const string ConnStr =
            "Server=127.0.0.1;Port=3306;Database=extrusion_db;Uid=root;Pwd=root;CharSet=utf8mb4;";

        public static List<Material> GetMaterials()
        {
            var list = new List<Material>();
            using (var conn = new MySqlConnection(ConnStr))
            {
                conn.Open();
                var cmd = new MySqlCommand(
                    "SELECT id, name, mu0, b, t0, n FROM materials ORDER BY name", conn);
                using (var r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        list.Add(new Material
                        {
                            Id = r.GetInt32("id"),
                            Name = r.GetString("name"),
                            Mu0 = r.GetDouble("mu0"),
                            B = r.GetDouble("b"),
                            T0 = r.GetDouble("t0"),
                            N = r.GetDouble("n")
                        });
                    }
                }
            }
            return list;
        }

        public static ProcessRange GetRange(int materialId)
        {
            using (var conn = new MySqlConnection(ConnStr))
            {
                conn.Open();
                var cmd = new MySqlCommand(
                    "SELECT t_min, t_max, t_step, gamma_min, gamma_max, gamma_step " +
                    "FROM process_ranges WHERE material_id = @id LIMIT 1", conn);
                cmd.Parameters.AddWithValue("@id", materialId);
                using (var r = cmd.ExecuteReader())
                {
                    if (!r.Read()) return null;
                    return new ProcessRange
                    {
                        TMin = r.GetDouble("t_min"),
                        TMax = r.GetDouble("t_max"),
                        TStep = r.GetDouble("t_step"),
                        GammaMin = r.GetDouble("gamma_min"),
                        GammaMax = r.GetDouble("gamma_max"),
                        GammaStep = r.GetDouble("gamma_step")
                    };
                }
            }
        }
    }
}
