using System.Collections.Generic;
using DAL;
using Models;

namespace BLL
{
    public class CarroBLL
    {
        public List<Carro> ObtenerCarros() => CarroDAL.ObtenerTodos();
        public void AgregarCarro(Carro c) => CarroDAL.Agregar(c);
        public void EditarCarro(Carro c) => CarroDAL.Editar(c);
        public void EliminarCarro(int id) => CarroDAL.Eliminar(id);
    }
}
