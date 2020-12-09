namespace POO_Abstracao.classes
{
    public class Boleto : Pagamento
    {
        //Atributos
        public string codigoDeBarras;


        //Metodos
        public void Registrar(){

        }

        public void Pagar(float valor){

        }

        //Obrigatorio inserir esta classe
        public override string Desconto(int valor)
        {
            return "";
        }


    }//Boleto
}