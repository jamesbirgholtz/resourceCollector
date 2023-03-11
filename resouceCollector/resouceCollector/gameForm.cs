using System;
using System.Windows.Forms;

namespace resouceCollector
{
    public partial class gameForm : Form
    {
        private void gameForm_Load(object sender, EventArgs e)
        {

        }

        private readonly Iron iron;
        private readonly Gold gold;
        private readonly Titanium titanium;
        private readonly Diamond diamond;



        public gameForm()
        {
            InitializeComponent();
            iron = new Iron(1000, 0, 0, 100, 150, 300, 600);
            gold = new Gold(1000, 0, 0, 200, 300, 600, 900);
            titanium = new Titanium(1000, 0, 0, 400, 600, 1200, 1800);
            diamond = new Diamond(1000, 0, 0, 800, 1200, 2400, 3600);

            UpdateText();
            perSecondResource.Start();
            textUpdater.Start();
        }


        private void rocketProgressTracker()
        {
            if (rocketProgressBar.Value < 100)
            {
                double rocketResourcesNeeded = iron.ironNeeded + gold.goldNeeded + titanium.titaniumNeeded + diamond.diamondNeeded;
                double rocketReasourcesCollected = iron.ironToRocket + gold.goldToRocket + titanium.titaniumToRocket + diamond.diamondToRocket;
                double rocketProgress = rocketReasourcesCollected / rocketResourcesNeeded * 100;
                rocketProgressBar.Value = Math.Min((int)rocketProgress, 100);
            }
            else {
                ironToRocket.Enabled = false;
                goldToRocket.Enabled = false;
                titaniumToRocket.Enabled = false;
                diamondToRocket.Enabled = false;
            }
        }

        //timer
        private void textUpdater_Tick(object sender, EventArgs e)
        {
            UpdateText();
            rocketProgressTracker();
        }

        private void hideSubMenu() {
            if (minerUpgrades.Visible == true) { 
                minerUpgrades.Visible = false;
            }
            if (drillUpgrades.Visible == true) { 
                drillUpgrades.Visible=false;
            }
            if (excavatorUpgrades.Visible == true) {
                excavatorUpgrades.Visible = false;
            }
        
        }



        private void showSubMenu(Panel subMenu) {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else { 
                subMenu.Visible = false;
            }
        }




        //update textboxes
        private void UpdateText()
        {
            ironTextBox.Text = "Iron: " + iron.Count.ToString("F0") + Environment.NewLine + "Iron Per Second: " + iron.PerSecond.ToString("F0");
            ironPerClickUpgrade.Text = "Iron Per Click x2 \nCost: " + iron.PerClickUpgradeCost.ToString("F0");
            ironPerSecondUpgrade1.Text = "Iron Miner\n Increases iron by " + iron.perSecond1 + " per second\n\n Cost: " + iron.PerSecondUpgrade1Cost.ToString("F0") + " iron";
            ironPerSecondUpgrade2.Text = "Iron Drill\n Increases iron by " + iron.perSecond2 + " per second\n\n Cost: " + iron.PerSecondUpgrade2Cost.ToString("F0") + " iron";
            ironPerSecondUpgrade3.Text = "Iron Escavator\n Increases iron by " + iron.perSecond3 + " per second\n\n Cost: " + iron.PerSecondUpgrade3Cost.ToString("F0") + " iron";


            goldTextBox.Text = "Gold: " + gold.Count.ToString("F0") + Environment.NewLine + "Gold Per Second: " + gold.PerSecond.ToString("F0");
            goldPerClickUpgrade.Text = "Gold Per Click x2 \nCost: " + gold.PerClickUpgradeCost.ToString("F0");
            goldPerSecondUpgrade1.Text = "Gold Miner\n Increases gold by " + gold.perSecond1 + " per second\n\n Cost: " + gold.PerSecondUpgrade1Cost.ToString("F0") + " gold";
            goldPerSecondUpgrade2.Text = "Gold Drill\n Increases gold by " + gold.perSecond2 + " per second\n\n Cost: " + gold.PerSecondUpgrade2Cost.ToString("F0") + " gold";
            goldPerSecondUpgrade3.Text = "Gold Escavator\n Increases gold by " + gold.perSecond3 + " per second\n\n Cost: " + gold.PerSecondUpgrade3Cost.ToString("F0") + " gold";

            titaniumTextBox.Text = "Titanium: " + titanium.Count.ToString("F0") + Environment.NewLine + "Titanium Per Second: " + titanium.PerSecond.ToString("F0");
            titaniumPerClickUpgrade.Text = "Titanium Per Click x2 \nCost: " + titanium.PerClickUpgradeCost.ToString("F0");
            titaniumPerSecondUpgrade1.Text = "Titanium Miner\n Increases titanium by " + titanium.perSecond1 + " per second\n\n Cost: " + titanium.PerSecondUpgrade1Cost.ToString("F0") + " titanium";
            titaniumPerSecondUpgrade2.Text = "Titanium Drill\n Increases titanium by " + titanium.perSecond2 + " per second\n\n Cost: " + titanium.PerSecondUpgrade2Cost.ToString("F0") + " titanium";
            titaniumPerSecondUpgrade3.Text = "Titanium Escavator\n Increases titanium by " + titanium.perSecond3 + " per second\n\n Cost: " + titanium.PerSecondUpgrade3Cost.ToString("F0") + " titanium";

            diamondTextBox.Text = "Diamond: " + diamond.Count.ToString("F0") + Environment.NewLine + "Diamond Per Second: " + diamond.PerSecond.ToString("F0");
            diamondPerClickUpgrade.Text = "Diamond Per Click x2 \nCost: " + diamond.PerClickUpgradeCost.ToString("F0");
            diamondPerSecondUpgrade1.Text = "Diamond Miner\n Increases diamond by " + diamond.perSecond1 + " per second\n\n Cost: " + diamond.PerSecondUpgrade1Cost.ToString("F0") + " diamond";
            diamondPerSecondUpgrade2.Text = "Diamond Drill\n Increases diamond by " + diamond.perSecond2 + " per second\n\n Cost: " + diamond.PerSecondUpgrade2Cost.ToString("F0") + " diamond";
            diamondPerSecondUpgrade3.Text = "Diamond Escavator\n Increases diamond by " + diamond.perSecond3 + " per second\n\n Cost: " + diamond.PerSecondUpgrade3Cost.ToString("F0") + " diamond";

            ironToRocket.Text = "send iron to rocket\n" + iron.ironToRocket.ToString("F0") + " total sent\n" + iron.ironNeeded.ToString("F0") + " needed!";
            goldToRocket.Text = "send gold to rocket\n" + gold.goldToRocket.ToString("F0") + " total sent\n" + gold.goldNeeded.ToString("F0") + " needed!";
            titaniumToRocket.Text = "send titanium to rocket\n" + titanium.titaniumToRocket.ToString("F0") + " total sent\n" + titanium.titaniumNeeded.ToString("F0") + " needed!";
            diamondToRocket.Text = "send diamond to rocket\n" + diamond.diamondToRocket.ToString("F0") + " total sent\n" + diamond.diamondNeeded.ToString("F0") + " needed!";

            ironMinerUpgrade.Text = "iron miner + "+ iron.increasePerSecond1UpgradeCount.ToString() + "\nCosts: " + iron.perSecond1UpgradeCost.ToString("F0") + " iron";
            goldMinerUpgrade.Text = "gold miner + " + gold.increasePerSecond1UpgradeCount.ToString() + "\nCosts: " + gold.perSecond1UpgradeCost.ToString("F0") + " gold";
            titaniumMinerUpgrade.Text = "titanium miner + " + titanium.increasePerSecond1UpgradeCount.ToString() + "\nCosts: " + titanium.perSecond1UpgradeCost.ToString("F0") + " titanium";
            diamondMinerUpgrade.Text = "diamond miner + " + diamond.increasePerSecond1UpgradeCount.ToString() + "\nCosts: " + diamond.perSecond1UpgradeCost.ToString("F0") + " diamond";

            ironDrillUpgrade.Text = "iron drill + " + iron.increasePerSecond2UpgradeCount.ToString() + "\nCosts: " + iron.perSecond2UpgradeCost.ToString("F0") + " iron";
            goldDrillUpgrade.Text = "gold drill + " + gold.increasePerSecond2UpgradeCount.ToString() + "\nCosts: " + gold.perSecond2UpgradeCost.ToString("F0") + " gold";
            diamondDrillUpgrade.Text = "diamond drill + " + diamond.increasePerSecond2UpgradeCount.ToString() + "\nCosts: " + diamond.perSecond2UpgradeCost.ToString("F0") + " diamond";
            titaniumDrillUpgrade.Text = "titanium drill + " + titanium.increasePerSecond2UpgradeCount.ToString() + "\nCosts: " + titanium.perSecond2UpgradeCost.ToString("F0") + " titanium";

            ironEscUpgrade.Text = "iron esc + " + iron.increasePerSecond3UpgradeCount.ToString() + "\nCosts: " + iron.perSecond3UpgradeCost.ToString("F0") + " iron";
            goldEscUpgrade.Text = "gold esc + " + gold.increasePerSecond3UpgradeCount.ToString() + "\nCosts: " + gold.perSecond3UpgradeCost.ToString("F0") + " gold";
            titaniumEscUpgrade.Text = "titanium esc + " + titanium.increasePerSecond3UpgradeCount.ToString() + "\nCosts: " + titanium.perSecond3UpgradeCost.ToString("F0") + " titanium";
            diamondEscUpgrade.Text = "diamond esc + " + diamond.increasePerSecond3UpgradeCount.ToString() + "\nCosts: " + diamond.perSecond3UpgradeCost.ToString("F0") + " diamond";


        }

        // main button
        private void resourceButton_Click(object sender, EventArgs e)
        {
            iron.Count += iron.PerClick;
            gold.Count += gold.PerClick;
            titanium.Count += titanium.PerClick;
            diamond.Count += diamond.PerClick;

            UpdateText();

        }


        // per click upgrades
        private void ironPerClickUpgrade_Click(object sender, EventArgs e)
        {
            iron.IncreasePerClick();
        }

        private void goldPerClickUpgrade_Click(object sender, EventArgs e)
        {
            gold.IncreasePerClick();

        }

        private void titaniumPerClickUpgrade_Click(object sender, EventArgs e)
        {
            titanium.IncreasePerClick();
        }

        private void diamondPerClickUpgrade_Click(object sender, EventArgs e)
        {
            diamond.IncreasePerClick();
        }


        // per second upgrades
        private void perSecondResource_Tick(object sender, EventArgs e)
        {
            iron.Count += iron.PerSecond;
            gold.Count += gold.PerSecond;
            titanium.Count += titanium.PerSecond;
            diamond.Count += diamond.PerSecond;
        }
        //iron
        private void ironPerSecondUpgrade1_Click(object sender, EventArgs e)
        {
            iron.IncreasePerSecond1();
        }
        private void ironPerSecondUpgrade2_Click(object sender, EventArgs e)
        {
            iron.IncreasePerSecond2();
        }

        private void ironPerSecondUpgrade3_Click(object sender, EventArgs e)
        {
            iron.IncreasePerSecond3();
        }

        //gold
        private void goldPerSecondUpgrade1_Click(object sender, EventArgs e)
        {
            gold.IncreasePerSecond1();
        }
        private void goldPerSecondUpgrade2_Click(object sender, EventArgs e)
        {
            gold.IncreasePerSecond2();
        }

        private void goldPerSecondUpgrade3_Click(object sender, EventArgs e)
        {
            gold.IncreasePerSecond3();
        }
        // titanium
        private void titaniumPerSecondUpgrade1_Click(object sender, EventArgs e)
        {
            titanium.IncreasePerSecond1();
        }

        private void titaniumPerSecondUpgrade2_Click(object sender, EventArgs e)
        {
            titanium.IncreasePerSecond2();
        }

        private void titaniumPerSecondUpgrade3_Click(object sender, EventArgs e)
        {
            titanium.IncreasePerSecond3();
        }
        //diamond
        private void diamondPerSecondUpgrade1_Click(object sender, EventArgs e)
        {
            diamond.IncreasePerSecond1();
        }

        private void diamondPerSecondUpgrade2_Click(object sender, EventArgs e)
        {
            diamond.IncreasePerSecond2();
        }

        private void diamondPerSecondUpgrade3_Click(object sender, EventArgs e)
        {
            diamond.IncreasePerSecond3();
        }

        private void ironTextBox_TextChanged(object sender, EventArgs e)
        {
            ironTextBox.Multiline = true;
        }


        //send resources to the rocket
        private void titaniumToRocket_Click(object sender, EventArgs e)
        {
            titanium.ContributeToRocket();
        }

        private void ironToRocket_Click(object sender, EventArgs e)
        {
            iron.ContributeToRocket();
        }

        private void goldToRocket_Click(object sender, EventArgs e)
        {
            gold.ContributeToRocket();
        }

        private void diamondToRocket_Click(object sender, EventArgs e)
        {
            diamond.ContributeToRocket();
        }

        private void rocketProgressBar_Click(object sender, EventArgs e)
        {

        }

        private void showMinerUpgrades_Click(object sender, EventArgs e)
        {
            showSubMenu(minerUpgrades);
        }

        private void ironMinerUpgrade_Click(object sender, EventArgs e)
        {
            iron.IncreasePerSecond1Upgrade();
        }

        private void goldMinerUpgrade_Click(object sender, EventArgs e)
        {
            gold.IncreasePerSecond1Upgrade();
        }

        private void titaniumMinerUpgrade_Click(object sender, EventArgs e)
        {
            titanium.IncreasePerSecond1Upgrade();
        }

        private void diamondMinerUpgrade_Click(object sender, EventArgs e)
        {
            diamond.IncreasePerSecond1Upgrade();
        }

        private void showDrillUpgrades_Click(object sender, EventArgs e)
        {
            showSubMenu(drillUpgrades);
        }

        private void showEscUpgrades_Click(object sender, EventArgs e)
        {
            showSubMenu(excavatorUpgrades);
        }

        private void ironDrillUpgrade_Click(object sender, EventArgs e)
        {
            iron.IncreasePerSecond2Upgrade();
        }

        private void goldDrillUpgrade_Click(object sender, EventArgs e)
        {
            gold.IncreasePerSecond2Upgrade();
        }

        private void titaniumDrillUpgrade_Click(object sender, EventArgs e)
        {
            titanium.IncreasePerSecond2Upgrade();
        }

        private void diamondDrillUpgrade_Click(object sender, EventArgs e)
        {
            diamond.IncreasePerSecond2Upgrade();
        }

        private void ironEscUpgrade_Click(object sender, EventArgs e)
        {
            iron.IncreasePerSecond3Upgrade();
        }

        private void goldEscUpgrade_Click(object sender, EventArgs e)
        {
            gold.IncreasePerSecond3Upgrade() ;
        }

        private void titaniumEscUpgrade_Click(object sender, EventArgs e)
        {
            titanium.IncreasePerSecond3Upgrade();
        }

        private void diamondEscUpgrade_Click(object sender, EventArgs e)
        {
            diamond.IncreasePerSecond3Upgrade();
        }
    }
}
