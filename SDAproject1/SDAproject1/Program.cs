using System;

namespace SDAproject1
{
    class Program
    {
        static void Main(string[] args)
        {
            StoreData teacherInfo = new StoreData();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Rainbow School Teachers' Data System\n");
            Console.ForegroundColor = ConsoleColor.White;
            var a = true;
            while (a)
            {
                Console.WriteLine("Please choose from the following  options\n1- Adding New Teacher.\n2- Retrieve Data from the system." +
                    "\n3- Update Teacher Data. \n4- Exit The System.\n\n");
                int? userinput = null;
                try
                {
                    int input = Convert.ToInt32(Console.ReadLine());
                    userinput = input;
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("please enter a valid option");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                switch (userinput)
                {
                    case 1:
                        try
                        {
                            Console.WriteLine("Please enter Teacher ID :");
                            int ID = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Please enter Teacher Name :");
                            string Teachername = Console.ReadLine();
                            Console.WriteLine("Please enter Teacher Class :");
                            string Clas = Console.ReadLine();
                            Console.WriteLine("Please enter Teacher Section :");
                            string Section = Console.ReadLine();
                            teacherInfo.AddNewItem(ID, Teachername, Clas, Section);
                        }
                        catch (Exception)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("please enter a valid ID");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;

                    case 2:
                        
                        Console.WriteLine("Please enter Teacher ID :");
                            int s_ID = Convert.ToInt32(Console.ReadLine());
                            TeacherInfo ret = teacherInfo.GetTeacherInfo(s_ID);
                        if (ret != null)
                        {
                            Console.WriteLine($"Techer info are \nID: {ret.ID}.\tName: {ret.Teachername}.\tClass: {ret.Clas}.\tSection: {ret.Section}");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Techer Does NOT exist");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;

                    case 3:
                        Console.WriteLine("Please enter Teacher ID :");
                        int s1_ID = Convert.ToInt32(Console.ReadLine());
                        TeacherInfo ret1 = teacherInfo.GetTeacherInfo(s1_ID);
                        if (ret1 != null)
                        {
                            Console.WriteLine($"Techer info are \nID: {ret1.ID}.\tName: {ret1.Teachername}.\tClass: {ret1.Clas}.\tSection: {ret1.Section}");
                            int previuse_ID = ret1.ID;
                            Console.WriteLine("Please Enter new ID");
                            int current_ID = int.Parse(Console.ReadLine());
                            Console.WriteLine("Please Enter new Name ");
                            string new_Teachername = Console.ReadLine();
                            Console.WriteLine("Please Enter new Class");
                            string new_Clas = Console.ReadLine();
                            Console.WriteLine("Please Enter new Section");
                            string new_Section = Console.ReadLine();
                            teacherInfo.Update(previuse_ID, current_ID, new_Teachername, new_Clas, new_Section);
                        }
                
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Techer Does NOT exist");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;
                    case 4:
                        a = false;
                        Console.WriteLine("GoodBye");
                        break;
                    default:
                        Console.WriteLine("Please choose from the options listed");
                        break;
                }
              
            }
        }
    }
}