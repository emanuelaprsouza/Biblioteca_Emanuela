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


        public Cliente(string nomeLivro, 
                       string autor,
                       string tempo,
                       string npessoa,
                       string cpf,
                       string Telefone)
        {
            _nomeLivro = nomeLivro;
            _autor = autor;
            _tempo = tempo;
            _npessoa = npessoa;
            _cPF = cpf;
            _telefone = Telefone;
        }
        
        //propriedades 
        public int id
        {
            set { this._id = value; }
            get { return this._id; }
        }

        public string NomeLivro  
        {
            set { this._nomeLivro = value; }
            get { return this._nomeLivro; }
        }

        public string Autor
        {
            set { this._autor = value; }
            get { return this._autor; }
        }

        public string Tempo
        {
            set { this._nomeLivro = value; }
            get { return this._nomeLivro; }
        }

        public string Npessoa
        {
            set { this._npessoa = value; }
            get { return this._npessoa; }
        }

        public string CPF
        {
            set { this._cPF = value; }
            get { return this._cPF; }
        }

        public string telefone
        {
            set { this._telefone = value; }
            get { return this._telefone; }
        }
    }
}
