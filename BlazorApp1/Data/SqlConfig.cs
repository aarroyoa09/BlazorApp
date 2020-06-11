using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class SqlConfig
    {

        public SqlConfig(string connectionString) => connectionString = connectionString;

        public string ConnectionString { get; }
    }
}
