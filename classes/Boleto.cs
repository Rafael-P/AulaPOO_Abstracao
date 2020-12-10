using System;

namespace POO_Abstracao.classes
{
    public class Boleto : Pagamento
    {
        //Atributos
        private string codigoDeBarras;
        public string CodigoDeBarras{
            get{return codigoDeBarras;}
            set{codigoDeBarras = value;}
        }

        //Metodos
        public void Registrar(){
            Console.WriteLine($"Valor com desconto: {Valor * 0.88f}");
            Console.WriteLine($"O boleto foi pago {DataDePagamento}");
        }

        public void Pagar(float valor){

        }

        //Obrigatorio inserir esta classe
        public override string Desconto(float valor)
        {
            return "O desconto será de 12%";
        }


    }//Boleto
}