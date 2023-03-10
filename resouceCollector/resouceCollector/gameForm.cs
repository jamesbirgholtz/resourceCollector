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
            iron = new Iron(1000000, 0, 0, 100, 150, 300, 600);
            gold = new Gold(1000000, 0, 0, 200, 300, 600, 900);
            titanium = new Titanium(100000, 0, 0, 400, 600, 1200, 1800);
            diamond = new Diamond(100000, 0, 0, 800, 1200, 2400, 3600);

            UpdateText();
            perSecondResource.Start();
            textUpdater.Start();
        }


        private void rocketProgressTracker()
        {
            double rocketResourcesNeeded = iron.ironNeeded + gold.goldNeeded + titanium.titaniumNeeded + diamond.diamondNeeded;
            double rocketReasourcesCollected = iron.ironToRocket + gold.goldToRocket + titanium.titaniumToRocket + diamond.diamondToRocket;
            double rocketProgress = rocketReasourcesCollected / rocketResourcesNeeded * 100;
            rocketProgressBar.Value = (int)rocketProgress;
        }

        //timer
        private void textUpdater_Tick(object sender, EventArgs e)
        {
            UpdateText();
            rocketProgressTracker();
        }

        //update textboxes
        private void UpdateText()
        {
            ironTextBox.Text = "Iron: " + iron.Count.ToString("F0") + Environment.NewLine + "Iron Per Second: " + iron.PerSecond.ToString("F0");
            ironPerClickUpgrade.Text = "Iron Per Click x2 \nCost: " + iron.PerClickUpgradeCost.ToString("F0");
            ironPerSecondUpgrade1.Text = "Iron Miner\n Increases iron by 15 per second\n\n Cost: " + iron.PerSecondUpgrade1Cost.ToString("F0") + " iron";
            ironPerSecondUpgrade2.Text = "Iron Drill\n Increases iron by 30 per second\n\n Cost: " + iron.PerSecondUpgrade2Cost.ToString("F0") + " iron";
            ironPerSecondUpgrade3.Text = "Iron Excavator\n Increases iron by 45 per second\n\n Cost: " + iron.PerSecondUpgrade3Cost.ToString("F0") + " iron";


            goldTextBox.Text = "Gold: " + gold.Count.ToString("F0") + Environment.NewLine + "Gold Per Second: " + gold.PerSecond.ToString("F0");
            goldPerClickUpgrade.Text = "Gold Per Click x2 \nCost: " + gold.PerClickUpgradeCost.ToString("F0");
            goldPerSecondUpgrade1.Text = "Gold Miner\n Increases gold by 5 per second\n\n Cost :" + gold.PerSecondUpgrade1Cost.ToString("F0") + " gold";
            goldPerSecondUpgrade2.Text = "Gold Drill\n Increases gold by 10 per second\n\n Cost:" + gold.PerSecondUpgrade2Cost.ToString("F0") + " gold";
            goldPerSecondUpgrade3.Text = "Gold Excavator\n Increases gold by 15 per second\n\n Cost:" + gold.PerSecondUpgrade3Cost.ToString("F0") + " gold";

            titaniumTextBox.Text = "Titanium: " + titanium.Count.ToString("F0") + Environment.NewLine + "Titanium Per Second: " + titanium.PerSecond.ToString("F0");
            titaniumPerClickUpgrade.Text = "Titanium Per Click x2 \nCost: " + titanium.PerClickUpgradeCost.ToString("F0");
            titaniumPerSecondUpgrade1.Text = "Titanium Miner\n Increases titanium by 3 per second\n\n Cost:" + titanium.PerSecondUpgrade1Cost.ToString("F0") + " titanium";
            titaniumPerSecondUpgrade2.Text = "Titanium Drill\n Increases titanium by 6 per second\n\n Cost:" + titanium.PerSecondUpgrade2Cost.ToString("F0") + " titanium";
            titaniumPerSecondUpgrade3.Text = "Titanium Excavator\n Increases titanium by 9 per second\n\n Cost:" + titanium.PerSecondUpgrade3Cost.ToString("F0") + " titanium";

            diamondTextBox.Text = "Diamond: " + diamond.Count.ToString("F0") + Environment.NewLine + "Diamond Per Second: " + diamond.PerSecond.ToString("F0");
            diamondPerClickUpgrade.Text = "Diamond Per Click x2 \nCost: " + diamond.PerClickUpgradeCost.ToString("F0");
            diamondPerSecondUpgrade1.Text = "Diamond Miner\n Increases diamond by 1 per second\n\n Cost:" + diamond.PerSecondUpgrade1Cost.ToString("F0") + " diamond";
            diamondPerSecondUpgrade2.Text = "Diamond Drill\n Increases diamond by 2 per second\n\n Cost:" + diamond.PerSecondUpgrade2Cost.ToString("F0") + " diamond";
            diamondPerSecondUpgrade3.Text = "Diamond Excavator\n Increases diamond by 3 per second\n\n Cost:" + diamond.PerSecondUpgrade3Cost.ToString("F0") + " diamond";

            ironToRocket.Text = "send iron to rocket\n" + iron.ironToRocket.ToString("F0") + " total sent\n" + iron.ironNeeded.ToString("F0") + " needed!";
            goldToRocket.Text = "send gold to rocket\n" + gold.goldToRocket.ToString("F0") + " total sent\n" + gold.goldNeeded.ToString("F0") + " needed!";
            titaniumToRocket.Text = "send titanium to rocket\n" + titanium.titaniumToRocket.ToString("F0") + " total sent\n" + titanium.titaniumNeeded.ToString("F0") + " needed!";
            diamondToRocket.Text = "send diamond to rocket\n" + diamond.diamondToRocket.ToString("F0") + " total sent\n" + diamond.diamondNeeded.ToString("F0") + " needed!";

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

        private void resourcesToRocket_Tick(object sender, EventArgs e)
        {

        }
    }
}
