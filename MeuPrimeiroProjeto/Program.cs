// See https://aka.ms/new-console-template for more information
using System;

namespace meuPrimeiroProjeto
{
    class program
    {
        static void Main(string[] args)
        {
           ContaCorrente conta_do_Geraldao = new ContaCorrente ("Geraldao", 12345, 157, 50);
           ContaCorrente conta_da_Barbara = new ContaCorrente ("Barbara", 12345, 875, 30);
           ContaCorrente conta_do_Bruno = new ContaCorrente ("Bruno", 12345, 330, 70);

           Console.WriteLine("A conta é do (a) " + conta_do_Geraldao.Titular +
           ", a agência é " + conta_do_Geraldao.Agencia + " e o Numero é "
           + conta_do_Geraldao.Numero + ".");

           // A conta é do Bruno, a Agência é 12345 e o Numero é 157

           Console.WriteLine("A conta é do (a) " + conta_da_Barbara.Titular +
           ", a agência é " + conta_da_Barbara.Agencia + " e o Numero é "
           + conta_da_Barbara.Numero + ".");

           Console.WriteLine("A conta é do (a) " + conta_do_Bruno.Titular +
           ", a agência é " + conta_do_Bruno.Agencia + " e o Numero é "
           + conta_do_Bruno.Numero + ".");

        }
    }
}