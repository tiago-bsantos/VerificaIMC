using System;

namespace VerificaIMC.Model
{
    public class IMC
    {
        public string Data { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public double ValorIMC { get; set; }
        public string Resultado { get; set; }

        public IMC( string data, double peso, double altura)
        {
            this.Data = data;
            this.Peso = peso;
            this.Altura = altura;
            this.ValorIMC = CalculaIMC(Peso, Altura);
            this.Resultado = VerificaResultado(ValorIMC);
        }

        public double CalculaIMC(double peso, double altura)
        {
            return Math.Round(peso / (altura * altura), 2);
        }

        public string VerificaResultado(double valorIMC)
        {
            string result = "";
            if (valorIMC < 17)
            {
                result = "Muito abaixo do peso";
            }
            else if ( (valorIMC >= 17) && (valorIMC <= 18.49))
            {
                result = "Abaixo do peso";
            }
            else if ((valorIMC >= 18.5) && (valorIMC <= 24.99))
            {
                result = "Peso normal";
            }
            else if ((valorIMC >= 25) && (valorIMC <= 29.99))
            {
                result = "Acima do peso";
            }
            else if ((valorIMC >= 30) && (valorIMC <= 34.99))
            {
                result = "Obesidade I";
            }
            else if ((valorIMC >= 35) && (valorIMC <= 39.99))
            {
                result = "Obesidade II (severa)";
            }
            else
            {
                result = "Obesidade III (mórbida)";
            }
            return result;
        }
    }
}
