using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {

            Exercise1_1("employee.xml");

            // これは確認用
            Console.WriteLine(File.ReadAllText("employee.xml"));
            Console.WriteLine();

            Exercise1_2("employees.xml");
            Exercise1_3("employees.xml");
            Console.WriteLine();

            Exercise1_4("employees.json");

            // これは確認用
            Console.WriteLine(File.ReadAllText("employees.json"));
        }

        private static void Exercise1_1(string v) {

            var emp = new Employee
            {
                Id = 00001,
                Name = "竹政 優希",
                HireDate = new DateTime(2023,09,05),
            };

            using (var writer = XmlWriter.Create(v))
            {
                var serializer = new XmlSerializer(emp.GetType());
                serializer.Serialize(writer, emp);
            }

            using (var reader = XmlReader.Create(v))
            {
                var serializer = new XmlSerializer(typeof(Employee));
                var readEmp = serializer.Deserialize(reader) as Employee;
                Console.WriteLine(emp);
            }

        }

        private static void Exercise1_2(string v) {
            var emps = new Employee[]
            {
                new Employee
                {
                    Id = 00002,
                    Name = "竹政いずみ",
                    HireDate = new DateTime(2020,02,28),
                },

                new Employee
                {
                    Id = 00003,
                    Name = "竹政 正",
                    HireDate = new DateTime(2022,04,05),
                },
            };

            var settings = new XmlWriterSettings
            {
                Encoding = new System.Text.UTF8Encoding(false),
                Indent = true,
                IndentChars = " ",
            };

            using (var writer = XmlWriter.Create(v, settings))
            {
                var serializer = new DataContractSerializer(emps.GetType());
                serializer.WriteObject(writer, emps);
            }
        }

        private static void Exercise1_3(string v) {
            using (var reader = XmlReader.Create(v))
            {
                var serializer = new DataContractSerializer(typeof(Employee[]));
                var readEmp = serializer.ReadObject(reader) as Employee[];
                foreach (var emp in readEmp)
                {
                    Console.WriteLine(emp);
                }
            }

        }

        private static void Exercise1_4(string v) {
            var emps = new Employee[]
            {
                new Employee
                {
                    Id = 00002,
                    Name = "商品2",
                    HireDate = DateTime.Now
                },

                new Employee
                {
                    Id = 00003,
                    Name = "商品3",
                    HireDate = DateTime.Now
                },
            };

            using (var stream = new FileStream(v, FileMode.Create, FileAccess.Write))
            {
                var serializer = new DataContractJsonSerializer(emps.GetType());
                serializer.WriteObject(stream, emps);
            }
        }
    }

    [DataContract]
    public class Employee2 {
        public int Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name ="hireDate")]
        public DateTime HireDate { get; set; }
    }
    
}
