using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_banco
{
    public class Cliente
    {
        public string nome;
        public string CPF;
        public string profissao;

        public Cliente(string nome, string CPF, string profissao)
        {
            this.setNome(nome);
            this.setCPF(CPF);
            this.setProfissao(profissao);
        }

        public string getNome()
        {
            return this.nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getCPF()
        {
            return this.CPF;
        }

        public void setCPF(string CPF)
        {
            this.CPF = CPF;
        }

        public string getProfissao()
        {
            return this.profissao;
        }

        public void setProfissao(string profissao)
        {
            this.profissao = profissao;
        }
    }
}