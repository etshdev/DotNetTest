using DotNetTest.Tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTest.DAL
{
    public class AppContext:DbContext
    {
        public AppContext(DbContextOptions<AppContext> options) : base(options) { }


        #region Overrides

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {




        }

        #endregion
        #region Entities



        #region Guide

        public DbSet<Driver> Drivers { set; get; }

        #endregion




        #endregion
    }
}
