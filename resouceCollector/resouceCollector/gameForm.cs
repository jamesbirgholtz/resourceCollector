using resourceCollector;
using System;
using System.Windows.Forms;

namespace resouceCollector
{
    public partial class gameForm : Form
    {
        private void gameForm_Load(object sender, EventArgs e)
        {

        }

        private readonly Resource1 resource1;
        private readonly Resource2 resource2;
        private readonly Resource3 resource3;
        private readonly Resource4 resource4;
        private readonly UpgradeTree upgradeTree;
        private int worldCounter = 0;

        public gameForm()
        {
            InitializeComponent();
            resource1 = new Resource1(100000000, 0, 0, 100, 150, 300, 600);
            resource2 = new Resource2(100000000, 0, 0, 200, 300, 600, 900);
            resource3 = new Resource3(100000000, 0, 0, 400, 600, 1200, 1800);
            resource4 = new Resource4(100000000, 0, 0, 800, 1200, 2400, 3600);
            upgradeTree = new UpgradeTree(0, 0, 0, 0, 0, 0);


            UpdateText();
            perSecondResource.Start();
            textUpdater.Start();
        }

        // keeps track of the resources needed to build the rocket and then sends it to the progress bar
        private void rocketProgressTracker()
        {
            //total to the resources needed
            double rocketResourcesNeeded = resource1.resource1Needed + resource2.resource2Needed + resource3.resource3Needed + resource4.resource4Needed;
            //total of the resources collected
            double rocketResourcesCollected = resource1.resource1ToRocket + resource2.resource2ToRocket + resource3.resource3ToRocket + resource4.resource4ToRocket;
            //creates a percentage of the resources needed so the progress bar van take the value
            double rocketProgress = rocketResourcesCollected / rocketResourcesNeeded * 100;
            rocketProgressBar.Value = (int)rocketProgress;
            
            //once the progress bar is 100 turn off the buttons and show the launch button
            if (rocketProgressBar.Value == 100)
            {
                resource1ToRocket.Enabled = false;
                resource2ToRocket.Enabled = false;
                resource3ToRocket.Enabled = false;
                resource4ToRocket.Enabled = false;
                resourceButton.Enabled = false;
                launchButton.Visible = true;
                launchButton.Enabled = true;
            }
        }
        // check to see if the button should be enabled/ visable
        private void ButtonEnable() {
            if (worldCounter != 0) { 
                tokenUpgrades.Enabled = true;
                tokenUpgrades.Visible = true;
            }

            if (upgradeTree.UpgradeTokens == 0)
            {
                tokenUpgradesMenu.Enabled = false;
            }
            else {
                tokenUpgradesMenu.Enabled= true;
            }


        }
        //method to call when the launch button is clicked, resetting the values to the default
        private void NewWorld() {
                resource1._perSecond = 0;
                resource1._count = 0;
                resource1._perClick = 1000000000;
                resource1._perSecondUpgrade1Count = 0;
                resource1._perSecondUpgrade2Count = 0;
                resource1._perSecondUpgrade3Count = 0;
                resource1._perClickUpgradeCount = 0;
                resource1.resource1ToRocket = 0;
                resource1.resource1Needed = 1000000000;
                resource1.increaseResourceperSecond1 = 15;
                resource1.increaseResourcePerSecond2 = 30;
                resource1.increaseResourcePerSecond3 = 45;
                resource1.increasePerSecond1UpgradeCost = 200;
                resource1.increasePerSecond2UpgradeCost = 400;
                resource1.increasePerSecond3UpgradeCost = 650;
                resource1.increasePerSecond1UpgradeCount = 0;
                resource1.increasePerSecond2UpgradeCount = 0;
                resource1.increasePerSecond3UpgradeCount = 0;

                resource2.PerClick = 10000000000;
                resource2.PerSecond = 0;
                resource2.Count = 0;
                resource2.PerSecondUpgrade1Count = 0;
                resource2.PerSecondUpgrade2Count = 0;
                resource2.PerSecondUpgrade3Count = 0;
                resource2.PerClickUpgradeCount = 0;
                resource2.resource2ToRocket = 0;
                resource2.resource2Needed = 500000000;
                resource2.perSecond1 = 5;
                resource2.perSecond2 = 10;
                resource2.perSecond3 = 15;
                resource2.perSecond1UpgradeCost = 350;
                resource2.perSecond2UpgradeCost = 650;
                resource2.perSecond3UpgradeCost = 950;
                resource2.increasePerSecond1UpgradeCount = 0;
                resource2.increasePerSecond2UpgradeCount = 0;
                resource2.increasePerSecond3UpgradeCount = 0;

                resource3.PerSecond = 0;
                resource3.PerClick = 10000000000;
                resource3.Count = 0;
                resource3.PerSecondUpgrade1Count = 0;
                resource3.PerSecondUpgrade2Count = 0;
                resource3.PerSecondUpgrade3Count = 0;
                resource3.PerClickUpgradeCount = 0;
                resource3.resource3ToRocket = 0;
                resource3.resource3Needed = 1000000;
                resource3.perSecond1 = 3;
                resource3.perSecond2 = 6;
                resource3.perSecond3 = 9;
                resource3.perSecond1UpgradeCost = 650;
                resource3.perSecond2UpgradeCost = 1250;
                resource3.perSecond3UpgradeCost = 1850;
                resource3.increasePerSecond1UpgradeCount = 0;
                resource3.increasePerSecond2UpgradeCount = 0;
                resource3.increasePerSecond3UpgradeCount = 0;

                resource4.PerSecond = 0;
                resource4.PerClick = 1000000000000;
                resource4.Count = 0;
                resource4.PerSecondUpgrade1Count = 0;
                resource4.PerSecondUpgrade2Count = 0;
                resource4.PerSecondUpgrade3Count = 0;
                resource4.PerClickUpgradeCount = 0;
                resource4.resource4ToRocket = 0;
                resource4.resource4Needed = 100000;
                resource4.perSecond1 = 1;
                resource4.perSecond2 = 2;
                resource4.perSecond3 = 3;
                resource4.perSecond1UpgradeCost = 1250;
                resource4.perSecond2UpgradeCost = 2450;
                resource4.perSecond3UpgradeCost = 3650;
                resource4.increasePerSecond1UpgradeCount = 0;
                resource4.increasePerSecond2UpgradeCount = 0;
                resource4.increasePerSecond3UpgradeCount = 0;
            
        }

        //timer to keep updating everything to make sure the correct text is on the screen
        private void textUpdater_Tick(object sender, EventArgs e)
        {
            UpdateText();
            rocketProgressTracker();
            ButtonEnable();
        }
        //timer that keeps track of the resources per second
        private void perSecondResource_Tick(object sender, EventArgs e)
        {
            resource1._count += resource1._perSecond;
            resource2.Count += resource2.PerSecond;
            resource3.Count += resource3.PerSecond;
            resource4.Count += resource4.PerSecond;
        }
        //method to hide the upgrade trees
        private void hideSubMenu()
        {
            if (minerUpgrades.Visible == true)
            {
                minerUpgrades.Visible = false;
            }
            if (drillUpgrades.Visible == true)
            {
                drillUpgrades.Visible = false;
            }
            if (excavatorUpgrades.Visible == true)
            {
                excavatorUpgrades.Visible = false;
            }

        }
        //method to show the upgrade trees
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        // the upgrade tree for the tokens
        private void tokenUpgrades_Click(object sender, EventArgs e)
        {
            showSubMenu(tokenUpgradesMenu);
        }
        // upgrade tree for the miners
        private void showMinerUpgrades_Click(object sender, EventArgs e)
        {
            showSubMenu(minerUpgrades);
        }
        //upgrade tree for the drill
        private void showDrillUpgrades_Click(object sender, EventArgs e)
        {
            showSubMenu(drillUpgrades);
        }
        //upgrade tree for the escavators
        private void showEscUpgrades_Click(object sender, EventArgs e)
        {
            showSubMenu(excavatorUpgrades);
        }

        //update textboxes for the different worlds
        private void UpdateText()
        {
            //first world content
            if (worldCounter == 0)
            {
                resource1TextBox.Text = "Iron: " + resource1._count.ToString("F0") + Environment.NewLine + "Iron Per Second: " + resource1._perSecond.ToString("F0");
                resource1PerClickUpgrade.Text = "Iron Per Click x2 \nCost: " + resource1._perClickUpgradeCost.ToString("F0");
                resource1PerSecondUpgrade1.Text = "Iron Miner\n Increases iron by " + resource1.increaseResourceperSecond1 + " per second\n\n Cost: " + resource1._perSecondUpgrade1Cost.ToString("F0") + " iron";
                resource1PerSecondUpgrade2.Text = "Iron Drill\n Increases iron by " + resource1.increaseResourcePerSecond2 + " per second\n\n Cost: " + resource1._perSecondUpgrade2Cost.ToString("F0") + " iron";
                resource1PerSecondUpgrade3.Text = "Iron Escavator\n Increases iron by " + resource1.increaseResourcePerSecond3 + " per second\n\n Cost: " + resource1._perSecondUpgrade3Cost.ToString("F0") + " iron";


                resource2TextBox.Text = "Gold: " + resource2.Count.ToString("F0") + Environment.NewLine + "Gold Per Second: " + resource2.PerSecond.ToString("F0");
                resource2PerClickUpgrade.Text = "Gold Per Click x2 \nCost: " + resource2.PerClickUpgradeCost.ToString("F0");
                resource2PerSecondUpgrade1.Text = "Gold Miner\n Increases gold by " + resource2.perSecond1 + " per second\n\n Cost: " + resource2.PerSecondUpgrade1Cost.ToString("F0") + " gold";
                resource2PerSecondUpgrade2.Text = "Gold Drill\n Increases gold by " + resource2.perSecond2 + " per second\n\n Cost: " + resource2.PerSecondUpgrade2Cost.ToString("F0") + " gold";
                resource2PerSecondUpgrade3.Text = "Gold Escavator\n Increases gold by " + resource2.perSecond3 + " per second\n\n Cost: " + resource2.PerSecondUpgrade3Cost.ToString("F0") + " gold";

                resource3TextBox.Text = "Titanium: " + resource3.Count.ToString("F0") + Environment.NewLine + "Titanium Per Second: " + resource3.PerSecond.ToString("F0");
                resource3PerClickUpgrade.Text = "Titanium Per Click x2 \nCost: " + resource3.PerClickUpgradeCost.ToString("F0");
                resource3PerSecondUpgrade1.Text = "Titanium Miner\n Increases titanium by " + resource3.perSecond1 + " per second\n\n Cost: " + resource3.PerSecondUpgrade1Cost.ToString("F0") + " titanium";
                resource3PerSecondUpgrade2.Text = "Titanium Drill\n Increases titanium by " + resource3.perSecond2 + " per second\n\n Cost: " + resource3.PerSecondUpgrade2Cost.ToString("F0") + " titanium";
                resource3PerSecondUpgrade3.Text = "Titanium Escavator\n Increases titanium by " + resource3.perSecond3 + " per second\n\n Cost: " + resource3.PerSecondUpgrade3Cost.ToString("F0") + " titanium";

                resource4TextBox.Text = "Diamond: " + resource4.Count.ToString("F0") + Environment.NewLine + "Diamond Per Second: " + resource4.PerSecond.ToString("F0");
                resource4PerClickUpgrade.Text = "Diamond Per Click x2 \nCost: " + resource4.PerClickUpgradeCost.ToString("F0");
                resource4PerSecondUpgrade1.Text = "Diamond Miner\n Increases diamond by " + resource4.perSecond1 + " per second\n\n Cost: " + resource4.PerSecondUpgrade1Cost.ToString("F0") + " diamond";
                resource4PerSecondUpgrade2.Text = "Diamond Drill\n Increases diamond by " + resource4.perSecond2 + " per second\n\n Cost: " + resource4.PerSecondUpgrade2Cost.ToString("F0") + " diamond";
                resource4PerSecondUpgrade3.Text = "Diamond Escavator\n Increases diamond by " + resource4.perSecond3 + " per second\n\n Cost: " + resource4.PerSecondUpgrade3Cost.ToString("F0") + " diamond";

                resource1ToRocket.Text = "send iron to rocket\n" + resource1.resource1ToRocket.ToString("F0") + " total sent\n" + (resource1.resource1Needed - resource1.resource1ToRocket).ToString("F0") + " needed!";
                resource2ToRocket.Text = "send gold to rocket\n" + resource2.resource2ToRocket.ToString("F0") + " total sent\n" + (resource2.resource2Needed - resource2.resource2ToRocket).ToString("F0") + " needed!";
                resource3ToRocket.Text = "send titanium to rocket\n" + resource3.resource3ToRocket.ToString("F0") + " total sent\n" + (resource3.resource3Needed - resource3.resource3ToRocket).ToString("F0") + " needed!";
                resource4ToRocket.Text = "send diamond to rocket\n" + resource4.resource4ToRocket.ToString("F0") + " total sent\n" + (resource4.resource4Needed - resource4.resource4ToRocket).ToString("F0") + " needed!";

                resource1MinerUpgrade.Text = "iron miner + " + resource1.increasePerSecond1UpgradeCount.ToString() + "\nCosts: " + resource1.increasePerSecond1UpgradeCost.ToString("F0") + " iron";
                resource2MinerUpgrade.Text = "gold miner + " + resource2.increasePerSecond1UpgradeCount.ToString() + "\nCosts: " + resource2.perSecond1UpgradeCost.ToString("F0") + " gold";
                resource3MinerUpgrade.Text = "titanium miner + " + resource3.increasePerSecond1UpgradeCount.ToString() + "\nCosts: " + resource3.perSecond1UpgradeCost.ToString("F0") + " titanium";
                resource4MinerUpgrade.Text = "diamond miner + " + resource4.increasePerSecond1UpgradeCount.ToString() + "\nCosts: " + resource4.perSecond1UpgradeCost.ToString("F0") + " diamond";

                resource1DrillUpgrade.Text = "iron drill + " + resource1.increasePerSecond2UpgradeCount.ToString() + "\nCosts: " + resource1.increasePerSecond2UpgradeCost.ToString("F0") + " iron";
                resource2DrillUpgrade.Text = "gold drill + " + resource2.increasePerSecond2UpgradeCount.ToString() + "\nCosts: " + resource2.perSecond2UpgradeCost.ToString("F0") + " gold";
                resource4DrillUpgrade.Text = "diamond drill + " + resource4.increasePerSecond2UpgradeCount.ToString() + "\nCosts: " + resource4.perSecond2UpgradeCost.ToString("F0") + " diamond";
                resource3DrillUpgrade.Text = "titanium drill + " + resource3.increasePerSecond2UpgradeCount.ToString() + "\nCosts: " + resource3.perSecond2UpgradeCost.ToString("F0") + " titanium";

                resource1EscUpgrade.Text = "iron esc + " + resource1.increasePerSecond3UpgradeCount.ToString() + "\nCosts: " + resource1.increasePerSecond3UpgradeCost.ToString("F0") + " iron";
                resource2EscUpgrade.Text = "gold esc + " + resource2.increasePerSecond3UpgradeCount.ToString() + "\nCosts: " + resource2.perSecond3UpgradeCost.ToString("F0") + " gold";
                resource3EscUpgrade.Text = "titanium esc + " + resource3.increasePerSecond3UpgradeCount.ToString() + "\nCosts: " + resource3.perSecond3UpgradeCost.ToString("F0") + " titanium";
                resource4EscUpgrade.Text = "diamond esc + " + resource4.increasePerSecond3UpgradeCount.ToString() + "\nCosts: " + resource4.perSecond3UpgradeCost.ToString("F0") + " diamond";
            }



            // second world content
            if(worldCounter == 1)
            {
                resource1TextBox.Text = "Uranium: " + resource1._count.ToString("F0") + Environment.NewLine + "Uranium Per Second: " + resource1._perSecond.ToString("F0");
                resource1PerClickUpgrade.Text = "Uranium Per Click x2 \nCost: " + resource1._perClickUpgradeCost.ToString("F0");
                resource1PerSecondUpgrade1.Text = "Uranium Miner\n Increases Uranium by " + resource1.increaseResourceperSecond1 + " per second\n\n Cost: " + resource1._perSecondUpgrade1Cost.ToString("F0") + " Uranium";
                resource1PerSecondUpgrade2.Text = "Uranium Drill\n Increases Uranium by " + resource1.increaseResourcePerSecond2 + " per second\n\n Cost: " + resource1._perSecondUpgrade2Cost.ToString("F0") + " Uranium";
                resource1PerSecondUpgrade3.Text = "Uranium Escavator\n Increases Uranium by " + resource1.increaseResourcePerSecond3 + " per second\n\n Cost: " + resource1._perSecondUpgrade3Cost.ToString("F0") + " Uranium";


                resource2TextBox.Text = "Plutonium: " + resource2.Count.ToString("F0") + Environment.NewLine + "Plutonium Per Second: " + resource2.PerSecond.ToString("F0");
                resource2PerClickUpgrade.Text = "Plutonium Per Click x2 \nCost: " + resource2.PerClickUpgradeCost.ToString("F0");
                resource2PerSecondUpgrade1.Text = "Plutonium Miner\n Increases Plutonium by " + resource2.perSecond1 + " per second\n\n Cost: " + resource2.PerSecondUpgrade1Cost.ToString("F0") + " Plutonium";
                resource2PerSecondUpgrade2.Text = "Plutonium Drill\n Increases Plutonium by " + resource2.perSecond2 + " per second\n\n Cost: " + resource2.PerSecondUpgrade2Cost.ToString("F0") + " Plutonium";
                resource2PerSecondUpgrade3.Text = "Plutonium Escavator\n Increases Plutonium by " + resource2.perSecond3 + " per second\n\n Cost: " + resource2.PerSecondUpgrade3Cost.ToString("F0") + " Plutonium";

                resource3TextBox.Text = "Tin: " + resource3.Count.ToString("F0") + Environment.NewLine + "Tin Per Second: " + resource3.PerSecond.ToString("F0");
                resource3PerClickUpgrade.Text = "Tin Per Click x2 \nCost: " + resource3.PerClickUpgradeCost.ToString("F0");
                resource3PerSecondUpgrade1.Text = "Tin Miner\n Increases Tin by " + resource3.perSecond1 + " per second\n\n Cost: " + resource3.PerSecondUpgrade1Cost.ToString("F0") + " Tin";
                resource3PerSecondUpgrade2.Text = "Tin Drill\n Increases Tin by " + resource3.perSecond2 + " per second\n\n Cost: " + resource3.PerSecondUpgrade2Cost.ToString("F0") + " Tin";
                resource3PerSecondUpgrade3.Text = "Tin Escavator\n Increases Tin by " + resource3.perSecond3 + " per second\n\n Cost: " + resource3.PerSecondUpgrade3Cost.ToString("F0") + " Tin";

                resource4TextBox.Text = "Silicon: " + resource4.Count.ToString("F0") + Environment.NewLine + "Silicon Per Second: " + resource4.PerSecond.ToString("F0");
                resource4PerClickUpgrade.Text = "Silicon Per Click x2 \nCost: " + resource4.PerClickUpgradeCost.ToString("F0");
                resource4PerSecondUpgrade1.Text = "Silicon Miner\n Increases Silicon by " + resource4.perSecond1 + " per second\n\n Cost: " + resource4.PerSecondUpgrade1Cost.ToString("F0") + " Silicon";
                resource4PerSecondUpgrade2.Text = "Silicon Drill\n Increases Silicon by " + resource4.perSecond2 + " per second\n\n Cost: " + resource4.PerSecondUpgrade2Cost.ToString("F0") + " Silicon";
                resource4PerSecondUpgrade3.Text = "Silicon Escavator\n Increases Silicon by " + resource4.perSecond3 + " per second\n\n Cost: " + resource4.PerSecondUpgrade3Cost.ToString("F0") + " Silicon";

                resource1ToRocket.Text = "send Uranium to rocket\n" + resource1.resource1ToRocket.ToString("F0") + " total sent\n" + (resource1.resource1Needed - resource1.resource1ToRocket).ToString("F0") + " needed!";
                resource2ToRocket.Text = "send Plutonium to rocket\n" + resource2.resource2ToRocket.ToString("F0") + " total sent\n" + (resource2.resource2Needed - resource2.resource2ToRocket).ToString("F0") + " needed!";
                resource3ToRocket.Text = "send Tin to rocket\n" + resource3.resource3ToRocket.ToString("F0") + " total sent\n" + (resource3.resource3Needed - resource3.resource3ToRocket).ToString("F0") + " needed!";
                resource4ToRocket.Text = "send Silicon to rocket\n" + resource4.resource4ToRocket.ToString("F0") + " total sent\n" + (resource4.resource4Needed - resource4.resource4ToRocket).ToString("F0") + " needed!";

                resource1MinerUpgrade.Text = "Uranium miner + " + resource1.increasePerSecond1UpgradeCount.ToString() + "\nCosts: " + resource1.increasePerSecond1UpgradeCost.ToString("F0") + " Uranium";
                resource2MinerUpgrade.Text = "Plutonium miner + " + resource2.increasePerSecond1UpgradeCount.ToString() + "\nCosts: " + resource2.perSecond1UpgradeCost.ToString("F0") + " Plutonium";
                resource3MinerUpgrade.Text = "Tin miner + " + resource3.increasePerSecond1UpgradeCount.ToString() + "\nCosts: " + resource3.perSecond1UpgradeCost.ToString("F0") + " Tin";
                resource4MinerUpgrade.Text = "Silicon miner + " + resource4.increasePerSecond1UpgradeCount.ToString() + "\nCosts: " + resource4.perSecond1UpgradeCost.ToString("F0") + " Silicon";

                resource1DrillUpgrade.Text = "Uranium drill + " + resource1.increasePerSecond2UpgradeCount.ToString() + "\nCosts: " + resource1.increasePerSecond2UpgradeCost.ToString("F0") + " Uranium";
                resource2DrillUpgrade.Text = "Plutonium drill + " + resource2.increasePerSecond2UpgradeCount.ToString() + "\nCosts: " + resource2.perSecond2UpgradeCost.ToString("F0") + " gold";
                resource4DrillUpgrade.Text = "Silicon drill + " + resource4.increasePerSecond2UpgradeCount.ToString() + "\nCosts: " + resource4.perSecond2UpgradeCost.ToString("F0") + " Silicon";
                resource3DrillUpgrade.Text = "Tin drill + " + resource3.increasePerSecond2UpgradeCount.ToString() + "\nCosts: " + resource3.perSecond2UpgradeCost.ToString("F0") + " Tin";

                resource1EscUpgrade.Text = "Uranium esc + " + resource1.increasePerSecond3UpgradeCount.ToString() + "\nCosts: " + resource1.increasePerSecond3UpgradeCost.ToString("F0") + " Uranium";
                resource2EscUpgrade.Text = "Plutonium esc + " + resource2.increasePerSecond3UpgradeCount.ToString() + "\nCosts: " + resource2.perSecond3UpgradeCost.ToString("F0") + " Plutonium";
                resource3EscUpgrade.Text = "Tin esc + " + resource3.increasePerSecond3UpgradeCount.ToString() + "\nCosts: " + resource3.perSecond3UpgradeCost.ToString("F0") + " Tin";
                resource4EscUpgrade.Text = "Silicon esc + " + resource4.increasePerSecond3UpgradeCount.ToString() + "\nCosts: " + resource4.perSecond3UpgradeCost.ToString("F0") + " Silicon";

                tokenUpgrades.Text = "Upgrades\nTokens aquired: " + upgradeTree.UpgradeTokens;
            
            }

        }

        // main button
        private void resourceButton_Click(object sender, EventArgs e)
        {
            resource1._count += resource1._perClick;
            resource2.Count += resource2.PerClick;
            resource3.Count += resource3.PerClick;
            resource4.Count += resource4.PerClick;

            UpdateText();

        }
        // save button
        private void saveGameButton_Click(object sender, EventArgs e)
        {

        }
        //launch button once youve gotten enough resources
        private void launchButton_Click(object sender, EventArgs e)
        {
            worldCounter++;
            upgradeTree.UpgradeTokens += worldCounter;
            launchButton.Enabled = false;
            launchButton.Visible = false;
            resourceButton.Enabled = true;
            resource1ToRocket.Enabled = true;
            resource2ToRocket.Enabled = true;
            resource3ToRocket.Enabled = true;
            resource4ToRocket.Enabled = true;
            NewWorld();

        }
        // per click upgrades
        private void ironPerClickUpgrade_Click(object sender, EventArgs e)
        {
            resource1.IncreasePerClick();
        }
        private void goldPerClickUpgrade_Click(object sender, EventArgs e)
        {
            resource2.IncreasePerClick();

        }
        private void titaniumPerClickUpgrade_Click(object sender, EventArgs e)
        {
            resource3.IncreasePerClick();
        }
        private void diamondPerClickUpgrade_Click(object sender, EventArgs e)
        {
            resource4.IncreasePerClick();
        }
        //resource 1 per second upgrades
        private void ironPerSecondUpgrade1_Click(object sender, EventArgs e)
        {
            resource1.IncreasePerSecond1();
        }
        private void ironPerSecondUpgrade2_Click(object sender, EventArgs e)
        {
            resource1.IncreasePerSecond2();
        }
        private void ironPerSecondUpgrade3_Click(object sender, EventArgs e)
        {
            resource1.IncreasePerSecond3();
        }
        //resource 2 per second upgrades 
        private void goldPerSecondUpgrade1_Click(object sender, EventArgs e)
        {
            resource2.IncreasePerSecond1();
        }
        private void goldPerSecondUpgrade2_Click(object sender, EventArgs e)
        {
            resource2.IncreasePerSecond2();
        }
        private void goldPerSecondUpgrade3_Click(object sender, EventArgs e)
        {
            resource2.IncreasePerSecond3();
        }
        //resource 3 per second upgrades 
        private void titaniumPerSecondUpgrade1_Click(object sender, EventArgs e)
        {
            resource3.IncreasePerSecond1();
        }
        private void titaniumPerSecondUpgrade2_Click(object sender, EventArgs e)
        {
            resource3.IncreasePerSecond2();
        }
        private void titaniumPerSecondUpgrade3_Click(object sender, EventArgs e)
        {
            resource3.IncreasePerSecond3();
        }
        //resource 4 per second upgrades
        private void diamondPerSecondUpgrade1_Click(object sender, EventArgs e)
        {
            resource4.IncreasePerSecond1();
        }
        private void diamondPerSecondUpgrade2_Click(object sender, EventArgs e)
        {
            resource4.IncreasePerSecond2();
        }
        private void diamondPerSecondUpgrade3_Click(object sender, EventArgs e)
        {
            resource4.IncreasePerSecond3();
        }
        //send resources to the rocket
        private void titaniumToRocket_Click(object sender, EventArgs e)
        {
            resource3.ContributeToRocket();
        }
        private void ironToRocket_Click(object sender, EventArgs e)
        {
            resource1.ContributeToRocket();
        }
        private void goldToRocket_Click(object sender, EventArgs e)
        {
            resource2.ContributeToRocket();
        }
        private void diamondToRocket_Click(object sender, EventArgs e)
        {
            resource4.ContributeToRocket();
        }
        // miner upgrade tree buttons
        private void ironMinerUpgrade_Click(object sender, EventArgs e)
        {
            resource1.IncreasePerSecond1Upgrade();
        }
        private void goldMinerUpgrade_Click(object sender, EventArgs e)
        {
            resource2.IncreasePerSecond1Upgrade();
        }
        private void titaniumMinerUpgrade_Click(object sender, EventArgs e)
        {
            resource3.IncreasePerSecond1Upgrade();
        }
        private void diamondMinerUpgrade_Click(object sender, EventArgs e)
        {
            resource4.IncreasePerSecond1Upgrade();
        }
        // drill upgrade tree buttons
        private void ironDrillUpgrade_Click(object sender, EventArgs e)
        {
            resource1.IncreasePerSecond2Upgrade();
        }
        private void goldDrillUpgrade_Click(object sender, EventArgs e)
        {
            resource2.IncreasePerSecond2Upgrade();
        }
        private void titaniumDrillUpgrade_Click(object sender, EventArgs e)
        {
            resource3.IncreasePerSecond2Upgrade();
        }
        private void diamondDrillUpgrade_Click(object sender, EventArgs e)
        {
            resource4.IncreasePerSecond2Upgrade();
        }
        //escavator upgrade tree buttons
        private void ironEscUpgrade_Click(object sender, EventArgs e)
        {
            resource1.IncreasePerSecond3Upgrade();
        }
        private void goldEscUpgrade_Click(object sender, EventArgs e)
        {
            resource2.IncreasePerSecond3Upgrade();
        }
        private void titaniumEscUpgrade_Click(object sender, EventArgs e)
        {
            resource3.IncreasePerSecond3Upgrade();
        }
        private void diamondEscUpgrade_Click(object sender, EventArgs e)
        {
            resource4.IncreasePerSecond3Upgrade();
        }
        //token upgrade tree buttons
        private void clickUpgradeCostDecrease_Click(object sender, EventArgs e)
        {
            upgradeTree.ClickCostDecrease();
            if (upgradeTree.ClickUpgradeDecreaseCounter == 0)
            {
                resource1._perClickUpgradeCost /= 2;
            }
            else if (upgradeTree.ClickUpgradeDecreaseCounter == 1) {
                resource2.PerClickUpgradeCost /= 2;
            }
            else if (upgradeTree.ClickUpgradeDecreaseCounter == 2)
            {
                resource3.PerClickUpgradeCost /= 2;
            }
            else if (upgradeTree.ClickUpgradeDecreaseCounter == 3)
            {
                resource4.PerClickUpgradeCost /= 2;
            }
        }

        private void rocketProgressBar_Click(object sender, EventArgs e)
        {

        }
    }
}
