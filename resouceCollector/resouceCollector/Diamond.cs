namespace resouceCollector
{
    internal class Diamond
    {

        public double PerClick { get; set; }
        public double PerSecond { get; set; }
        public double Count { get; set; }
        public double PerClickUpgradeCost { get; set; }
        public double PerSecondUpgrade1Cost { get; set; }
        public double PerSecondUpgrade2Cost { get; set; }
        public double PerSecondUpgrade3Cost { get; set; }
        public int PerSecondUpgrade1Count { get; set; }
        public int PerSecondUpgrade2Count { get; set; }
        public int PerSecondUpgrade3Count { get; set; }
        public int PerClickUpgradeCount { get; set; }

        public double diamondToRocket;
        public double diamondNeeded;

        public Diamond(double perClick, double perSecond, double count, double perClickUpgradeCost,
            double perSecondUpgrade1Cost, double perSecondUpgrade2Cost, double perSecondUpgrade3Cost)
        {
            PerClick = perClick;
            PerSecond = perSecond;
            Count = count;
            PerClickUpgradeCost = perClickUpgradeCost;
            PerSecondUpgrade1Cost = perSecondUpgrade1Cost;
            PerSecondUpgrade2Cost = perSecondUpgrade2Cost;
            PerSecondUpgrade3Cost = perSecondUpgrade3Cost;
            PerSecondUpgrade1Count = 0;
            PerSecondUpgrade2Count = 0;
            PerSecondUpgrade3Count = 0;
            PerClickUpgradeCount = 0;
            diamondToRocket = 0;
            diamondNeeded = 100000;
        }

        public void IncreasePerClick()
        {
            if (Count >= PerClickUpgradeCost)
            {
                Count -= PerClickUpgradeCost;
                PerClick *= 2;
                PerClickUpgradeCost *= 2;
                PerClickUpgradeCount++;
            }
        }

        public void IncreasePerSecond1()
        {
            if (Count >= PerSecondUpgrade1Cost)
            {
                Count -= PerSecondUpgrade1Cost;
                PerSecond += 1;
                PerSecondUpgrade1Cost *= 2;
                PerSecondUpgrade1Count++;
            }
        }

        public void IncreasePerSecond2()
        {
            if (Count >= PerSecondUpgrade2Cost)
            {
                Count -= PerSecondUpgrade2Cost;
                PerSecond += 2;
                PerSecondUpgrade2Cost *= 2.25;
                PerSecondUpgrade2Count++;
            }
        }

        public void IncreasePerSecond3()
        {
            if (Count >= PerSecondUpgrade3Cost)
            {
                Count -= PerSecondUpgrade3Cost;
                PerSecond += 3;
                PerSecondUpgrade3Cost *= 2.5;
                PerSecondUpgrade3Count++;
            }
        }
        public void ContributeToRocket()
        {
            if (Count >= diamondNeeded)
            {
                diamondToRocket += diamondNeeded;
                Count -= diamondNeeded;
                diamondNeeded = 0;
            }
            else
            {
                diamondToRocket += Count;
                diamondNeeded -= Count;
                Count = 0;
            }
        }
    }
}
