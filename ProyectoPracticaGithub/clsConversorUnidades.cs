using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPracticaGithub
{
    public class clsConversorUnidades
    {
        private decimal valor;
        private string tipoConversion;

        public clsConversorUnidades(decimal valor, string tipoConversion)
        {
            this.valor = valor;
            this.tipoConversion = tipoConversion;
        }

        public decimal Valor
        {
            get { return valor; }
            set
            {
                if (valor < 0)
                    MessageBox.Show("No se permiten valores negativos.");
                valor = value;

                if (string.IsNullOrEmpty(valor.ToString()))
                {
                    MessageBox.Show("No puede estar vacío el campo Valor");
                }
            }
        }

        public string TipoConversion
        {
            get { return tipoConversion; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    MessageBox.Show("Debe seleccionar una conversión.");
               
                tipoConversion = value;
                return;
            }
        }

        public decimal Convertir()
        {
            decimal resultado = 0;
            switch (tipoConversion)
            {
                case "USD a EUR":
                    resultado = valor * 0.92m;
                    break;
                case "EUR a USD":
                    resultado = valor * 1.08m;
                    break;
                case "Celsius a Fahrenheit":
                    resultado = (valor * 9 / 5) + 32;
                    break;
                case "Fahrenheit a Celsius":
                    resultado = (valor - 32) * 5 / 9;
                    break;
            }
            return Math.Round(resultado, 2);
        }

        public override string ToString()
        {
            return $"{valor} convertido ({tipoConversion}) = {Convertir()}";
        }

    }
}
