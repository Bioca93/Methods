namespace MethodsEx
{
    public class Calculadora
    {
        public double Resultado { get; set; }

        public static double ResultadoEstatico { get; set; }

        public double Calcular(double x, double y, Operacao operacao)
        {
            double resultado = 0;

            switch (operacao)
            {
                case Operacao.Soma:
                    resultado = x + y;
                    break;
                case Operacao.Subtracao:
                    resultado = x - y;
                    break;
                case Operacao.Multiplicacao:
                    resultado = x * y;
                    break;
                case Operacao.Divisao:
                    resultado = x / y;
                    break;
            }

            this.Resultado = resultado;

            return resultado;
        }

        public double Calcular(double x, double y, double z, Operacao operacao)
        {
            double resultado = 0;

            switch (operacao)
            {
                case Operacao.Soma:
                    resultado = x + y + z;
                    break;
                case Operacao.Subtracao:
                    resultado = x - y - z;
                    break;
                case Operacao.Multiplicacao:
                    resultado = x * y * z;
                    break;
                case Operacao.Divisao:
                    resultado = x / y / z;
                    break;
            }

            this.Resultado = resultado;

            return resultado;
        }

        public static void CalcularEstatico()
        {

        }
    }
}
