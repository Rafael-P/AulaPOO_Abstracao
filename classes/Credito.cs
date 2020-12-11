using System;

namespace POO_Abstracao.classes
{
    public class Credito : Cartao
    {
        //Atributos
        private float limite = 1000;
        public float Limite{
            get{return limite;}
        }

        public int parcelas;


        //Metodos
        public void Pagar(float valor){
            if (valor > limite)
            {
                Console.WriteLine("Limite exedido");
            }
            if (parcelas > 12)
            {
                Console.WriteLine("Limite de parcelas exedido");
            }
            if (parcelas >= 1 && parcelas <= 6)
            {
                valor = valor + (valor * 0.05f);
            }
            else if (parcelas >= 7 && parcelas <= 12)
            {
                valor = valor + (valor * 0.08f);
            }
            Console.WriteLine($"O valor final é de {valor}");
            Console.WriteLine($"O seu limite atual é de: {limite - valor}");
        }

        //Obrigatorio inserir esta classe
        public override string Desconto(float valor)
        {
            return "";
        }


    }//Credito
}