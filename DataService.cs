﻿using Microsoft.EntityFrameworkCore;

namespace ControleVeicular
{
    public class DataService : IDataService
    {
        
        private readonly ApplicationContext contexto;

        public DataService(ApplicationContext contexto)
        {
            this.contexto = contexto;
          
        }

        public void InicializaDB()
        {
            contexto.Database.Migrate();
        }
    }
}
