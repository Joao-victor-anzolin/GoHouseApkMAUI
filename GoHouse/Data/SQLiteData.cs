using GoHouse.Data;
using GoHouse.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoHouse.Data
{
    public class SQLiteData
    {
        readonly SQLiteAsyncConnection _conexaoDb;

        public UserData UserDataTable { get; set; }
        public SQLiteData(string path)
        {
            _conexaoDb = new SQLiteAsyncConnection(path);
            _conexaoDb.CreateTableAsync<Usuario>().Wait();

            UserDataTable = new UserData(_conexaoDb);
        }
    }
}