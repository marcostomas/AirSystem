using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSystem.Models
{
    public class Usuario
    {
        //Bool se o usuário é admin ou não
        public bool admin { get; set; }
        //ID autoincrementado dos usuários
        public int ID { get; set; }

        //Dados inseridos pelo usuario
        public string name { get; set; }
        public string surname { get; set; }

        public DateTime birthDate { get; set; }

        public string address { get; set; }
        public string address2 { get; set; }

        public string username { get; set; }
        public string password { get; set; } 

    }
}
