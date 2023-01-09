using System;
using System.Dynamic;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while(partida.terminada == false) 
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.WriteLine();

                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

                    bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();
                    
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executaMovimento(origem, destino);
                }

                

            }
            catch (TabuleiroException e)
            {
                Console.WriteLine("erro: " + e.Message);
            }



            Console.ReadLine();
        }
    }
}