using ShopRavenDB.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopRavenDB.Aplication.Dtos
{
    public class CustomerDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int CPF { get; set; }
        public DateTime BirthDate { get; set; }
        public Address Address { get; set; }
    }
}
