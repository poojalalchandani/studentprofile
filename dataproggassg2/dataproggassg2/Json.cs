using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace dataproggassg2
{
    internal class Json
    {
        public static void Start(string filePath)
        {
            JSONSerializer(filePath);
            JSONDeserializer(filePath);
        }

        public static void JSONDeserializer(string filePath)
        {
            if (File.Exists(filePath))
            {
                string content = File.ReadAllText(filePath);
                //List<Customers> emp = JsonSerializer.Deserialize<List<Customers>>(content);
                details dt = JsonSerializer.Deserialize<details>(content);
                Console.WriteLine($"ID: {dt.ID}, FirstName: {dt.FirstName}, LastName: {dt.LastName},  Email: {dt.Emailid}, Course: {dt.CourseName}, Password: {dt.Password} ");


            }
        }



        public static void JSONSerializer(string filePath)
        {
            details dt = new details();
            Console.WriteLine("Enter your first name");
            dt.FirstName = Console.ReadLine();
            Console.WriteLine("Enter your last name");
            dt.LastName = Console.ReadLine();
            Console.WriteLine("Enter your ID");
            dt.ID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your course name");
            dt.CourseName = Console.ReadLine();
            Console.WriteLine("Enter your emailid");
            dt.Emailid = Console.ReadLine();
            Console.WriteLine("Enter your password");
            dt.Password = Console.ReadLine();



            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(dt, options);

            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine(jsonString);
            }
        }
    }
}

    
    

