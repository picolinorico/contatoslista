using System;
using System.Security.Cryptography.X509Certificates;

namespace contatoslista
{
    internal class Contato
    {
        private string primeirosexo;
        private string sobrenome;
        private string telefone;
        private string email;

        public string PrimeiroNome
        {
            get { return primeirosexo; }
            set { primeirosexo = value; }
        }
        public string Sobrenome
        {
            get { return sobrenome; }
            set { sobrenome = value; }
        }
        public string Telefone
        {
            get { return telefone; }
            set
            {
                if (value.Length == 11)

                    telefone = value;
                else

                    telefone = "00000000000";
            }
        }



        public string Email
        {
            get { return email; }
            set { email = value; }
        }


        //Método Construtor da Classe 

        public Contato()
        {
            PrimeiroNome = "José";
            sobrenome = "Carlos Libralon";
            Telefone = "69999290900";
        }
        //Sobrecarga do método construtor da classe 

        public Contato(string primeironome, string sobrenome, string telefone, string email)
        {
            PrimeiroNome = primeironome;
            Sobrenome = sobrenome;
            Telefone = telefone;
            Email = email;
        }

        public override string ToString()
        {
            string saida = String.Empty;
            saida += string.Format("{0} {1}", PrimeiroNome, Sobrenome);
            saida += " ";
            saida += String.Format("{0}-{1}-{2}", Telefone.Substring(0, 1), Telefone.Substring(2, 4), Telefone.Substring(7, 3));
            saida += " "; 
            saida += string.Format(Email);

            return saida;
        }

    }
}
