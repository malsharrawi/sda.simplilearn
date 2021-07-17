using System;
using System.IO;

namespace SDAproject1
{
    class StoreData
    {
        public string path;
        StreamWriter writer;
        public StoreData()
        {
            path = @"C:\Users\malsh\Desktop\TeacherStoreData.txt";
        }
        public void AddNewItem(int ID, string Teachername, string Clas, string Section)
        {
            writer = File.AppendText(path);
            string value = ID + "-" + Teachername + "-" + Clas + "-" + Section + "\n";
            writer.Write(value);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Added successfully");
            Console.WriteLine("Thanks for using our system");
            Console.ForegroundColor = ConsoleColor.White;
            writer.Close();
        }
        public TeacherInfo GetTeacherInfo(int ID)
        {
            string[] lines = File.ReadAllLines(path);
            foreach (string s in lines)
            {
                string[] line = s.Split('-');
                if (int.Parse(line[0]) == ID)
                {
                    TeacherInfo teacherInfo = new TeacherInfo(int.Parse(line[0]), line[1], line[2], line[3]);
                    return teacherInfo;
                }

            }

            return null;
        }
        public void Update(int previuse_ID, int ID, string Teachername, string Clas, string Section)
        {
            string[] lines = File.ReadAllLines(path);
            bool status = false;
            for (int i = 0; i < lines.Length; i++)
            {
                string[] line = lines[i].Split('-');
                if (int.Parse(line[0]) == previuse_ID)
                {
                    lines[i] = ID + "-" + Teachername + "-" + Clas + "-" + Section;
                    status = true;
                }
            }
            if (status)
            {
                File.WriteAllLines(path, lines);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Updated successfully");
                Console.WriteLine("Thanks for using our system");
                Console.ForegroundColor = ConsoleColor.White;
            }



        }
    }
}