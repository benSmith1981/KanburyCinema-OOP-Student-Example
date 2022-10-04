using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace KanburyCinema
{
    public class Person
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
    }
}
