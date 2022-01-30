using System;
using System.ComponentModel.DataAnnotations;

namespace Portfolio03.Models
{
    public class Person
    {

        public int Id { get; set; }
        public String Name { get; set; }
        public int Age { get; set; }
        public String Qualification { get; set; }
        public String Post { get; set; }
        public String Language { get; set; }
        public String Email { get; set; }
        public String Phone { get; set; }
        public String Address { get; set; }
    }
}
