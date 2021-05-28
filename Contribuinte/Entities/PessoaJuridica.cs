using System;
using System.Collections.Generic;
using System.Text;

namespace Contribuinte.Entities
{
    class PessoaJuridica : Pessoa
    {
        public int QtFuncionario { get; set; }

        public PessoaJuridica(int qtFuncionario, string nome, double rendaAnual) 
            : base(nome, rendaAnual)
        {
            QtFuncionario = qtFuncionario;
        }

        public override double CalculaImposto()
        {
            if (QtFuncionario > 10)
            {
                return RendaAnual * 0.14;
            }
            else
            {
                return RendaAnual * 0.16;
            }
        }
    }
}
