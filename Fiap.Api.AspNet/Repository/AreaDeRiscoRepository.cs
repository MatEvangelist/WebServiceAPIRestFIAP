using Fiap.Api.AspNet.Models;
using Fiap.Api.AspNet.Repository.Context;
using System.Data.Entity.Migrations;

namespace Fiap.Api.AspNet.Repository
{
    public class AreaDeRiscoRepository
    {
        private readonly DataBaseContext dataBaseContext;

        public AreaDeRiscoRepository(DataBaseContext ctx)
        {
            dataBaseContext = ctx;
        }

        public IList<AreaDeRiscoModel> Listar()
        {
            var lista = new List<AreaDeRiscoModel>();
            lista = dataBaseContext.AreaDeRisco.ToList<AreaDeRiscoModel>();
            return lista;
        }

        public AreaDeRiscoModel Consultar(int id)
        {
            var areaDeRisco = dataBaseContext.AreaDeRisco.Find(id);
            return areaDeRisco;
        }

        public void Inserir(AreaDeRiscoModel areaDeRisco)
        {
            dataBaseContext.AreaDeRisco.Add(areaDeRisco);
            dataBaseContext.SaveChanges();
        }

        public void Update(AreaDeRiscoModel areaDeRisco)
        {
            dataBaseContext.AreaDeRisco.AddOrUpdate(areaDeRisco);
            dataBaseContext.SaveChanges();
        }

        public void Excluir(int id)
        {
            var areaDeRisco = new AreaDeRiscoModel { AreaDeRiscoId = id };

            dataBaseContext.AreaDeRisco.Remove(areaDeRisco);
            dataBaseContext.SaveChanges();
        }

    }
}
