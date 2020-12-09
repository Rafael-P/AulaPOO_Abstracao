namespace POO_Abstracao.classes
{
    public class Debito : Cartao
    {
        //Atributos
        private float saldo = 600;


        //Metodos
        public void Pagar(float valor){
            
        }

        //Obrigatorio inserir
        public override string Desconto(int valor)
        {
            throw new System.NotImplementedException();
        }



    }//Debito
}