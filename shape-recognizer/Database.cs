using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace shape_recognizer
{
    static class Database
    {
        //public List<Polygon2D> Shapes { get; private set; }
        //public List<string> Classes { get; private set; }
        //public List<Relations> Features { get; private set; }

        //private SQLiteConnection sqlite_conn;
        //private static string DbFileName = "ShapeRecognizer.sqlite";
        //public Database()
        //{
        //    //sqlite_conn = new SQLiteConnection("Data Source=database.sqlite;Version=3;");
        //    Classes = new List<string>();
        //    Shapes = new List<Polygon2D>();
        //    Features = new List<Relations>();
        //}

        //public static void InitDB()
        //{
        //    if (File.Exists(DbFileName))
        //    {
        //        SQLiteConnection.CreateFile(DbFileName);
        //        SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=" + DbFileName+";Version=3;");
        //        m_dbConnection.Open();
        //        string sql = "create table shapes (id integer primary key, name text not null)";
        //        SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
        //        command.ExecuteNonQuery();
        //        sql = "insert into shape values ('Rectangle'),('Circle'),('Triangle'),('Diamond'),('Ellipse')";
        //        command = new SQLiteCommand(sql, m_dbConnection);
        //        command.ExecuteNonQuery();
        //        sql = "create table history (id integer primary key, shape_class integer, lenpch real, pch2ach real altach real, pchper real, achaeralt real, foreign key(shape_class) references shape())";
        //        command = new SQLiteCommand(sql, m_dbConnection);
        //        command.ExecuteNonQuery();
        //        m_dbConnection.Close();
        //    }                        
        //    //SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
        //    //SQLiteDataReader reader = command.ExecuteReader();
        //    //reader.Read            
        //}
        
        
    }
}
