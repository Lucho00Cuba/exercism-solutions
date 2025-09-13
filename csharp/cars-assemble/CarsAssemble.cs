static class AssemblyLine {
    public static double SuccessRate(int speed) {
        if (speed == 0) {
            return 0.0;
        }
        if (speed is >= 1 and <= 4) {
            return 1.0;
        }
        if (speed is >= 5 and <= 8) {
            return 0.9;
        }
        if (speed == 9) {
            return 0.8;
        }
        return speed == 10 ? 0.77 : 0.0;
    }

    public static double ProductionRatePerHour(int speed) => speed * 221.0 * SuccessRate(speed);

    public static int WorkingItemsPerMinute(int speed) {
        var itemsPerMinute = ProductionRatePerHour(speed) / 60.0;
        return (int)itemsPerMinute;
    }
}
