﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Data.Infrastructure
{
    class UniOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private TeduShopDbContext dbContext;
        public UniOfWork(IDbFactory dbFactory   )
        {
            this.dbFactory = dbFactory;
        }

        public TeduShopDbContext DbContext
        {

            get { return dbContext ?? (dbContext = dbFactory.Init()); }
        }
        public void Comit()
        {
            DbContext.SaveChanges();
        }
    }
}
