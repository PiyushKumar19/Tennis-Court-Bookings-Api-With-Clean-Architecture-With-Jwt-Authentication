using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TennisCourtBookings.Domain.Entities;

namespace TennisCourtBookings.Persistence.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<CourtBookings> CourtBookings { get; set; }
        public DbSet<TennisCourt> TennisCourts { get; set; }
    }
}
