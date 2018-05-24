﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace shape_recognizer
{
    class Database
    {
        public List<Polygon2D> Shapes { get; private set; }
        public List<string> Classes { get; private set; }
        public List<Relations> Features { get; private set; }
        //private SQLiteConnection sqlite_conn;

        public Database()
        {
            //sqlite_conn = new SQLiteConnection("Data Source=database.sqlite;Version=3;");
            Classes = new List<string>();
            Shapes = new List<Polygon2D>();
            Features = new List<Relations>();
        }

        public void InitDB()
        {
            SQLiteConnection.CreateFile("ShapeRecognizer.sqlite");
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");

            string sql = "create table shapes (id integer primary key, name text not null)";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
            //SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            //SQLiteDataReader reader = command.ExecuteReader();
            //reader.Read
            
        }
        
    }
}
