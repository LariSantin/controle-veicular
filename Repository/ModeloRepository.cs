using ControleVeicular.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleVeicular.Repository
{
    public interface IModeloRepository
    {
        string SaveModelo(Modelo modelo);
        List<Modelo> GetModelos();
        IList<Modelo> GetModelosTela();

    }

    public class ModeloRepository : BaseRepository<Modelo>, IModeloRepository
    {
        public ModeloRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public List<Modelo> GetModelos()
        {
            return dbSet.ToList();
        }
        public IList<Modelo> GetModelosTela()
        {
            return dbSet.ToList();
        }
        public string SaveModelo(Modelo modelo)
        {           
            if (!dbSet.Where(m => m.Id == modelo.Id).Any())
            {
                dbSet.Add(new Modelo(modelo.Descricao));
                contexto.SaveChanges();
                return "Modelo Cadastrada com sucesso.";
            }
            return "Modelo já está cadastrada";
        }

    }
}
