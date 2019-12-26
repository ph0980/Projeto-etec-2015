using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dto
{
    class usuarioDTO
    {
        private string nome;
        private string senha;
        private string pergunta;
        private string resposta;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }


        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }


        public string Pergunta
        {
            get { return pergunta; }
            set { pergunta = value; }
        }


        public string Resposta
        {
            get { return resposta; }
            set { resposta = value; }
        }
    }
}
