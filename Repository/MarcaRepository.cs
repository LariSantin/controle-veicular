

using ControleVeicular.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ControleVeicular.Repository
{
    public interface IMarcaRepository
    {
        string SaveMarca(Marca marca);
        List<Marca> GetMarcas();

    }

    public class MarcaRepository : BaseRepository<Marca>, IMarcaRepository
    {
        public MarcaRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public List<Marca> GetMarcas()
        {
            return dbSet.ToList();
        }

        public string SaveMarca(Marca marca)
        {
            if (!dbSet.Where(m => m.Id == marca.Id).Any())
            {
                dbSet.Add(new Marca(marca.Descricao));
                contexto.SaveChanges();
                return "Marca Cadastrada com sucesso.";
            }
            return "Marca já está cadastrada";
        }


    }
}

