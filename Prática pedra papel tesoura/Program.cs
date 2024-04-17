using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prática_pedra_papel_tesoura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string jogador, computador;
            bool jogarDnv = true;
            string resposta;
            int computadorV = 0;
            int jogadorV = 0;
            int empate = 0;

            while (jogarDnv)
            {

                jogador = "";
                computador = "";
                resposta = "";

                while (jogador != "PEDRA" && jogador != "PAPEL" && jogador !="TESOURA")
                {           
                Console.WriteLine("Informe PEDRA, PAPEL ou TESOURA: ");
                jogador = Console.ReadLine();
                jogador = jogador.ToUpper();

                Console.WriteLine(jogador);
                }

                switch (random.Next(1, 4))
                {
                    case 1:
                        computador = "PEDRA";
                            break;
                    case 2:
                        computador = "PAPEL";
                            break;
                    case 3:
                        computador = "TESOURA";
                            break;
                }
                Console.WriteLine("Jogador: " +jogador);
                Console.WriteLine("Computador: " + computador);

                switch (jogador)
                {
                    case "PEDRA":
                        if (computador == "PEDRA")
                        {
                            Console.WriteLine("Foi um empate!");
                            empate++;
                        }
                        else if (computador == "PAPEL")
                        {
                            Console.WriteLine("Você perdeu");
                            computadorV++;
                        }
                        else
                        {
                            Console.WriteLine("Você ganhou!");
                            jogadorV++;
                        }
                        break;
                    case "PAPEL":
                        if (computador == "PEDRA")
                        {
                            Console.WriteLine("Você ganhou!");
                            jogadorV++;
                        }
                        else if(computador == "PAPEL")
                        {
                            Console.WriteLine("Foi um empate!");
                            empate++;
                        }
                        else
                        {
                            Console.WriteLine("Você perdeu!");
                            computadorV++;
                        }
                        break;
                    case "TESOURA":
                        if (computador == "PEDRA")
                        {
                            Console.WriteLine("Você perdeu!");
                            computadorV++;
                        }
                        else if (computador == "PAPEL")
                        {
                            Console.WriteLine("Você ganhou!");
                            jogadorV++;
                        }
                        else
                        {
                            Console.WriteLine("Foi um empate!");
                            empate++;
                        }
                        break;
                }
                Console.WriteLine("Vitórias do jogador: " + jogadorV);
                Console.WriteLine("Vitórias do computador: " + computadorV);
                Console.WriteLine("Empates:" + empate);
                Console.WriteLine("Gostaria de jogar de novo? (S/N)");
                resposta = Console.ReadLine();
                resposta = resposta.ToUpper();

                if (resposta == "S")
                {
                    jogarDnv = true;
                }
                else
                {
                    jogarDnv= false;
                }
            }
            Console.WriteLine("Obrigado por jogar nosso jogo :D");
            Console.ReadLine();



        }
    }
}
