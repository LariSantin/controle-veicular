using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;



namespace ControleVeicular.Models
{
    [DataContract]
    public class BaseModel
    {
        [DataMember]
        public int Id { get; protected set; }
    }


    public class Anuncio : BaseModel
    {
        public Anuncio()
        {

        }
		
        public Anuncio(int codigo, string descricao, int ano, decimal valorCompra, 
            decimal valorVenda, string cor, string tipoCombustivel, DateTime dataVenda, 
            Marca marca, Modelo modelo)
        {
            this.Codigo = codigo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.ValorCompra = valorCompra;
            this.ValorVenda = valorVenda;
            this.Cor = cor;
            this.TipoCombustivel = tipoCombustivel;
            this.DataVenda = dataVenda;
            this.Marca = marca;
            this.Modelo = modelo;
        
  
        
        }
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public int Ano { get; set; }
        public decimal ValorCompra { get; set; }
        public decimal ValorVenda { get; set; }
        public string Cor { get; set; }
        public string TipoCombustivel { get; set;  }
        public DateTime DataVenda { get; set; }
        public Marca Marca { get;  set; }
        public Modelo Modelo { get;  set; }
    
    }

    public class Usuario : BaseModel
    {
        public Usuario()
        {

        }
        public Usuario(string login, string senha)
        {
            this.Login = login;
            this.Senha = senha;
        }
        public string Login { get; set; }
        public string Senha { get; set; }

        
    }

    [DataContract]
    public class Modelo : BaseModel
    {
        public Modelo()
        {

        }

        public Modelo(string descricao)
        {
            this.Descricao = descricao;
        }
        [DataMember]
        public string Descricao { get; set; }
    }
    [DataContract]
    public class Marca : BaseModel
    {
        public Marca()
        {

        }
        public Marca(string descricao)
        {
            this.Descricao = descricao;
        }
        [DataMember]
        public string Descricao { get; set; }
    }

} 
