namespace POO_Abstracao.classes
{
    abstract public class Cartao : Pagamento
    {
        //Atributos
        private string bandeira;
        private string numero;
        private string titular;
        private string cvv;


        //Metodos
        public string SalvarCartao(){
            return "";
        }


    }//Cartao
}