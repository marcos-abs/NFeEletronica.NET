﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WallegNfe.Model
{
    public class Nota2
    {
        public String ArquivoFisicoNome { get; set; }
        public String ArquivoFisicoCaminho { get; set; }

        public DateTime DataEmissao { get; set; }
        public String Numero { get; set; }
        public String DestinatarioNome { get; set; }
        public String DestinatarioCNPJ { get; set; }
        public NotaSituacao Situacao { get; set; }

        public String ArquivoFisicoLer()
        {
            return Bll.Arquivo.Ler(this.ArquivoFisicoCaminho);
        }
    }
}
