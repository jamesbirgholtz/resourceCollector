using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resouceCollector
{
    internal class UpgradeTree
    {
        public int ClickUpgradeDecreaseCounter { get; set; }
        public int FirstUpgradeDecreaseCoutner { get; set; }
        public int SecondUpgradeDecreaseCoutner { get; set; }
        public int ThirdUpgradeDecreaseCoutner { get; set; }
        public int FourthUpgradeDecreaseCoutner { get; set; }
        public int UpgradeTokens { get; set; }


        public UpgradeTree
            (int clickUpgradeDecreaseCounter, int firstUpgradeDecreaseCoutner,
            int secondUpgradeDecreaseCoutner, int thirdUpgradeDecreaseCoutner, 
            int fourthUpgradeDecreaseCoutner, int upgradeTokens)
        
        {
            
            ClickUpgradeDecreaseCounter = clickUpgradeDecreaseCounter;
            FirstUpgradeDecreaseCoutner = firstUpgradeDecreaseCoutner;
            SecondUpgradeDecreaseCoutner = secondUpgradeDecreaseCoutner;
            ThirdUpgradeDecreaseCoutner = thirdUpgradeDecreaseCoutner;
            FourthUpgradeDecreaseCoutner = fourthUpgradeDecreaseCoutner;
            UpgradeTokens = upgradeTokens;

        }

        public void ClickCostDecrease() {
            if (ClickUpgradeDecreaseCounter == 0 && UpgradeTokens >= 1) { 
                UpgradeTokens -= 1;
                ClickUpgradeDecreaseCounter++;
            }
            else if (ClickUpgradeDecreaseCounter == 1 && UpgradeTokens >= 2) { 
                UpgradeTokens -= 2;
                ClickUpgradeDecreaseCounter++;
            }
            else if (ClickUpgradeDecreaseCounter == 2 && UpgradeTokens >= 3)
            {
                UpgradeTokens -= 3;
                ClickUpgradeDecreaseCounter++;
            }
            else if (ClickUpgradeDecreaseCounter == 3 && UpgradeTokens >= 4)
            {
                UpgradeTokens -= 4;
                ClickUpgradeDecreaseCounter++;
            }
        }


    }
}
