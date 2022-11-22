using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pensionato.Models
{
    public class Quarto
    {
        public int Id { get; set; }
        public int TotalEstudantes { get; set; }
        public Estudante Estudante { get; set; }

        public Quarto(int id, int totalEstudantes)
        {
            Id = id;
            TotalEstudantes = totalEstudantes;
            
        }
        public Quarto(int id, int totalEstudantes, string nome , string email)
        {
            Id = id;
            TotalEstudantes = totalEstudantes;
            Estudante = new Estudante(nome , email);
        }

    }
}
