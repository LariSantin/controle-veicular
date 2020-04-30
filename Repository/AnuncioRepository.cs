using ControleVeicular.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleVeicular.Repository
{
    public interface IAnuncioRepository
    {
        string SaveAnuncio(AnuncioBean anuncio);
        IList<Anuncio> GetAnuncios();

    }

    public class AnuncioRepository : BaseRepository<Anuncio>, IAnuncioRepository
    {
        public AnuncioRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public IList<Anuncio> GetAnuncios()
        {
            return dbSet.ToList();
        }

        public string SaveAnuncio(AnuncioBean anuncio)
        {
            if (!dbSet.Where(a => a.Codigo == anuncio.Codigo).Any())
            {                   
                var marca = contexto.Set<Marca>().Where(f => f.Id == anuncio.IdMarca).SingleOrDefault();
                var modelo = contexto.Set<Modelo>().Where(f => f.Id == anuncio.IdModelo).SingleOrDefault();
                DateTime data = Convert.ToDateTime(anuncio.DataVenda);
                if (data != null)
                {
                    dbSet.Add(new Anuncio(anuncio.Codigo, anuncio.Descricao, anuncio.Ano, anuncio.ValorCompra, anuncio.ValorVenda,
                            anuncio.Cor, anuncio.TipoCombustivel, Convert.ToDateTime(anuncio.DataVenda), marca, modelo));
                
                    contexto.SaveChanges();
                    return "Anúncio Cadastrado com sucesso.";
                }
            }
                return "Anúncio já está cadastrado.";
        }
    }

    public class AnuncioBean
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public int Ano { get; set; }
        public decimal ValorCompra { get; set; }
        public decimal ValorVenda { get; set; }
        public string Cor { get; set; }
        public string TipoCombustivel { get; set; }
        public string DataVenda { get; set; }
        public int IdMarca { get; set; }
        public int IdModelo { get; set; }

    }
}
