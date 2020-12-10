using System;

namespace POO_Abstracao.classes
{
    abstract public class Pagamento
    {
        //Atributos
        private DateTime dataDePagamento = DateTime.Now;
        public DateTime DataDePagamento{
            get{return DateTime.Now;}
        }

        protected float valor;
        public float Valor{
            get{return valor;}
            set{valor = value;}
        }


        //Metodos
        public string Cancelar(){
            return "";
        }

        //Quando um metodo é abstract ele obrigatoriamente tem que ser inserido manualmente nas subclasses
        public abstract string Desconto(float valor);


    }//Pagamento
}