namespace POO_Abstracao.classes
{
    public class Credito : Cartao
    {
        //Atributos
        private float limite;
        public float Limite{
            get{return limite;}
            set{limite = value;}
        }


        //Metodos
        public void Pagar(float valor){

        }

        //Obrigatorio inserir esta classe
        public override string Desconto(int valor)
        {
            return "";
        }



    }//Credito
}