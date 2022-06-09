using System;

namespace FunctionApp1.DataAccess.Entities
{
    internal class ClientEntity
    {
        public Guid Id{ get; set; }
        public bool IsActive { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
