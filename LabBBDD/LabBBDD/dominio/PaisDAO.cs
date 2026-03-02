using LabBBDD.persistencia;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace LabBBDD.dominio
{
    internal class PaisDAO
    {
        public PaisDAO()
        {

        }

        internal List<Pais> leerTodos()
        {
            List<Pais> result = new List<Pais>();
            String sql = "SELECT * FROM countries;";
            List<string[]> datos = AgenteBD.GetInstance().Read(sql);
            foreach (string[] fila in datos) {
                Pais pais = new Pais(fila[0]);
                pais.Nombre = fila[1];
                pais.BaseImpuestos = Convert.ToDecimal(fila[2]);
                result.Add(pais);
            }

            return result;
        }

        public void LeerPais(Pais pais)
        {
            string sql = "SELECT * FROM countries WHERE idCountry = '" + pais.Id + "'";
            List<string[]> datos = AgenteBD.GetInstance().Read(sql);
            if(datos.Count > 0)
            {
                string[] fila = datos[0];
                pais.Nombre = fila[1];
                pais.BaseImpuestos = Convert.ToDecimal(fila[2]);
            }
        }

        public int Insertar(Pais pais)
        {
            string sql = "INSERT INTO countries VALUES ('" + pais.Id + "', '" + pais.Nombre + "', couTaxBase = " + pais.BaseImpuestos.ToString("F2", CultureInfo.GetCultureInfo("en-US")) + ")";
            return AgenteBD.GetInstance().Change(sql);
        }

        public int Actualizar(Pais pais)
        {
            string sql = "UPDATE countries SET couName = '" + pais.Nombre + "', couTaxBase = " + pais.BaseImpuestos.ToString("F2", CultureInfo.GetCultureInfo("en-US")) + " WHERE idCountry = '" + pais.Id + "'";
            return AgenteBD.GetInstance().Change(sql);
        }

        public int Eliminar(Pais pais)
        {
            string sql = "DELETE FROM countries WHERE idCountry = '" + pais.Id + "'";
            return AgenteBD.GetInstance().Change(sql);
        }
        internal bool IdExiste(string id)
        {
            string sql = "SELECT * FROM countries WHERE idCountry = '" + id + "'";
            List<string[]> datos = AgenteBD.GetInstance().Read(sql);
            return datos.Count > 0;
        }
    }
}
