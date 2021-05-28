using System;
using System.Collections.Generic;
using System.Text;

namespace Contribuinte.Entities
{
    class PessoaFisica : Pessoa
    {
        public double GastoSaude { get; set; }

        public PessoaFisica(double gastoSaude, string nome, double rendaAnual)
            :base(nome, rendaAnual)
        {
            GastoSaude = gastoSaude;
        }

        public override double CalculaImposto()
        {
            double impostopf = 0.0;
            if (RendaAnual < 20000.00)
            {
                impostopf = (RendaAnual * 0.15) - (GastoSaude * 0.50);
            }
            else
            {
                impostopf = (RendaAnual * 0.25) - (GastoSaude * 0.50);
            }
            return impostopf;
        }
    }
}
