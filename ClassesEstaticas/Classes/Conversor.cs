namespace ClassesEstaticas.Classes
{
    public static class Conversor
    {
        private static float CotacaoDolar = 5.22f;

        public static float RealParaDolar(float ValorRS) {
            return ValorRS/CotacaoDolar;
        }

        public static float DolarParaReal(float ValorUS) {
            return ValorUS * CotacaoDolar;
        }
    }
}