using Paralelismo.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace Paralelismo
{
    public class ProcessoSemParalelismo
    {
        public static void Exemplo()
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            Processo1();
            Processo2();
            Processo3();
            stopWatch.Stop();

            Console.WriteLine($"O tempo de processamento total é de: {stopWatch.ElapsedMilliseconds} ms \n");
        }
        static void Processo1()
        {
            Console.WriteLine($"Processo 1 Finalizado, Thread: {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(2000);
        }
        static void Processo2()
        {
            Console.WriteLine($"Processo 2 Finalizado, Thread: {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(2000);
        }
        static void Processo3()
        {
            Console.WriteLine($"Processo 3 Finalizado, Thread: {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(2000);
        }
        public static void BuscarCepsSemParalelismo()
        {
            var cepServices = new CepServices();
            var stopWatch = new Stopwatch();
            var listaDeCeps = ListaDeCeps();

            stopWatch.Start();

            foreach (var cep in listaDeCeps)
            {
                Console.WriteLine(cepServices.ObterCep(cep) + $" Thread: {Thread.CurrentThread.ManagedThreadId}");
            }

            stopWatch.Stop();
            Console.WriteLine($"\nO tempo de processamento total é de: {stopWatch.ElapsedMilliseconds} ms \n");
        }

        public static List<string> ListaDeCeps()
        {
            var ceps = new List<string>();

            ceps.Add("39100000");//Diamantina
            ceps.Add("35860000");//CMD
            ceps.Add("01001000");//São Paulo
            ceps.Add("30672772");//BH
            ceps.Add("20021000");//Rio de Janeiro
            ceps.Add("06542089");//Curtiba
            ceps.Add("40020-160");//Bahia
            ceps.Add("59180-000");//Espirito Santo
            ceps.Add("69036-662");//Manaus
            ceps.Add("35182016");//Florianópolis

            return ceps;
        }
    }
}
