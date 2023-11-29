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
        private string _npessoa;
        private string _cPF;
        private string _telefone;
        private string _senha;


        public Cliente(string npessoa,
                       string cpf,
                       string Telefone,
                       string senha)
        {
           
            _npessoa = npessoa;
            _cPF = cpf;
            _telefone = Telefone;
            _senha = senha;
        }
        public Cliente(int id,                     
                       string npessoa,
                       string cpf,
                       string Telefone,
                       string senha)
        {
            _id = id;           
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
