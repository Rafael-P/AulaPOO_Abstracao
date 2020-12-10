namespace POO_Abstracao.classes
{
    abstract public class Cartao : Pagamento
    {
        //Atributos
        private string bandeira;
        public string Bandeira{
            get{return bandeira;}
            set{bandeira = value;}
        }

        private string numero;
        public string Numero{
            get{return numero;}
            set{numero = value;}
        }

        private string titular;
        public string Titular{
            get{return titular;}
            set{titular = value;}
        }

        private string cvv;
        public string Cvv{
            get{return cvv;}
            set{cvv = value;}
        }


        //Metodos
        public string SalvarCartao(){
            return "";
        }


    }//Cartao
}