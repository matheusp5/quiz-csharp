using System;
using System.Collections.Generic;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            int corretas = 0;
            int erradas = 0;

            var questoes = new List<Questao>()
            {
                new Questao() { Titulo = "O que é o .NET", Respostas = new List<Resposta>() 
                {
                    new Resposta() { TituloResposta = "Uma linguagem de programação", RespostaLetra = "A" },
                    new Resposta() { TituloResposta = "Uma plataforma de desenvolvimento", RespostaLetra = "B" },
                    new Resposta() { TituloResposta = "Um sistema operacional", RespostaLetra = "C" }
                }, RespostaCorreta = "B" },

                new Questao() { Titulo = "C# morreu?", Respostas = new List<Resposta>()
                {
                    new Resposta() { TituloResposta = "Afirmativo", RespostaLetra = "A" },
                    new Resposta() { TituloResposta = "Sim", RespostaLetra = "B" },
                    new Resposta() { TituloResposta = "Não", RespostaLetra = "C" }
                }, RespostaCorreta = "C" },
            };

            var point = 10 / questoes.Count;

            foreach (Questao quest in questoes)
            {
                Console.Clear();
                Console.WriteLine(quest.Titulo);
                foreach(Resposta resp in quest.Respostas)
                {
                    Console.WriteLine($"  {resp.TituloResposta} | {resp.RespostaLetra}");
                }
                Console.Write("Sua resposta: ");
                var rest = Console.ReadLine();
                if(rest.ToUpper() == quest.RespostaCorreta.ToUpper())
                {
                    // acertou
                    corretas++;
                } else
                {
                    // errou
                    erradas++;
                }
            }
            Console.Clear();
            if (corretas == questoes.Count)
            {
                Console.WriteLine("TODAS CORRETAS");
            } else
            {
                Console.WriteLine($"{corretas} CORRETAS e {erradas} ERRADAS");
                Console.WriteLine($"SUA NOTA FOI { corretas * point }");
            }
        }
    }
}
