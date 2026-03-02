using System;
using System.Collections.Generic;
using System.Text;

namespace LabBBDD.dominio
{
    internal class Pais
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public decimal BaseImpuestos { get; set; }
        private PaisDAO _paisDAO;

        public Pais() { }
        public Pais(string Id)
        {
            this.Id = Id;
            _paisDAO = new PaisDAO();
        }
        internal bool IdExiste(string id)
        {
            return _paisDAO.IdExiste(id);
        }

        public override string ToString()
        {
            return Id;
        }
        public List<Pais> ObtenerTodosPaises()
        {
            return _paisDAO.leerTodos();
        }

        public void ObtenerPais()
        {
            _paisDAO.LeerPais(this);
        }

        public int InsertarPais()
        {
            return _paisDAO.Insertar(this);
        }

        public int ActualizarPais()
        {
            return _paisDAO.Actualizar(this);
        }

        public int EliminarPais()
        {
            return _paisDAO.Eliminar(this);
        }

        
    }
}
