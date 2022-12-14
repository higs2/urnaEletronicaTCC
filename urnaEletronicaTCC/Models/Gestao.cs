using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace urnaEletronicaTCC.Models
{
    public class Gestao
    {
        public int idUser { get; set; }
        public string nome { get; set; }
        public string numero { get; set; }
        public string curso { get; set; }
        public string foto { get; set; }



        public Gestao() { }

        public Gestao
            (
           
            string _nome,
            string _numero,
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
