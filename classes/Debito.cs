using System;

namespace POO_Abstracao.classes
{
    public class Debito : Cartao
    {
        //Atributos
        private float saldo = 600;
        public float Saldo{
            get{return saldo;}
        }


        //Metodos
        public void Pagar(float valor){
            
        }

        //Obrigatorio inserir
        public override string Desconto(float valor)
        {
            return "O desconto no debito é de 6%";
        }

        public void Registrar()
        {
            Console.WriteLine($"Valor com desconto: {Valor * 0.94f}");
            Console.WriteLine($"O produto foi pago {DataDePagamento}");
        }


    }//Debito
}