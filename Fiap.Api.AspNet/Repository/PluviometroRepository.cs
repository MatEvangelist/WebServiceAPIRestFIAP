﻿using Fiap.Api.AspNet.Models;
using Fiap.Api.AspNet.Repository.Context;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Api.AspNet.Repository
{
    public class PluviometroRepository
    {

        private readonly DataBaseContext dataBaseContext;

        public PluviometroRepository(DataBaseContext ctx)
        {
            dataBaseContext = ctx;
        }

        public IList<PluviometroModel> Listar()
        {
            var lista = new List<PluviometroModel>();
            lista = dataBaseContext.Pluviometro.ToList<PluviometroModel>();
            Console.WriteLine(lista);

            return lista;
        }

        public PluviometroModel Consultar(int id)
        {
            var pluviometro = dataBaseContext.Pluviometro.Find(id);
            return pluviometro;
        }

        public void Inserir(PluviometroModel pluviometro)
        {
            dataBaseContext.Pluviometro.Add(pluviometro);
            dataBaseContext.SaveChanges();
        }

        public void Update(PluviometroModel pluviometro)
        {
            dataBaseContext.Pluviometro.Update(pluviometro);
            dataBaseContext.SaveChanges();
        }

        public void Excluir(int id)
        {
            var pluviometro = new PluviometroModel { PluviometroId = id };

            dataBaseContext.Pluviometro.Remove(pluviometro);
            dataBaseContext.SaveChanges();
        }
    }
}
