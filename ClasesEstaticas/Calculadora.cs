namespace Operaciones
{
    public static class Calculadora
    {
        public static int Suma(int numero1, int numero2)
        {
            int resultado = numero1 + numero2;
            return resultado;
        }

        public static int Resta(int numero1, int numero2)
        {
            int resultado = numero1 - numero2;
            return resultado;
        }

        public static int Multiplicacion(int numero1, int numero2)
        {
            int resultado = numero1 * numero2;
            return resultado;
        }

        public static int Division(int numero1, int numero2)
        {
            if(numero2 == 0)            
                throw new DivideByZeroException("No se puede dividir entre cero");
            
            int resultado = numero1/numero2;
            return resultado;
            
        }

        public static int Division11(int numero1, int numero2)
        {
            if(numero2 == 0)            
                throw new DivideByZeroException("No se puede dividir entre cero");
            
            int resultado = numero1/numero2;
            return resultado;
            
        }
        private static string ResultadoOperacion(int resultado)
        {
            return $"El resultado de la operacion es: {resultado}";
        }

    }

}