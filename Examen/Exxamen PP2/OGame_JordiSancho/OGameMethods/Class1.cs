namespace OGameMethods
{
    public class ExtractionLine
    {
        public static double SuccessRate(double level)
        {
            switch (level)
            {
                case 0:
                    return 0;
                case 1:
                case 2:
                case 3:
                case 4:
                    return 1;
                case 5:
                case 6:
                case 7:
                case 8:
                    return 0.9;
                case 9:
                    return 0.8;
                case 10:
                    return 0.77;
                default:
                    return 0;
            }
        }

        public static double ProductionRatePerHour(double level)
        {
            return SuccessRate(level) * 221 * level;
        }

        public static double WorkingItemsPerMinute(double level)
        {
            return ProductionRatePerHour(level) / 60;
        }
    }
}
