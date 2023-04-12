using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC
{
    internal class Pessoa
    {
        public double peso;
        public double altura;

        public double calculaIMC()
        {
            return peso / (altura * altura);
        }
        public string situacao(double valorIMC)
        {
            string retorno;

            if (valorIMC < 18.5)
            {
                retorno = "Abaixo do peso";
            }
            else if (valorIMC < 25)
            {
                retorno = "Peso normal";
            }
            else if (valorIMC < 30)
            {
                retorno = "Acima do peso";
            }
            else if (valorIMC < 35)
            {
                retorno = "Obesidade 1";
            }
            else if (valorIMC < 40)
            {
                retorno = "Obesidade 2";
            }
            else
            {
                retorno = "Obesidade 3";
            }
            return retorno;
        }
        public void mensagem()
        {
            double obterCalculo = calculaIMC();
            string obterSituacao = situacao(obterCalculo);
            Console.WriteLine($"Seu peso é {obterCalculo} e está {obterSituacao}");
            Console.ReadLine();
        }

    }   

}
