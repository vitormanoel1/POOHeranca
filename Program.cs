using System;
using POO_Heranca.classes;

namespace POO_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {

            // Pessoa Física
            PessoaFisica pf = new PessoaFisica();

            pf.nome = "vitor";

            pf.cpf = "503.406.366-29";

            Console.WriteLine(pf.DarBoasVindas(pf.nome));

            Console.WriteLine($"CPF Validado: {pf.ValidarCPF(pf.cpf)}");

            // Pessoa Jurídica
            PessoaJuridica pj = new PessoaJuridica();

            pj.nome = "manoel";

            Console.WriteLine(pj.DarBoasVindas(pj.nome));

            pj.cnpj = "61.643.558/8765-65";

            pj.inscricaoEstadual = "602-787-349-21";

            Console.WriteLine($"CNPJ Validado: {pj.ValidarCNPJ(pj.cnpj)}");
        }
    }
}
