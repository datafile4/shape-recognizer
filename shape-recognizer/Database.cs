using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CsvHelper;

namespace shape_recognizer
{
    static class Database
    {
        private static string dbFileName = "Data.csv";

        public static List<ClassifiedShape> ReadDB()
        {
            List<ClassifiedShape> classifiedShapes = new List<ClassifiedShape>();
            using (TextReader textReader = File.OpenText(dbFileName))
            {
                var csv = new CsvReader(textReader);
                csv.Configuration.HasHeaderRecord = true;
                csv.Read();
                csv.ReadHeader();
                while (csv.Read())
                {
                    Relations relations = new Relations();
                    //LenPch,Pch2Ach,AltAch,PchPer,AchAerAlt
                    ShapeClass shapeClass = csv.GetField<ShapeClass>("shapeClass");
                    relations.LenPch = csv.GetField<double>("LenPch");
                    relations.Pch2Ach = csv.GetField<double>("Pch2Ach");
                    relations.AltAch = csv.GetField<double>("AltAch");
                    relations.PchPer = csv.GetField<double>("PchPer");
                    relations.AchAerAlt = csv.GetField<double>("AchAerAlt");
                    classifiedShapes.Add(new ClassifiedShape(relations, shapeClass));
                }
            }
            return classifiedShapes;
        }

        public static void WriteDB(List<ClassifiedShape> records)
        {
            using (TextWriter textWriter = File.CreateText(dbFileName))
            {
                var csv = new CsvWriter(textWriter);
                csv.WriteHeader<ClassifiedShape>();

                csv.NextRecord();
                foreach (ClassifiedShape i in records)
                {                    
                    if (i != null)
                    {
                        csv.WriteRecord(i);
                    }
                }
                csv.Flush();
            }
        }
    }
}
