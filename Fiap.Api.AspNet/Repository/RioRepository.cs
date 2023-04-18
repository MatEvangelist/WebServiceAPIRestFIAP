using Fiap.Api.AspNet.Models;
using Fiap.Api.AspNet.Repository.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Fiap.Api.AspNet.Repository
{
    public class RioRepository
    {
        private readonly DataBaseContext dataBaseContext;

        public RioRepository(DataBaseContext ctx)
        {
            dataBaseContext = ctx;
        }

        public IList<RioModel> Listar()
        {
            var lista = new List<RioModel>();
            lista = dataBaseContext.Rio.ToList<RioModel>();
            return lista;
        }

        public RioModel Consultar(int id)
        {
            var rio = dataBaseContext.Rio.Find(id);

            return rio;
        }

        public void Inserir(RioModel rio)
        {
            dataBaseContext.Rio.Add(rio);
            dataBaseContext.SaveChanges();
        }

        public void Update(RioModel rio)
        {
            dataBaseContext.Rio.Update(rio);
            dataBaseContext.SaveChanges();
        }

        public void Excluir(int id)
        {
            var rio = new RioModel { RioId = id};

            dataBaseContext.Rio.Remove(rio);
            dataBaseContext.SaveChanges();
        }
    }
}
