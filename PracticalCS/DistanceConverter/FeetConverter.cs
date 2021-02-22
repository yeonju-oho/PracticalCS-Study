namespace DistanceConverter
{
    public static class FeetConverter
    {
        private const double RATIO = 0.3048;    //공개할 필요가 있을 경우 public static readonly를 사용한다.

        public static double ToMeter(double feet)
        {
            if (feet == 0) return 0;
            else return feet * RATIO;
        }
        public static double FromMeter(double meter)
        {
            if (meter == 0) return 0;
            else return meter / RATIO;
        }
    }
}
