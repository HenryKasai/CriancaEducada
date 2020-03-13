using System;

namespace CriancaEducada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Me diga o que você pensa sobre o aluno que não faz a lição de casa.");

            string opiniao = Console.ReadLine();

           //chato/chata, bobo/boba, feio/feia, boboca, bocó, tonto/tonta, palerma, paspalho/paspalha, tantã, panaca, pentelho/pentelha, burro/burra, besta
            Console.WriteLine(opiniao .Replace("chato" , "@#$@#$@¨%") .Replace("bobo" , "@#$@#$@¨%") .Replace("chata" , "@#$@#$@¨%") .Replace("boba" , "@#$@#$@¨%") .Replace("feio" , "@#$@#$@¨%") .Replace("feia" , "@#$@#$@¨%") .Replace("boboca" , "@#$@#$@¨%") .Replace("bocó" , "@#$@#$@¨%") .Replace("tonto" , "@#$@#$@¨%") .Replace("tonta" , "@#$@#$@¨%") .Replace("palerma" , "@#$@#$@¨%") .Replace("paspalho" , "@#$@#$@¨%") .Replace("paspalha" , "@#$@#$@¨%") .Replace("tantã" , "@#$@#$@¨%") .Replace("panaca" , "@#$@#$@¨%") .Replace("pentelho" , "@#$@#$@¨%") .Replace("burro" , "@#$@#$@¨%") .Replace("burra" , "@#$@#$@¨%") .Replace("besta" , "@#$@#$@¨%") .Replace("pentelha" , "@#$@#$@¨%")); //chato/chata, bobo/boba, feio/feia, boboca, bocó, tonto/tonta, palerma, paspalho/paspalha, tantã, panaca, pentelho/pentelha, burro/burra, besta
            Console.ReadLine();
        }
    }
}
