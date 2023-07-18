using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace laba4
{
    public class ConsoleReporting
    {
        public void Parse(List<Object> objects)
        {
            foreach (Object obj in objects)
            {
                Type type = obj.GetType();

                PropertyInfo[] property;
                property = type.GetProperties();

                var Horizontal = type.GetCustomAttribute(typeof(HorizontalAligmentAttribute));
                int NumofProperties = 0;
                int noPrintable = 0;
                foreach (var item in type.GetProperties())
                {
                    bool printable = true;
                    if (Horizontal != null)
                    {
                        foreach (NoPrintableAttribute attt in item.GetCustomAttributes(false))
                        {
                            printable = false;
                            noPrintable++;
                        }
                        if (printable == true)
                        {
                            NumofProperties++;
                            Console.Write($"| {item.Name} - {item.GetValue(obj)} |");
                        }
                        if (NumofProperties == 4 - noPrintable)
                        {
                            Console.WriteLine("\n============");
                            NumofProperties = 0;
                            noPrintable = 0;
                        }
                    }
                    else
                    {
                        foreach (NoPrintableAttribute attt in item.GetCustomAttributes(false))
                        {
                            printable = false;
                            noPrintable++;
                        }
                        if (printable == true)
                        {
                            NumofProperties++;
                            Console.WriteLine($"{item.Name} - {item.GetValue(obj)}");
                        }
                        if (NumofProperties == 4 - noPrintable)
                        {
                            Console.WriteLine("\n================");
                            NumofProperties = 0;
                            noPrintable = 0;
                        }
                    }
                }
            }
        }
    }
    public class NoPrintableAttribute : Attribute
    {
    }
    public class HorizontalAligmentAttribute : Attribute
    {
    }
    public class Service
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [NoPrintable]
        public string Description { get; set; }
        
        public int Article { get; set; }
    }

    [HorizontalAligment]
    public class Good
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [NoPrintable]
        public string Description { get; set; }
        public int Article { get; set; }
    }
}
