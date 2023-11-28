using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emanuela3B
{
    public class Cliente
    {
        //atributo
        private int    _id;
        private string _nomeLivro;
        private string _autor;
        private string _tempo;
        private string _npessoa;
        private string _cPF;
        private string _telefone;
        private string _senha;


        public Cliente(string nomeLivro, 
                       string autor,
                       string tempo,
                       string npessoa,
                       string cpf,
                       string Telefone,
                       string senha)
        {
            _nomeLivro = nomeLivro;
            _autor = autor;
            _tempo = tempo;
            _npessoa = npessoa;
            _cPF = cpf;
            _telefone = Telefone;
            _senha = senha;
        }
        public Cliente(int id,
                       string nomeLivro,
                       string autor,
                       string tempo,
                       string npessoa,
                       string cpf,
                       string Telefone,
                       string senha)
        {
            _id = id;
            _nomeLivro = nomeLivro;
            _autor = autor;
            _tempo = tempo;
            _npessoa = npessoa;
            _cPF = cpf;
            _telefone = Telefone;
            _senha= senha;  
        }

        //propriedades (não tem abre e fecha parenteses )
        public int id
        {
            set { this._id = value;} // assumir o valor dos dados , set serve para validar os dados ,exemplo cpf,faz a atribuição do valor         
            get { return this._id; } // retornar o valor 
        }

        public string NomeLivro  
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Nome de livro inválido");

                this._nomeLivro = value;
            }
            get { return this._nomeLivro; }
        }

        public string Autor
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Autor inválido");

                this._autor = value; 
            }
            get { return this._autor; }
        }

        public string Tempo
        {
            set 
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("tempo inválido");

                this._tempo = value; 
            }
            get { return this._tempo; }    
        }

        public string Npessoa
        {
            set 
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Nome inválido ");

                this._npessoa = value; 
            }
            get { return this._npessoa; }
        }

        public string CPF
        {
            set 
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("CPF inválido");

                this._cPF = value; 
            }
            get { return this._cPF; }
        }

        public string telefone
        {
            set 
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("telefone inválido");

                this._telefone = value; 
            }
            get { return this._telefone; }
        }

        public string senha
        {
            set
            {
                
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Senha inválida");

                this._senha = value;
            }
            get { return this._senha; }
        }
    }
}
