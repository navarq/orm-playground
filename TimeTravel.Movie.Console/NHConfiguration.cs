using System;
using System.Collections.Generic;
using System.Text;
using NHibernate.Cfg;
using Microsoft.Extensions.Configuration;

namespace TimeTravel.Movie.Console
{
    public class NHConfiguration
    {
        private readonly IConfiguration Configuration;

        public NHConfiguration(IConfiguration configuration)
        {
            Configuration = configuration;

            Configuration.GetConnectionString("DefaultConnection");
        }
    }
}
