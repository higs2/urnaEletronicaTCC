﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace urnaEletronicaTCC.Models
{
    internal class Cadastro
    {
        public int id_user { get; set; }
        public string nome { get; set; }
        public int numero { get; set; }
        public string curso { get; set; }
        public string foto { get; set; }

        public Cadastro() { }

        public Cadastro
            (
            string _nome,
            int _numero,
            string _curso,
            string _foto

            )
        {
            nome = _nome;
            numero = _numero;
            curso = _curso;
            foto = _foto;

        }

    }
}
