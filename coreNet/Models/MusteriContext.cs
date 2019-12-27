using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;
using coreNet.Controllers;
using coreNet.Entities;
using Microsoft.EntityFrameworkCore;

namespace coreNet.Models
{
    public class MusteriContext:DbContext
    {

        public MusteriContext(DbContextOptions<MusteriContext> options):base (options)
        {

        }
        
        
        DbSet<tblMusteri> tblMusteris { get; set; }
    }
}