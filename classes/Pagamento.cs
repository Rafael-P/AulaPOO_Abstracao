using System;

namespace POO_Abstracao.classes
{
    abstract public class Pagamento
    {
        //Atributos
        private DateTime data;
        protected float valor;


        //Metodos
        public string Cancelar(){
            return "";
        }

        //Quando um metodo é abstract ele obrigatoriamente tem que ser inserido manualmente nas subclasses
        public abstract string Desconto(int valor);


    }//Pagamento
}