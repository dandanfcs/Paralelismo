using Paralelismo.Services;
using System;
using System.Diagnostics;
using System.Threading;

namespace Paralelismo
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessoSemParalelismo.Exemplo();
            Console.WriteLine("Executando com multilplas Threads \n");
            ProcessoComParalelismo.Exemplo();

            //ProcessoSemParalelismo.BuscarCepsSemParalelismo();
            //Console.WriteLine("Executando com multilplas Threads \n");
            //ProcessoComParalelismo.BuscarCepsComParalelismo();
        }
    }
}
