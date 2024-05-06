using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public class Carro
    {
        private string _placa;
        public string Placa
        {
            get
            {
                return _placa.ToUpper();
            }
            set
            {
                _placa = value;
            }
        }
        private DateTime _horaAtual;
        internal int HoraChegada
        {
            get
            {
                DateTime _horaChegada = DateTime.Now;
                return _horaChegada.Hour;
            }
        }
        public Carro(string placa)
        {
            this.Placa = placa;
        }
    }
}
