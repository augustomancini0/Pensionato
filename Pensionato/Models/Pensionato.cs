using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pensionato.Models
{
    public class Hotelaria
    {
        public List<Quarto> Quartos = new List<Quarto>();
        public Hotelaria()
        {
            Quartos = ConstroiQuartos();
        }
        private List<Quarto> ConstroiQuartos(int quantidadeQuartos = 10)
        {
            List<Quarto> quartos = new List<Quarto>();
            for (int i = 0; i < quantidadeQuartos; i++)
            {
                quartos.Add(new Quarto(i, 0));
            }
            return quartos;
        }
    }
}
