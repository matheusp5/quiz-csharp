using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    class Questao
    {
        public string Titulo { get; set; }
        public string RespostaCorreta { get; set; }
        public List<Resposta> Respostas { get; set; }
    }
}
