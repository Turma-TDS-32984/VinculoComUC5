using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace VinculoComUC5
{ 
    /// <summary>
    /// Representa as pessoas da base de dados dadosdogoverno.txt
    /// </summary>
    public class Pessoa
    {
        // private -> Este campo fica visivel apenas no Pessoa.cs
        private string _nome;
        private char _sexo;
        private string _escolaridade;
        private string _classe;
        public string nome 
        {
            get { return _nome; }
        }
        public char sexo
        {
            get { return _sexo; }
        }
        public string escolaridade
        {
            get { return _escolaridade; }
        }
        public string classe
        {
            get { return _classe; }
        }
        // public -> Este construtor fica visivel para todos
        /// <summary>
        /// Construindo a identidade da pessoa em outro código
        /// </summary>
        /// <param name="nome">Nome da pessoa na base de dados</param>
        /// <param name="sexo">Sexo da pessoa na base de dados</param>
        /// <param name="escolaridade">Escolaridade da pessoa na base de dados</param>
        /// <param name="classe">Classe da pessoa na base de dados</param>
        public Pessoa(string nome, char sexo, string escolaridade, string classe)
        {
            this._nome = nome; // Tanto faz com o this, quanto sem o this
            _sexo = sexo;
            _escolaridade = escolaridade;
            _classe = classe;
            
        }
        /// <summary>
        /// Atualizar os campos do dado selecionado
        /// </summary>
        /// <param name="nome">Atualizar o campo do nome</param>
        /// <param name="escolaridade">Atualizar o campo do escolaridade</param>
        /// <param name="sexo">Atualizar o campo do sexo</param>
        /// <param name="classe">Atualizar o campo do sexo</param>
        public void atualizarCampos(string nome, string escolaridade, char sexo, string classe)
        {
            _nome = nome;
            _sexo = sexo;
            _classe = classe;
            _escolaridade = escolaridade;
        }
  
        public override string ToString() => _nome;
        //public override string ToString(){
        //   return _nome;
        //  }
    }
}
