namespace resouceCollector
{
    internal class Iron
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

        public double ironToRocket;
        public double ironNeeded;

        public Iron(double perClick, double perSecond, double count, double perClickUpgradeCost,
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
            ironToRocket = 0;
            ironNeeded = 1000000000;
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
                PerSecond += 15;
                PerSecondUpgrade1Cost *= 1.25;
                PerSecondUpgrade1Count++;
            }
        }

        public void IncreasePerSecond2()
        {
            if (Count >= PerSecondUpgrade2Cost)
            {
                Count -= PerSecondUpgrade2Cost;
                PerSecond += 30;
                PerSecondUpgrade2Cost *= 1.50;
                PerSecondUpgrade2Count++;
            }
        }

        public void IncreasePerSecond3()
        {
            if (Count >= PerSecondUpgrade3Cost)
            {
                Count -= PerSecondUpgrade3Cost;
                PerSecond += 45;
                PerSecondUpgrade3Cost *= 1.75;
                PerSecondUpgrade3Count++;
            }
        }
        public void ContributeToRocket()
        {
            if (Count >= ironNeeded)
            {
                ironToRocket += ironNeeded;
                Count -= ironNeeded;
                ironNeeded = 0;
            }
            else
            {
                ironToRocket += Count;
                ironNeeded -= Count;
                Count = 0;
            }
        }
    }
}

