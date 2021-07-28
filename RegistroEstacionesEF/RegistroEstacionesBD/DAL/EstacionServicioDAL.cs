using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroEstacionesBD.DAL
{
    public class EstacionServicioDAL
    {

        //acceso base datos, dbEntities representa objeto de acceso a base de datos
        public RegistroEstacionesBDEntities dbEntities = new RegistroEstacionesBDEntities();

        //metodo listar
        public List<EstacionServicio> GetAll()
        {
            //hacer select * from EstacionServicio
            return dbEntities.EstacionServicio.ToList();

        }

        //metodo agregar
        public void Add(EstacionServicio e)
        {
            //insert into punto carga values (...)
            dbEntities.EstacionServicio.Add(e);

            //commit
            dbEntities.SaveChanges();
        }

        //metodo eliminar
        public void Remove(String id)
        {
            //delete from puntocarga where id=...

            //buscar el punto carga que quiero borrar
            EstacionServicio e = dbEntities.EstacionServicio.Find(id);

            //borrar punto de carga
            dbEntities.EstacionServicio.Remove(e);

            //commit
            dbEntities.SaveChanges();

        }

        //metodo eliminar con LINQ, lenguaje de consultas para EF basado en objetos (sql de objetos)
        public void Remove2(String region)
        {
            //buscar estacion que quiero borrar, buscando todos los objetos que coinciden
            var query = from e in dbEntities.EstacionServicio
                                                where e.Region == region
                                                select e;
            foreach (var e in query)
            {
                System.Console.WriteLine(e);
                dbEntities.EstacionServicio.Remove(e);
                dbEntities.SaveChanges();
            }
        }

        // metodo obtener por region lista completa con LINQ
        public List<EstacionServicio> GetAll(String region)
        {
            var query = from e in dbEntities.EstacionServicio
                                   where e.Region == region
                                   select e;
            return query.ToList();
        }


    }
}
