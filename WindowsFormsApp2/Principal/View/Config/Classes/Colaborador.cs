using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Principal.View.Config
{
    class Colaborador
    {
        public int idCargo { get; set; }
        public string nomeFunc { get; set; }
        public DateTime dataNasc { get; set; }
        public bool sexo { get; set; }
        public string log_in { get; set; }
        public string senha { get; set; }
        public string email { get; set; }
        public DateTime dataCriacao { get; set; }
        public DateTime horaCriacao { get; set; }
        public bool funcEstado{ get; set; }

    }
}

