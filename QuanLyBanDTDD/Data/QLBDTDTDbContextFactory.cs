using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace QuanLyBanDTDD.Data
{
    public class QLBDTDTDbContextFactory : IDesignTimeDbContextFactory<QLBDTDTDbContext>
    {
        
        
            public QLBDTDTDbContext CreateDbContext(string[] args)
            {
                var optionsBuilder = new DbContextOptionsBuilder<QLBDTDTDbContext>();

                // Đọc từ App.config
                var connectionString = ConfigurationManager.ConnectionStrings["QLBDTDTConnection"]?.ConnectionString;

                if (string.IsNullOrEmpty(connectionString))
                {
                    throw new InvalidOperationException("Connection string 'QLBDTDTConnection' not found in App.config");
                }

                optionsBuilder.UseSqlServer(connectionString);

                return new QLBDTDTDbContext(optionsBuilder.Options);
            }
        

    }
}
