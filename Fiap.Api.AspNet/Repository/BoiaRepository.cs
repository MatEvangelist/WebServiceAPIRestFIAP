using Fiap.Api.AspNet.Models;
using Fiap.Api.AspNet.Repository.Context;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity.Migrations;

namespace Fiap.Api.AspNet.Repository
{
    public class BoiaRepository
    {
        private readonly DataBaseContext dataBaseContext;

        public BoiaRepository(DataBaseContext ctx)
        {
            dataBaseContext = ctx;
        }

        public IList<BoiaModel> Listar()
        {
            var listaBoiaModel = new List<BoiaModel>();
            var listaBoia = dataBaseContext.Boia.ToList();
            return listaBoiaModel;
        }


        public BoiaModel Consultar(int id)
        {
            var boia = dataBaseContext.Boia.Find(id);
            return boia;
        }

        public void Inserir(BoiaModel boia)
        {
            dataBaseContext.Boia.Add(boia);
            dataBaseContext.SaveChanges();
        }

        public void Update(BoiaModel boia)
        {
            dataBaseContext.Boia.AddOrUpdate(boia);
            dataBaseContext.SaveChanges();
        }

        public void Excluir(int id)
        {
            var boia = new BoiaModel { FerramentaId = id };

            dataBaseContext.Boia.Remove(boia);
            dataBaseContext.SaveChanges();
        }
    }
}
