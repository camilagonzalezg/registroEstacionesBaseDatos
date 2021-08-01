using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroEstacionesBD.DAL
{
    public class PuntoCargaDAL
    {
        //acceso base datos, dbEntities representa objeto de acceso a base de datos
        public RegistroEstacionesBDEntities dbEntities = new RegistroEstacionesBDEntities();

        //metodo listar
        public List<PuntoCarga> GetAll()
        {
            //hacer select * from PuntoCarga
            return dbEntities.PuntoCarga.ToList();

        }

        //metodo agregar
        public void Add(PuntoCarga p)
        {
            //insert into punto carga values (...)
            dbEntities.PuntoCarga.Add(p);

            //commit
            dbEntities.SaveChanges();
        }

        //metodo eliminar
        public void Remove(String id)
        {
            //delete from puntocarga where id=...

            //buscar el punto carga que quiero borrar
            PuntoCarga p = dbEntities.PuntoCarga.Find(id);

            //borrar punto de carga
            dbEntities.PuntoCarga.Remove(p);

            //commit
            dbEntities.SaveChanges();

        }

        //METODO UPDATE
        public void Update(PuntoCarga p)
        {
            PuntoCarga pOriginal = this.dbEntities.PuntoCarga.Find(p.Id);
            pOriginal.Id = p.Id;
            pOriginal.Tipo = p.Tipo;
            pOriginal.CapacidadMaxima = p.CapacidadMaxima;
            pOriginal.FechaVencimiento = p.FechaVencimiento;

            //commit
            this.dbEntities.SaveChanges();
        }
    }
}


