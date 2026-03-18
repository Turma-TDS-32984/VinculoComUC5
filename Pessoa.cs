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
    internal class Pessoa
    {
        // private -> Este campo fica visivel apenas no Pessoa.cs
        private string _nome;
        private char _sexo;
        private string _escolaridade;
        private string _classe;
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
        public override string ToString() => _nome;
        /*public override string ToString(){
         *  return _nome;
         * }
         *  */
    }
}
