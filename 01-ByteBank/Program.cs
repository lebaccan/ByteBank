using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;
            contaDaGabriela.saldo = 100.00;
            
            Console.WriteLine("Titular: " + contaDaGabriela.titular);
            Console.WriteLine("Agência número: " + contaDaGabriela.agencia);
            Console.WriteLine("Conta Corrente número: " + contaDaGabriela.numero);
            Console.WriteLine("Saldo da Conta: R$ " + contaDaGabriela.saldo);

            contaDaGabriela.saldo += 200;
            Console.WriteLine("Saldo Atual da Conta: R$ " + contaDaGabriela.saldo);



            Console.ReadLine();

        }
    }
}
