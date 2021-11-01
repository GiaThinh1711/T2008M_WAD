using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace T2008M_WAD.Models
{
    public class DataContext :DbContext
    {
        public DataContext() : base("T2008M_WAD")
        {

        }
        

        public System.Data.Entity.DbSet<T2008M_WAD.Models.Practicals> Practicals { get; set; }
    }
}