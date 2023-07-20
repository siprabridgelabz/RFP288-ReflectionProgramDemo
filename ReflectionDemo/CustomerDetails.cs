using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    public class CustomerDetails
    {
        public int a, b;
        public int Id { get; set; }
        public string Name { get; set; }
        public CustomerDetails()
        {
            Id = 1;
            Name = "Sipra";
        }
        public CustomerDetails(int id)
        {
            Id = id;
        }
        public void Display()
        {

        }
        public void Update(int d)
        {

        }
    }
}
