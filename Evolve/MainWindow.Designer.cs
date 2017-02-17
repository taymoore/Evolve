using System;
using System.Drawing;
using System.Windows.Forms;

namespace Evolve {
	partial class MainWindow {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanelCreature = new System.Windows.Forms.FlowLayoutPanel();
            this.labelCreature = new System.Windows.Forms.Label();
            this.labelResources = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelOreOwned = new System.Windows.Forms.Label();
            this.labelOreOwnedValue = new System.Windows.Forms.Label();
            this.labelAgeOwned = new System.Windows.Forms.Label();
            this.labelAgeOwnedValue = new System.Windows.Forms.Label();
            this.labelFoodOwnedValue = new System.Windows.Forms.Label();
            this.labelFoodOwned = new System.Windows.Forms.Label();
            this.labelSkills = new System.Windows.Forms.Label();
            this.tableLayoutPanelSkills = new System.Windows.Forms.TableLayoutPanel();
            this.labelSkillMining = new System.Windows.Forms.Label();
            this.labelSkillFarming = new System.Windows.Forms.Label();
            this.labelSkillMiningValue = new System.Windows.Forms.Label();
            this.labelSkillFighting = new System.Windows.Forms.Label();
            this.labelSkillFarmingValue = new System.Windows.Forms.Label();
            this.labelSkillFightingValue = new System.Windows.Forms.Label();
            this.labelThoughts = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelActivity = new System.Windows.Forms.Label();
            this.labelActivityValue = new System.Windows.Forms.Label();
            this.tableLayoutPanelNeuralNetwork = new System.Windows.Forms.TableLayoutPanel();
            this.labelLootProspect = new System.Windows.Forms.Label();
            this.labelFoodAreaValue = new System.Windows.Forms.Label();
            this.labelFoodMoveValue = new System.Windows.Forms.Label();
            this.labelFoodTileValue = new System.Windows.Forms.Label();
            this.labelFoodSelf = new System.Windows.Forms.Label();
            this.labelFarm = new System.Windows.Forms.Label();
            this.labelFoodSelfValue = new System.Windows.Forms.Label();
            this.labelFarmValue = new System.Windows.Forms.Label();
            this.labelCreatureOutputs = new System.Windows.Forms.Label();
            this.labelCreatureInputs = new System.Windows.Forms.Label();
            this.labelFoodTile = new System.Windows.Forms.Label();
            this.labelFoodArea = new System.Windows.Forms.Label();
            this.labelOrePrice = new System.Windows.Forms.Label();
            this.labelOrePriceValue = new System.Windows.Forms.Label();
            this.labelFoodPriceValue = new System.Windows.Forms.Label();
            this.labelFoodPrice = new System.Windows.Forms.Label();
            this.labelOreAreaValue = new System.Windows.Forms.Label();
            this.labelOreArea = new System.Windows.Forms.Label();
            this.labelOreTile = new System.Windows.Forms.Label();
            this.labelOreTileValue = new System.Windows.Forms.Label();
            this.labelOreSelfValue = new System.Windows.Forms.Label();
            this.labelOreSelf = new System.Windows.Forms.Label();
            this.labelFoodProperty = new System.Windows.Forms.Label();
            this.labelFoodPropertyValue = new System.Windows.Forms.Label();
            this.labelBuyLand = new System.Windows.Forms.Label();
            this.labelBuyLandValue = new System.Windows.Forms.Label();
            this.labelTrade = new System.Windows.Forms.Label();
            this.labelTradeValue = new System.Windows.Forms.Label();
            this.labelOreCost = new System.Windows.Forms.Label();
            this.labelFoodCost = new System.Windows.Forms.Label();
            this.labelOreCostValue = new System.Windows.Forms.Label();
            this.labelFoodCostValue = new System.Windows.Forms.Label();
            this.labelMine = new System.Windows.Forms.Label();
            this.labelMineValue = new System.Windows.Forms.Label();
            this.labelFoodMove = new System.Windows.Forms.Label();
            this.labelOreMove = new System.Windows.Forms.Label();
            this.labelOreMoveValue = new System.Windows.Forms.Label();
            this.labelMoveProperty = new System.Windows.Forms.Label();
            this.labelMovePropertyValue = new System.Windows.Forms.Label();
            this.labelLootProspectValue = new System.Windows.Forms.Label();
            this.labelLoot = new System.Windows.Forms.Label();
            this.labelLootValue = new System.Windows.Forms.Label();
            this.flowLayoutPanelGenerateMap = new System.Windows.Forms.FlowLayoutPanel();
            this.labelGenerateMap = new System.Windows.Forms.Label();
            this.tableLayoutPanelMapSize = new System.Windows.Forms.TableLayoutPanel();
            this.labelMapWidth = new System.Windows.Forms.Label();
            this.textBoxMapWidth = new System.Windows.Forms.TextBox();
            this.textBoxMapHeight = new System.Windows.Forms.TextBox();
            this.labelMapHeight = new System.Windows.Forms.Label();
            this.labelCreatureCount = new System.Windows.Forms.Label();
            this.textBoxCreatureCount = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelMapProperties = new System.Windows.Forms.TableLayoutPanel();
            this.labelMapGoldPersistence = new System.Windows.Forms.Label();
            this.trackBarMapOreScale = new System.Windows.Forms.TrackBar();
            this.labelMapFoodDensity = new System.Windows.Forms.Label();
            this.trackBarMapFoodDensity = new System.Windows.Forms.TrackBar();
            this.labelMapFoodDensityValue = new System.Windows.Forms.Label();
            this.labelMapFoodOctaves = new System.Windows.Forms.Label();
            this.labelMapFoodScale = new System.Windows.Forms.Label();
            this.trackBarMapFoodOctaves = new System.Windows.Forms.TrackBar();
            this.trackBarMapFoodScale = new System.Windows.Forms.TrackBar();
            this.labelMapFoodOctavesValue = new System.Windows.Forms.Label();
            this.labelMapFoodScaleValue = new System.Windows.Forms.Label();
            this.trackBarMapGoldScale = new System.Windows.Forms.TrackBar();
            this.labelMapGoldOctaves = new System.Windows.Forms.Label();
            this.labelMapGoldScale = new System.Windows.Forms.Label();
            this.labelMapGoldDensity = new System.Windows.Forms.Label();
            this.labelMapOreOctaves = new System.Windows.Forms.Label();
            this.labelMapOreScale = new System.Windows.Forms.Label();
            this.labelMapOreDensity = new System.Windows.Forms.Label();
            this.trackBarMapGoldOctaves = new System.Windows.Forms.TrackBar();
            this.labelMapGoldOctavesValue = new System.Windows.Forms.Label();
            this.labelMapGoldScaleValue = new System.Windows.Forms.Label();
            this.trackBarMapGoldDensity = new System.Windows.Forms.TrackBar();
            this.labelMapGoldDensityValue = new System.Windows.Forms.Label();
            this.trackBarMapOreOctaves = new System.Windows.Forms.TrackBar();
            this.labelMapOreOctavesValue = new System.Windows.Forms.Label();
            this.labelMapOreScaleValue = new System.Windows.Forms.Label();
            this.trackBarMapOreDensity = new System.Windows.Forms.TrackBar();
            this.labelMapOreDensityValue = new System.Windows.Forms.Label();
            this.labelMapFoodPersistence = new System.Windows.Forms.Label();
            this.trackBarMapFoodPersistence = new System.Windows.Forms.TrackBar();
            this.labelMapFoodPersistenceValue = new System.Windows.Forms.Label();
            this.labelMapOrePersistence = new System.Windows.Forms.Label();
            this.labelMapGoldPersistenceValue = new System.Windows.Forms.Label();
            this.labelMapOrePersistenceValue = new System.Windows.Forms.Label();
            this.trackBarMapOrePersistence = new System.Windows.Forms.TrackBar();
            this.trackBarMapGoldPersistence = new System.Windows.Forms.TrackBar();
            this.buttonGenerateMap = new System.Windows.Forms.Button();
            this.labelMapParameters = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.labelCreaturesValue = new System.Windows.Forms.Label();
            this.labelCreatures = new System.Windows.Forms.Label();
            this.flowLayoutPanelTile = new System.Windows.Forms.FlowLayoutPanel();
            this.labelTile = new System.Windows.Forms.Label();
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.labelFrameRate = new System.Windows.Forms.Label();
            this.map = new Evolve.Map();
            this.toolStripMapFilter = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonFood = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOre = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGold = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanelCreature.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanelSkills.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanelNeuralNetwork.SuspendLayout();
            this.flowLayoutPanelGenerateMap.SuspendLayout();
            this.tableLayoutPanelMapSize.SuspendLayout();
            this.tableLayoutPanelMapProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMapOreScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMapFoodDensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMapFoodOctaves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMapFoodScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMapGoldScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMapGoldOctaves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMapGoldDensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMapOreOctaves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMapOreDensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMapFoodPersistence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMapOrePersistence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMapGoldPersistence)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.flowLayoutPanelTile.SuspendLayout();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.toolStripMapFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanelCreature);
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanelGenerateMap);
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanelTile);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.toolStripContainer);
            this.splitContainer1.Size = new System.Drawing.Size(1269, 676);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 1;
            // 
            // flowLayoutPanelCreature
            // 
            this.flowLayoutPanelCreature.Controls.Add(this.labelCreature);
            this.flowLayoutPanelCreature.Controls.Add(this.labelResources);
            this.flowLayoutPanelCreature.Controls.Add(this.tableLayoutPanel3);
            this.flowLayoutPanelCreature.Controls.Add(this.labelSkills);
            this.flowLayoutPanelCreature.Controls.Add(this.tableLayoutPanelSkills);
            this.flowLayoutPanelCreature.Controls.Add(this.labelThoughts);
            this.flowLayoutPanelCreature.Controls.Add(this.tableLayoutPanel2);
            this.flowLayoutPanelCreature.Controls.Add(this.tableLayoutPanelNeuralNetwork);
            this.flowLayoutPanelCreature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelCreature.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelCreature.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelCreature.Name = "flowLayoutPanelCreature";
            this.flowLayoutPanelCreature.Size = new System.Drawing.Size(200, 676);
            this.flowLayoutPanelCreature.TabIndex = 7;
            // 
            // labelCreature
            // 
            this.labelCreature.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCreature.AutoSize = true;
            this.labelCreature.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreature.Location = new System.Drawing.Point(70, 0);
            this.labelCreature.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCreature.Name = "labelCreature";
            this.labelCreature.Size = new System.Drawing.Size(63, 17);
            this.labelCreature.TabIndex = 4;
            this.labelCreature.Text = "Creature";
            // 
            // labelResources
            // 
            this.labelResources.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelResources.AutoSize = true;
            this.labelResources.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResources.Location = new System.Drawing.Point(64, 17);
            this.labelResources.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResources.Name = "labelResources";
            this.labelResources.Size = new System.Drawing.Size(76, 17);
            this.labelResources.TabIndex = 7;
            this.labelResources.Text = "Resources";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.labelOreOwned, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelOreOwnedValue, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelAgeOwned, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.labelAgeOwnedValue, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.labelFoodOwnedValue, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelFoodOwned, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(66, 37);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(71, 60);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // labelOreOwned
            // 
            this.labelOreOwned.AutoSize = true;
            this.labelOreOwned.Location = new System.Drawing.Point(3, 20);
            this.labelOreOwned.Name = "labelOreOwned";
            this.labelOreOwned.Size = new System.Drawing.Size(27, 13);
            this.labelOreOwned.TabIndex = 14;
            this.labelOreOwned.Text = "Ore:";
            // 
            // labelOreOwnedValue
            // 
            this.labelOreOwnedValue.AutoSize = true;
            this.labelOreOwnedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelOreOwnedValue.Location = new System.Drawing.Point(42, 20);
            this.labelOreOwnedValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOreOwnedValue.Name = "labelOreOwnedValue";
            this.labelOreOwnedValue.Size = new System.Drawing.Size(27, 13);
            this.labelOreOwnedValue.TabIndex = 14;
            this.labelOreOwnedValue.Text = "num";
            // 
            // labelAgeOwned
            // 
            this.labelAgeOwned.AutoSize = true;
            this.labelAgeOwned.Location = new System.Drawing.Point(3, 40);
            this.labelAgeOwned.Name = "labelAgeOwned";
            this.labelAgeOwned.Size = new System.Drawing.Size(29, 13);
            this.labelAgeOwned.TabIndex = 15;
            this.labelAgeOwned.Text = "Age:";
            // 
            // labelAgeOwnedValue
            // 
            this.labelAgeOwnedValue.AutoSize = true;
            this.labelAgeOwnedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelAgeOwnedValue.Location = new System.Drawing.Point(42, 40);
            this.labelAgeOwnedValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAgeOwnedValue.Name = "labelAgeOwnedValue";
            this.labelAgeOwnedValue.Size = new System.Drawing.Size(27, 13);
            this.labelAgeOwnedValue.TabIndex = 15;
            this.labelAgeOwnedValue.Text = "num";
            // 
            // labelFoodOwnedValue
            // 
            this.labelFoodOwnedValue.AutoSize = true;
            this.labelFoodOwnedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelFoodOwnedValue.Location = new System.Drawing.Point(42, 0);
            this.labelFoodOwnedValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFoodOwnedValue.Name = "labelFoodOwnedValue";
            this.labelFoodOwnedValue.Size = new System.Drawing.Size(27, 13);
            this.labelFoodOwnedValue.TabIndex = 13;
            this.labelFoodOwnedValue.Text = "num";
            // 
            // labelFoodOwned
            // 
            this.labelFoodOwned.AutoSize = true;
            this.labelFoodOwned.Location = new System.Drawing.Point(3, 0);
            this.labelFoodOwned.Name = "labelFoodOwned";
            this.labelFoodOwned.Size = new System.Drawing.Size(34, 13);
            this.labelFoodOwned.TabIndex = 12;
            this.labelFoodOwned.Text = "Food:";
            // 
            // labelSkills
            // 
            this.labelSkills.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSkills.AutoSize = true;
            this.labelSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSkills.Location = new System.Drawing.Point(82, 100);
            this.labelSkills.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSkills.Name = "labelSkills";
            this.labelSkills.Size = new System.Drawing.Size(40, 17);
            this.labelSkills.TabIndex = 10;
            this.labelSkills.Text = "Skills";
            // 
            // tableLayoutPanelSkills
            // 
            this.tableLayoutPanelSkills.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanelSkills.AutoSize = true;
            this.tableLayoutPanelSkills.ColumnCount = 2;
            this.tableLayoutPanelSkills.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelSkills.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelSkills.Controls.Add(this.labelSkillMining, 0, 1);
            this.tableLayoutPanelSkills.Controls.Add(this.labelSkillFarming, 0, 0);
            this.tableLayoutPanelSkills.Controls.Add(this.labelSkillMiningValue, 1, 1);
            this.tableLayoutPanelSkills.Controls.Add(this.labelSkillFighting, 0, 2);
            this.tableLayoutPanelSkills.Controls.Add(this.labelSkillFarmingValue, 1, 0);
            this.tableLayoutPanelSkills.Controls.Add(this.labelSkillFightingValue, 1, 2);
            this.tableLayoutPanelSkills.Location = new System.Drawing.Point(60, 120);
            this.tableLayoutPanelSkills.Name = "tableLayoutPanelSkills";
            this.tableLayoutPanelSkills.RowCount = 3;
            this.tableLayoutPanelSkills.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelSkills.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelSkills.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelSkills.Size = new System.Drawing.Size(84, 60);
            this.tableLayoutPanelSkills.TabIndex = 11;
            // 
            // labelSkillMining
            // 
            this.labelSkillMining.AutoSize = true;
            this.labelSkillMining.Location = new System.Drawing.Point(3, 20);
            this.labelSkillMining.Name = "labelSkillMining";
            this.labelSkillMining.Size = new System.Drawing.Size(38, 13);
            this.labelSkillMining.TabIndex = 14;
            this.labelSkillMining.Text = "Mining";
            // 
            // labelSkillFarming
            // 
            this.labelSkillFarming.AutoSize = true;
            this.labelSkillFarming.Location = new System.Drawing.Point(3, 0);
            this.labelSkillFarming.Name = "labelSkillFarming";
            this.labelSkillFarming.Size = new System.Drawing.Size(47, 13);
            this.labelSkillFarming.TabIndex = 12;
            this.labelSkillFarming.Text = "Farming:";
            // 
            // labelSkillMiningValue
            // 
            this.labelSkillMiningValue.AutoSize = true;
            this.labelSkillMiningValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelSkillMiningValue.Location = new System.Drawing.Point(55, 20);
            this.labelSkillMiningValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSkillMiningValue.Name = "labelSkillMiningValue";
            this.labelSkillMiningValue.Size = new System.Drawing.Size(27, 13);
            this.labelSkillMiningValue.TabIndex = 14;
            this.labelSkillMiningValue.Text = "num";
            // 
            // labelSkillFighting
            // 
            this.labelSkillFighting.AutoSize = true;
            this.labelSkillFighting.Location = new System.Drawing.Point(3, 40);
            this.labelSkillFighting.Name = "labelSkillFighting";
            this.labelSkillFighting.Size = new System.Drawing.Size(44, 13);
            this.labelSkillFighting.TabIndex = 15;
            this.labelSkillFighting.Text = "Fighting";
            // 
            // labelSkillFarmingValue
            // 
            this.labelSkillFarmingValue.AutoSize = true;
            this.labelSkillFarmingValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelSkillFarmingValue.Location = new System.Drawing.Point(55, 0);
            this.labelSkillFarmingValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSkillFarmingValue.Name = "labelSkillFarmingValue";
            this.labelSkillFarmingValue.Size = new System.Drawing.Size(27, 13);
            this.labelSkillFarmingValue.TabIndex = 13;
            this.labelSkillFarmingValue.Text = "num";
            // 
            // labelSkillFightingValue
            // 
            this.labelSkillFightingValue.AutoSize = true;
            this.labelSkillFightingValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelSkillFightingValue.Location = new System.Drawing.Point(55, 40);
            this.labelSkillFightingValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSkillFightingValue.Name = "labelSkillFightingValue";
            this.labelSkillFightingValue.Size = new System.Drawing.Size(27, 13);
            this.labelSkillFightingValue.TabIndex = 15;
            this.labelSkillFightingValue.Text = "num";
            // 
            // labelThoughts
            // 
            this.labelThoughts.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelThoughts.AutoSize = true;
            this.labelThoughts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThoughts.Location = new System.Drawing.Point(68, 183);
            this.labelThoughts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelThoughts.Name = "labelThoughts";
            this.labelThoughts.Size = new System.Drawing.Size(68, 17);
            this.labelThoughts.TabIndex = 8;
            this.labelThoughts.Text = "Thoughts";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.labelActivity, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelActivityValue, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(40, 203);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(124, 13);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // labelActivity
            // 
            this.labelActivity.AutoSize = true;
            this.labelActivity.Location = new System.Drawing.Point(3, 0);
            this.labelActivity.Name = "labelActivity";
            this.labelActivity.Size = new System.Drawing.Size(44, 13);
            this.labelActivity.TabIndex = 0;
            this.labelActivity.Text = "Activity:";
            // 
            // labelActivityValue
            // 
            this.labelActivityValue.AutoSize = true;
            this.labelActivityValue.Location = new System.Drawing.Point(53, 0);
            this.labelActivityValue.Name = "labelActivityValue";
            this.labelActivityValue.Size = new System.Drawing.Size(68, 13);
            this.labelActivityValue.TabIndex = 1;
            this.labelActivityValue.Text = "ActivityValue";
            // 
            // tableLayoutPanelNeuralNetwork
            // 
            this.tableLayoutPanelNeuralNetwork.AutoSize = true;
            this.tableLayoutPanelNeuralNetwork.ColumnCount = 4;
            this.tableLayoutPanelNeuralNetwork.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelNeuralNetwork.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelNeuralNetwork.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelNeuralNetwork.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelNeuralNetwork.Controls.Add(this.labelLootProspect, 0, 12);
            this.tableLayoutPanelNeuralNetwork.Controls.Add(this.labelFoodAreaValue, 1, 3);
            this.tableLayoutPanelNeuralNetwork.Controls.Add(this.labelFoodMoveValue, 3, 2);
            this.tableLayoutPanelNeuralNetwork.Controls.Add(this.labelFoodTileValue, 1, 2);
            this.tableLayoutPanelNeuralNetwork.Controls.Add(this.labelFoodSelf, 0, 1);
            this.tableLayoutPanelNeuralNetwork.Controls.Add(this.labelFarm, 2, 1);
            this.tableLayoutPanelNeuralNetwork.Controls.Add(this.labelFoodSelfValue, 1, 1);
            this.tableLayoutPanelNeuralNetwork.Controls.Add(this.labelFarmValue, 3, 1);
            this.tableLayoutPanelNeuralNetwork.Controls.Add(this.labelCreatureOutputs, 2, 0);
            this.tableLayoutPanelNeuralNetwork.Controls.Add(this.labelCreatureInputs, 0, 0);
            this.tableLayoutPanelNeuralNetwork.Controls.Add(this.labelFoodTile, 0, 2);
            this.tableLayoutPanelNeuralNetwork.Controls.Add(this.labelFoodArea, 0, 3);
            this.tableLayoutPanelNeuralNetwork.Controls.Add(this.labelOrePrice, 0, 9);
            this.tableLayoutPanelNeuralNetwork.Controls.Add(this.labelOrePriceValue, 1, 9);
            this.tableLayoutPanelNeuralNetwork.Controls.Add(this.labelFoodPriceValue, 1, 8);
            this.tableLayoutPanelNeuralNetwork.Controls.Add(this.labelFoodPrice, 0, 8);
            this.tableLayoutPanelNeuralNetwork.Controls.Add(this.labelOreAreaValue, 1, 7);
            this.tableLayoutPanelNeuralNetwork.Controls.Add(this.labelOreArea, 0, 7);
            this.tableLayoutPanelNeuralNetwork.Controls.Add(this.labelOreTile, 0, 6);
            this.tableLayoutPanelNeuralNetwork.Controls.Add(this.labelOreTileValue, 1, 6);
            this.tableLayoutPanelNeuralNetwork.Controls.Add(this.labelOreSelfValue, 1, 5);
            this.tableLayoutPanelNeuralNetwork.Controls.Add(this.labelOreSelf, 0, 5);
            this.tableLayoutPanelNeuralNetwork.Controls.Add(this.labelFoodProperty, 0, 4);
            this.tableLayoutPanelNeuralNetwork.Controls.Add(this.labelFoodPropertyValue, 1, 4);
            this.tableLayoutPanelNeuralNetwork.Controls.Add(this.labelBuyLand, 2, 11);
            this.tableLayoutPanelNeuralNetwork.Controls.Add(this.labelBuyLandValue, 3, 11);
            this.tableLayoutPanelNeuralNetwork.Controls.Add(this.labelTrade, 2, 10);
            this.tableLayoutPanelNeuralNetwork.Controls.Add(this.labelTradeValue, 3, 10);
            this.tableLayoutPanelNeuralNetwork.Controls.Add(this.labelOreCost, 2, 9);
            this.tableLayoutPanelNeuralNetwork.Controls.Add(this.labelFoodCost, 2, 8);
            this.tableLayoutPanelNeuralNetwork.Controls.Add(this.labelOreCostValue, 3, 9);
            this.tableLayoutPanelNeuralNetwork.Controls.Add(this.labelFoodCostValue, 3, 8);
            this.tableLayoutPanelNeuralNetwork.Controls.Add(this.labelMine, 2, 5);
            this.tableLayoutPanelNeuralNetwork.Controls.Add(this.labelMineValue, 3, 5);
            this.tableLayoutPanelNeuralNetwork.Controls.Add(this.labelFoodMove, 2, 2);
            this.tableLayoutPanelNeuralNetwork.Controls.Add(this.labelOreMove, 2, 6);
            this.tableLayoutPanelNeuralNetwork.Controls.Add(this.labelOreMoveValue, 3, 6);
            this.tableLayoutPanelNeuralNetwork.Controls.Add(this.labelMoveProperty, 2, 4);
            this.tableLayoutPanelNeuralNetwork.Controls.Add(this.labelMovePropertyValue, 3, 4);
            this.tableLayoutPanelNeuralNetwork.Controls.Add(this.labelLootProspectValue, 1, 12);
            this.tableLayoutPanelNeuralNetwork.Controls.Add(this.labelLoot, 2, 12);
            this.tableLayoutPanelNeuralNetwork.Controls.Add(this.labelLootValue, 3, 12);
            this.tableLayoutPanelNeuralNetwork.Location = new System.Drawing.Point(3, 222);
            this.tableLayoutPanelNeuralNetwork.Name = "tableLayoutPanelNeuralNetwork";
            this.tableLayoutPanelNeuralNetwork.RowCount = 13;
            this.tableLayoutPanelNeuralNetwork.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelNeuralNetwork.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelNeuralNetwork.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelNeuralNetwork.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelNeuralNetwork.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelNeuralNetwork.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelNeuralNetwork.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelNeuralNetwork.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelNeuralNetwork.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelNeuralNetwork.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelNeuralNetwork.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelNeuralNetwork.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelNeuralNetwork.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelNeuralNetwork.Size = new System.Drawing.Size(198, 260);
            this.tableLayoutPanelNeuralNetwork.TabIndex = 5;
            // 
            // labelLootProspect
            // 
            this.labelLootProspect.AutoSize = true;
            this.labelLootProspect.Location = new System.Drawing.Point(3, 240);
            this.labelLootProspect.Name = "labelLootProspect";
            this.labelLootProspect.Size = new System.Drawing.Size(31, 13);
            this.labelLootProspect.TabIndex = 42;
            this.labelLootProspect.Text = "Loot:";
            // 
            // labelFoodAreaValue
            // 
            this.labelFoodAreaValue.AutoSize = true;
            this.labelFoodAreaValue.Location = new System.Drawing.Point(70, 60);
            this.labelFoodAreaValue.Name = "labelFoodAreaValue";
            this.labelFoodAreaValue.Size = new System.Drawing.Size(27, 13);
            this.labelFoodAreaValue.TabIndex = 16;
            this.labelFoodAreaValue.Text = "num";
            // 
            // labelFoodMoveValue
            // 
            this.labelFoodMoveValue.AutoSize = true;
            this.labelFoodMoveValue.Location = new System.Drawing.Point(168, 40);
            this.labelFoodMoveValue.Name = "labelFoodMoveValue";
            this.labelFoodMoveValue.Size = new System.Drawing.Size(27, 13);
            this.labelFoodMoveValue.TabIndex = 15;
            this.labelFoodMoveValue.Text = "num";
            // 
            // labelFoodTileValue
            // 
            this.labelFoodTileValue.AutoSize = true;
            this.labelFoodTileValue.Location = new System.Drawing.Point(70, 40);
            this.labelFoodTileValue.Name = "labelFoodTileValue";
            this.labelFoodTileValue.Size = new System.Drawing.Size(27, 13);
            this.labelFoodTileValue.TabIndex = 13;
            this.labelFoodTileValue.Text = "num";
            // 
            // labelFoodSelf
            // 
            this.labelFoodSelf.AutoSize = true;
            this.labelFoodSelf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelFoodSelf.Location = new System.Drawing.Point(2, 20);
            this.labelFoodSelf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFoodSelf.Name = "labelFoodSelf";
            this.labelFoodSelf.Size = new System.Drawing.Size(59, 13);
            this.labelFoodSelf.TabIndex = 10;
            this.labelFoodSelf.Text = "Food Own:";
            // 
            // labelFarm
            // 
            this.labelFarm.AutoSize = true;
            this.labelFarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelFarm.Location = new System.Drawing.Point(102, 20);
            this.labelFarm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFarm.Name = "labelFarm";
            this.labelFarm.Size = new System.Drawing.Size(33, 13);
            this.labelFarm.TabIndex = 9;
            this.labelFarm.Text = "Farm:";
            // 
            // labelFoodSelfValue
            // 
            this.labelFoodSelfValue.AutoSize = true;
            this.labelFoodSelfValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelFoodSelfValue.Location = new System.Drawing.Point(69, 20);
            this.labelFoodSelfValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFoodSelfValue.Name = "labelFoodSelfValue";
            this.labelFoodSelfValue.Size = new System.Drawing.Size(27, 13);
            this.labelFoodSelfValue.TabIndex = 8;
            this.labelFoodSelfValue.Text = "num";
            // 
            // labelFarmValue
            // 
            this.labelFarmValue.AutoSize = true;
            this.labelFarmValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelFarmValue.Location = new System.Drawing.Point(167, 20);
            this.labelFarmValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFarmValue.Name = "labelFarmValue";
            this.labelFarmValue.Size = new System.Drawing.Size(27, 13);
            this.labelFarmValue.TabIndex = 7;
            this.labelFarmValue.Text = "num";
            // 
            // labelCreatureOutputs
            // 
            this.labelCreatureOutputs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCreatureOutputs.AutoSize = true;
            this.tableLayoutPanelNeuralNetwork.SetColumnSpan(this.labelCreatureOutputs, 2);
            this.labelCreatureOutputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreatureOutputs.Location = new System.Drawing.Point(120, 0);
            this.labelCreatureOutputs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCreatureOutputs.Name = "labelCreatureOutputs";
            this.labelCreatureOutputs.Size = new System.Drawing.Size(58, 17);
            this.labelCreatureOutputs.TabIndex = 6;
            this.labelCreatureOutputs.Text = "Outputs";
            // 
            // labelCreatureInputs
            // 
            this.labelCreatureInputs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCreatureInputs.AutoSize = true;
            this.tableLayoutPanelNeuralNetwork.SetColumnSpan(this.labelCreatureInputs, 2);
            this.labelCreatureInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreatureInputs.Location = new System.Drawing.Point(27, 0);
            this.labelCreatureInputs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCreatureInputs.Name = "labelCreatureInputs";
            this.labelCreatureInputs.Size = new System.Drawing.Size(46, 17);
            this.labelCreatureInputs.TabIndex = 5;
            this.labelCreatureInputs.Text = "Inputs";
            // 
            // labelFoodTile
            // 
            this.labelFoodTile.AutoSize = true;
            this.labelFoodTile.Location = new System.Drawing.Point(3, 40);
            this.labelFoodTile.Name = "labelFoodTile";
            this.labelFoodTile.Size = new System.Drawing.Size(54, 13);
            this.labelFoodTile.TabIndex = 11;
            this.labelFoodTile.Text = "Food Tile:";
            // 
            // labelFoodArea
            // 
            this.labelFoodArea.AutoSize = true;
            this.labelFoodArea.Location = new System.Drawing.Point(3, 60);
            this.labelFoodArea.Name = "labelFoodArea";
            this.labelFoodArea.Size = new System.Drawing.Size(59, 13);
            this.labelFoodArea.TabIndex = 12;
            this.labelFoodArea.Text = "Food Area:";
            // 
            // labelOrePrice
            // 
            this.labelOrePrice.AutoSize = true;
            this.labelOrePrice.Location = new System.Drawing.Point(3, 180);
            this.labelOrePrice.Name = "labelOrePrice";
            this.labelOrePrice.Size = new System.Drawing.Size(54, 13);
            this.labelOrePrice.TabIndex = 32;
            this.labelOrePrice.Text = "Ore Price:";
            // 
            // labelOrePriceValue
            // 
            this.labelOrePriceValue.AutoSize = true;
            this.labelOrePriceValue.Location = new System.Drawing.Point(70, 180);
            this.labelOrePriceValue.Name = "labelOrePriceValue";
            this.labelOrePriceValue.Size = new System.Drawing.Size(27, 13);
            this.labelOrePriceValue.TabIndex = 33;
            this.labelOrePriceValue.Text = "num";
            // 
            // labelFoodPriceValue
            // 
            this.labelFoodPriceValue.AutoSize = true;
            this.labelFoodPriceValue.Location = new System.Drawing.Point(70, 160);
            this.labelFoodPriceValue.Name = "labelFoodPriceValue";
            this.labelFoodPriceValue.Size = new System.Drawing.Size(27, 13);
            this.labelFoodPriceValue.TabIndex = 31;
            this.labelFoodPriceValue.Text = "num";
            // 
            // labelFoodPrice
            // 
            this.labelFoodPrice.AutoSize = true;
            this.labelFoodPrice.Location = new System.Drawing.Point(3, 160);
            this.labelFoodPrice.Name = "labelFoodPrice";
            this.labelFoodPrice.Size = new System.Drawing.Size(61, 13);
            this.labelFoodPrice.TabIndex = 30;
            this.labelFoodPrice.Text = "Food Price:";
            // 
            // labelOreAreaValue
            // 
            this.labelOreAreaValue.AutoSize = true;
            this.labelOreAreaValue.Location = new System.Drawing.Point(70, 140);
            this.labelOreAreaValue.Name = "labelOreAreaValue";
            this.labelOreAreaValue.Size = new System.Drawing.Size(27, 13);
            this.labelOreAreaValue.TabIndex = 25;
            this.labelOreAreaValue.Text = "num";
            // 
            // labelOreArea
            // 
            this.labelOreArea.AutoSize = true;
            this.labelOreArea.Location = new System.Drawing.Point(3, 140);
            this.labelOreArea.Name = "labelOreArea";
            this.labelOreArea.Size = new System.Drawing.Size(52, 13);
            this.labelOreArea.TabIndex = 27;
            this.labelOreArea.Text = "Ore Area:";
            // 
            // labelOreTile
            // 
            this.labelOreTile.AutoSize = true;
            this.labelOreTile.Location = new System.Drawing.Point(3, 120);
            this.labelOreTile.Name = "labelOreTile";
            this.labelOreTile.Size = new System.Drawing.Size(47, 13);
            this.labelOreTile.TabIndex = 23;
            this.labelOreTile.Text = "Ore Tile:";
            // 
            // labelOreTileValue
            // 
            this.labelOreTileValue.AutoSize = true;
            this.labelOreTileValue.Location = new System.Drawing.Point(70, 120);
            this.labelOreTileValue.Name = "labelOreTileValue";
            this.labelOreTileValue.Size = new System.Drawing.Size(27, 13);
            this.labelOreTileValue.TabIndex = 24;
            this.labelOreTileValue.Text = "num";
            // 
            // labelOreSelfValue
            // 
            this.labelOreSelfValue.AutoSize = true;
            this.labelOreSelfValue.Location = new System.Drawing.Point(70, 100);
            this.labelOreSelfValue.Name = "labelOreSelfValue";
            this.labelOreSelfValue.Size = new System.Drawing.Size(27, 13);
            this.labelOreSelfValue.TabIndex = 20;
            this.labelOreSelfValue.Text = "num";
            // 
            // labelOreSelf
            // 
            this.labelOreSelf.AutoSize = true;
            this.labelOreSelf.Location = new System.Drawing.Point(3, 100);
            this.labelOreSelf.Name = "labelOreSelf";
            this.labelOreSelf.Size = new System.Drawing.Size(52, 13);
            this.labelOreSelf.TabIndex = 19;
            this.labelOreSelf.Text = "Ore Own:";
            // 
            // labelFoodProperty
            // 
            this.labelFoodProperty.AutoSize = true;
            this.labelFoodProperty.Location = new System.Drawing.Point(3, 80);
            this.labelFoodProperty.Name = "labelFoodProperty";
            this.labelFoodProperty.Size = new System.Drawing.Size(56, 13);
            this.labelFoodProperty.TabIndex = 38;
            this.labelFoodProperty.Text = "FoodProp:";
            // 
            // labelFoodPropertyValue
            // 
            this.labelFoodPropertyValue.AutoSize = true;
            this.labelFoodPropertyValue.Location = new System.Drawing.Point(70, 80);
            this.labelFoodPropertyValue.Name = "labelFoodPropertyValue";
            this.labelFoodPropertyValue.Size = new System.Drawing.Size(27, 13);
            this.labelFoodPropertyValue.TabIndex = 39;
            this.labelFoodPropertyValue.Text = "num";
            // 
            // labelBuyLand
            // 
            this.labelBuyLand.AutoSize = true;
            this.labelBuyLand.Location = new System.Drawing.Point(103, 220);
            this.labelBuyLand.Name = "labelBuyLand";
            this.labelBuyLand.Size = new System.Drawing.Size(52, 13);
            this.labelBuyLand.TabIndex = 36;
            this.labelBuyLand.Text = "BuyLand:";
            // 
            // labelBuyLandValue
            // 
            this.labelBuyLandValue.AutoSize = true;
            this.labelBuyLandValue.Location = new System.Drawing.Point(168, 220);
            this.labelBuyLandValue.Name = "labelBuyLandValue";
            this.labelBuyLandValue.Size = new System.Drawing.Size(27, 13);
            this.labelBuyLandValue.TabIndex = 37;
            this.labelBuyLandValue.Text = "num";
            // 
            // labelTrade
            // 
            this.labelTrade.AutoSize = true;
            this.labelTrade.Location = new System.Drawing.Point(103, 200);
            this.labelTrade.Name = "labelTrade";
            this.labelTrade.Size = new System.Drawing.Size(38, 13);
            this.labelTrade.TabIndex = 34;
            this.labelTrade.Text = "Trade:";
            // 
            // labelTradeValue
            // 
            this.labelTradeValue.AutoSize = true;
            this.labelTradeValue.Location = new System.Drawing.Point(168, 200);
            this.labelTradeValue.Name = "labelTradeValue";
            this.labelTradeValue.Size = new System.Drawing.Size(27, 13);
            this.labelTradeValue.TabIndex = 35;
            this.labelTradeValue.Text = "num";
            // 
            // labelOreCost
            // 
            this.labelOreCost.AutoSize = true;
            this.labelOreCost.Location = new System.Drawing.Point(103, 180);
            this.labelOreCost.Name = "labelOreCost";
            this.labelOreCost.Size = new System.Drawing.Size(51, 13);
            this.labelOreCost.TabIndex = 28;
            this.labelOreCost.Text = "Ore Cost:";
            // 
            // labelFoodCost
            // 
            this.labelFoodCost.AutoSize = true;
            this.labelFoodCost.Location = new System.Drawing.Point(103, 160);
            this.labelFoodCost.Name = "labelFoodCost";
            this.labelFoodCost.Size = new System.Drawing.Size(58, 13);
            this.labelFoodCost.TabIndex = 25;
            this.labelFoodCost.Text = "Food Cost:";
            // 
            // labelOreCostValue
            // 
            this.labelOreCostValue.AutoSize = true;
            this.labelOreCostValue.Location = new System.Drawing.Point(168, 180);
            this.labelOreCostValue.Name = "labelOreCostValue";
            this.labelOreCostValue.Size = new System.Drawing.Size(27, 13);
            this.labelOreCostValue.TabIndex = 29;
            this.labelOreCostValue.Text = "num";
            // 
            // labelFoodCostValue
            // 
            this.labelFoodCostValue.AutoSize = true;
            this.labelFoodCostValue.Location = new System.Drawing.Point(168, 160);
            this.labelFoodCostValue.Name = "labelFoodCostValue";
            this.labelFoodCostValue.Size = new System.Drawing.Size(27, 13);
            this.labelFoodCostValue.TabIndex = 26;
            this.labelFoodCostValue.Text = "num";
            // 
            // labelMine
            // 
            this.labelMine.AutoSize = true;
            this.labelMine.Location = new System.Drawing.Point(103, 100);
            this.labelMine.Name = "labelMine";
            this.labelMine.Size = new System.Drawing.Size(33, 13);
            this.labelMine.TabIndex = 17;
            this.labelMine.Text = "Mine:";
            // 
            // labelMineValue
            // 
            this.labelMineValue.AutoSize = true;
            this.labelMineValue.Location = new System.Drawing.Point(168, 100);
            this.labelMineValue.Name = "labelMineValue";
            this.labelMineValue.Size = new System.Drawing.Size(27, 13);
            this.labelMineValue.TabIndex = 18;
            this.labelMineValue.Text = "num";
            // 
            // labelFoodMove
            // 
            this.labelFoodMove.AutoSize = true;
            this.labelFoodMove.Location = new System.Drawing.Point(103, 40);
            this.labelFoodMove.Name = "labelFoodMove";
            this.labelFoodMove.Size = new System.Drawing.Size(54, 13);
            this.labelFoodMove.TabIndex = 14;
            this.labelFoodMove.Text = "Food Get:";
            // 
            // labelOreMove
            // 
            this.labelOreMove.AutoSize = true;
            this.labelOreMove.Location = new System.Drawing.Point(103, 120);
            this.labelOreMove.Name = "labelOreMove";
            this.labelOreMove.Size = new System.Drawing.Size(47, 13);
            this.labelOreMove.TabIndex = 21;
            this.labelOreMove.Text = "Ore Get:";
            // 
            // labelOreMoveValue
            // 
            this.labelOreMoveValue.AutoSize = true;
            this.labelOreMoveValue.Location = new System.Drawing.Point(168, 120);
            this.labelOreMoveValue.Name = "labelOreMoveValue";
            this.labelOreMoveValue.Size = new System.Drawing.Size(27, 13);
            this.labelOreMoveValue.TabIndex = 22;
            this.labelOreMoveValue.Text = "num";
            // 
            // labelMoveProperty
            // 
            this.labelMoveProperty.AutoSize = true;
            this.labelMoveProperty.Location = new System.Drawing.Point(103, 80);
            this.labelMoveProperty.Name = "labelMoveProperty";
            this.labelMoveProperty.Size = new System.Drawing.Size(59, 13);
            this.labelMoveProperty.TabIndex = 40;
            this.labelMoveProperty.Text = "MoveProp:";
            // 
            // labelMovePropertyValue
            // 
            this.labelMovePropertyValue.AutoSize = true;
            this.labelMovePropertyValue.Location = new System.Drawing.Point(168, 80);
            this.labelMovePropertyValue.Name = "labelMovePropertyValue";
            this.labelMovePropertyValue.Size = new System.Drawing.Size(27, 13);
            this.labelMovePropertyValue.TabIndex = 41;
            this.labelMovePropertyValue.Text = "num";
            // 
            // labelLootProspectValue
            // 
            this.labelLootProspectValue.AutoSize = true;
            this.labelLootProspectValue.Location = new System.Drawing.Point(70, 240);
            this.labelLootProspectValue.Name = "labelLootProspectValue";
            this.labelLootProspectValue.Size = new System.Drawing.Size(27, 13);
            this.labelLootProspectValue.TabIndex = 43;
            this.labelLootProspectValue.Text = "num";
            // 
            // labelLoot
            // 
            this.labelLoot.AutoSize = true;
            this.labelLoot.Location = new System.Drawing.Point(103, 240);
            this.labelLoot.Name = "labelLoot";
            this.labelLoot.Size = new System.Drawing.Size(31, 13);
            this.labelLoot.TabIndex = 44;
            this.labelLoot.Text = "Loot:";
            // 
            // labelLootValue
            // 
            this.labelLootValue.AutoSize = true;
            this.labelLootValue.Location = new System.Drawing.Point(168, 240);
            this.labelLootValue.Name = "labelLootValue";
            this.labelLootValue.Size = new System.Drawing.Size(27, 13);
            this.labelLootValue.TabIndex = 45;
            this.labelLootValue.Text = "num";
            // 
            // flowLayoutPanelGenerateMap
            // 
            this.flowLayoutPanelGenerateMap.AutoSize = true;
            this.flowLayoutPanelGenerateMap.Controls.Add(this.labelGenerateMap);
            this.flowLayoutPanelGenerateMap.Controls.Add(this.tableLayoutPanelMapSize);
            this.flowLayoutPanelGenerateMap.Controls.Add(this.tableLayoutPanelMapProperties);
            this.flowLayoutPanelGenerateMap.Controls.Add(this.buttonGenerateMap);
            this.flowLayoutPanelGenerateMap.Controls.Add(this.labelMapParameters);
            this.flowLayoutPanelGenerateMap.Controls.Add(this.tableLayoutPanel4);
            this.flowLayoutPanelGenerateMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelGenerateMap.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelGenerateMap.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelGenerateMap.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelGenerateMap.Name = "flowLayoutPanelGenerateMap";
            this.flowLayoutPanelGenerateMap.Size = new System.Drawing.Size(200, 676);
            this.flowLayoutPanelGenerateMap.TabIndex = 0;
            // 
            // labelGenerateMap
            // 
            this.labelGenerateMap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelGenerateMap.AutoSize = true;
            this.labelGenerateMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenerateMap.Location = new System.Drawing.Point(50, 0);
            this.labelGenerateMap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGenerateMap.Name = "labelGenerateMap";
            this.labelGenerateMap.Size = new System.Drawing.Size(99, 17);
            this.labelGenerateMap.TabIndex = 2;
            this.labelGenerateMap.Text = "Generate Map";
            // 
            // tableLayoutPanelMapSize
            // 
            this.tableLayoutPanelMapSize.AutoSize = true;
            this.tableLayoutPanelMapSize.ColumnCount = 2;
            this.tableLayoutPanelMapSize.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelMapSize.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMapSize.Controls.Add(this.labelMapWidth, 0, 0);
            this.tableLayoutPanelMapSize.Controls.Add(this.textBoxMapWidth, 1, 0);
            this.tableLayoutPanelMapSize.Controls.Add(this.textBoxMapHeight, 1, 1);
            this.tableLayoutPanelMapSize.Controls.Add(this.labelMapHeight, 0, 1);
            this.tableLayoutPanelMapSize.Controls.Add(this.labelCreatureCount, 0, 2);
            this.tableLayoutPanelMapSize.Controls.Add(this.textBoxCreatureCount, 1, 2);
            this.tableLayoutPanelMapSize.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelMapSize.Location = new System.Drawing.Point(2, 19);
            this.tableLayoutPanelMapSize.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanelMapSize.Name = "tableLayoutPanelMapSize";
            this.tableLayoutPanelMapSize.RowCount = 3;
            this.tableLayoutPanelMapSize.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMapSize.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMapSize.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMapSize.Size = new System.Drawing.Size(196, 68);
            this.tableLayoutPanelMapSize.TabIndex = 0;
            // 
            // labelMapWidth
            // 
            this.labelMapWidth.AutoSize = true;
            this.labelMapWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMapWidth.Location = new System.Drawing.Point(2, 0);
            this.labelMapWidth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMapWidth.Name = "labelMapWidth";
            this.labelMapWidth.Size = new System.Drawing.Size(62, 24);
            this.labelMapWidth.TabIndex = 0;
            this.labelMapWidth.Text = "Map Width";
            // 
            // textBoxMapWidth
            // 
            this.textBoxMapWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMapWidth.Location = new System.Drawing.Point(68, 2);
            this.textBoxMapWidth.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMapWidth.MaxLength = 5;
            this.textBoxMapWidth.Name = "textBoxMapWidth";
            this.textBoxMapWidth.Size = new System.Drawing.Size(126, 20);
            this.textBoxMapWidth.TabIndex = 1;
            this.textBoxMapWidth.Text = "300";
            this.textBoxMapWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxMapWidth.Enter += new System.EventHandler(this.textBoxMapWidth_Enter);
            this.textBoxMapWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMapWidth_KeyPress);
            this.textBoxMapWidth.MouseEnter += new System.EventHandler(this.textBoxMapWidth_MouseEnter);
            // 
            // textBoxMapHeight
            // 
            this.textBoxMapHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMapHeight.Location = new System.Drawing.Point(68, 26);
            this.textBoxMapHeight.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMapHeight.MaxLength = 5;
            this.textBoxMapHeight.Name = "textBoxMapHeight";
            this.textBoxMapHeight.Size = new System.Drawing.Size(126, 20);
            this.textBoxMapHeight.TabIndex = 3;
            this.textBoxMapHeight.Text = "300";
            this.textBoxMapHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxMapHeight.Enter += new System.EventHandler(this.textBoxMapHeight_Enter);
            this.textBoxMapHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMapHeight_KeyPress);
            this.textBoxMapHeight.MouseEnter += new System.EventHandler(this.textBoxMapHeight_MouseEnter);
            // 
            // labelMapHeight
            // 
            this.labelMapHeight.AutoSize = true;
            this.labelMapHeight.Location = new System.Drawing.Point(2, 24);
            this.labelMapHeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMapHeight.Name = "labelMapHeight";
            this.labelMapHeight.Size = new System.Drawing.Size(62, 13);
            this.labelMapHeight.TabIndex = 2;
            this.labelMapHeight.Text = "Map Height";
            // 
            // labelCreatureCount
            // 
            this.labelCreatureCount.AutoSize = true;
            this.labelCreatureCount.Location = new System.Drawing.Point(3, 48);
            this.labelCreatureCount.Name = "labelCreatureCount";
            this.labelCreatureCount.Size = new System.Drawing.Size(52, 13);
            this.labelCreatureCount.TabIndex = 4;
            this.labelCreatureCount.Text = "Creatures";
            // 
            // textBoxCreatureCount
            // 
            this.textBoxCreatureCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCreatureCount.Location = new System.Drawing.Point(69, 51);
            this.textBoxCreatureCount.MaxLength = 5;
            this.textBoxCreatureCount.Name = "textBoxCreatureCount";
            this.textBoxCreatureCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxCreatureCount.Size = new System.Drawing.Size(124, 20);
            this.textBoxCreatureCount.TabIndex = 4;
            this.textBoxCreatureCount.Text = "300";
            this.textBoxCreatureCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxCreatureCount.Enter += new System.EventHandler(this.textBoxCreatureCount_Enter);
            this.textBoxCreatureCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCreatureCount_KeyPress);
            this.textBoxCreatureCount.MouseEnter += new System.EventHandler(this.textBoxCreatureCount_MouseEnter);
            // 
            // tableLayoutPanelMapProperties
            // 
            this.tableLayoutPanelMapProperties.AutoSize = true;
            this.tableLayoutPanelMapProperties.ColumnCount = 3;
            this.tableLayoutPanelMapProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelMapProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelMapProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelMapProperties.Controls.Add(this.labelMapGoldPersistence, 0, 11);
            this.tableLayoutPanelMapProperties.Controls.Add(this.trackBarMapOreScale, 1, 5);
            this.tableLayoutPanelMapProperties.Controls.Add(this.labelMapFoodDensity, 0, 0);
            this.tableLayoutPanelMapProperties.Controls.Add(this.trackBarMapFoodDensity, 1, 0);
            this.tableLayoutPanelMapProperties.Controls.Add(this.labelMapFoodDensityValue, 2, 0);
            this.tableLayoutPanelMapProperties.Controls.Add(this.labelMapFoodOctaves, 0, 2);
            this.tableLayoutPanelMapProperties.Controls.Add(this.labelMapFoodScale, 0, 1);
            this.tableLayoutPanelMapProperties.Controls.Add(this.trackBarMapFoodOctaves, 1, 2);
            this.tableLayoutPanelMapProperties.Controls.Add(this.trackBarMapFoodScale, 1, 1);
            this.tableLayoutPanelMapProperties.Controls.Add(this.labelMapFoodOctavesValue, 2, 2);
            this.tableLayoutPanelMapProperties.Controls.Add(this.labelMapFoodScaleValue, 2, 1);
            this.tableLayoutPanelMapProperties.Controls.Add(this.trackBarMapGoldScale, 1, 9);
            this.tableLayoutPanelMapProperties.Controls.Add(this.labelMapGoldOctaves, 0, 10);
            this.tableLayoutPanelMapProperties.Controls.Add(this.labelMapGoldScale, 0, 9);
            this.tableLayoutPanelMapProperties.Controls.Add(this.labelMapGoldDensity, 0, 8);
            this.tableLayoutPanelMapProperties.Controls.Add(this.labelMapOreOctaves, 0, 6);
            this.tableLayoutPanelMapProperties.Controls.Add(this.labelMapOreScale, 0, 5);
            this.tableLayoutPanelMapProperties.Controls.Add(this.labelMapOreDensity, 0, 4);
            this.tableLayoutPanelMapProperties.Controls.Add(this.trackBarMapGoldOctaves, 1, 10);
            this.tableLayoutPanelMapProperties.Controls.Add(this.labelMapGoldOctavesValue, 2, 10);
            this.tableLayoutPanelMapProperties.Controls.Add(this.labelMapGoldScaleValue, 2, 9);
            this.tableLayoutPanelMapProperties.Controls.Add(this.trackBarMapGoldDensity, 1, 8);
            this.tableLayoutPanelMapProperties.Controls.Add(this.labelMapGoldDensityValue, 2, 8);
            this.tableLayoutPanelMapProperties.Controls.Add(this.trackBarMapOreOctaves, 1, 6);
            this.tableLayoutPanelMapProperties.Controls.Add(this.labelMapOreOctavesValue, 2, 6);
            this.tableLayoutPanelMapProperties.Controls.Add(this.labelMapOreScaleValue, 2, 5);
            this.tableLayoutPanelMapProperties.Controls.Add(this.trackBarMapOreDensity, 1, 4);
            this.tableLayoutPanelMapProperties.Controls.Add(this.labelMapOreDensityValue, 2, 4);
            this.tableLayoutPanelMapProperties.Controls.Add(this.labelMapFoodPersistence, 0, 3);
            this.tableLayoutPanelMapProperties.Controls.Add(this.trackBarMapFoodPersistence, 1, 3);
            this.tableLayoutPanelMapProperties.Controls.Add(this.labelMapFoodPersistenceValue, 2, 3);
            this.tableLayoutPanelMapProperties.Controls.Add(this.labelMapOrePersistence, 0, 7);
            this.tableLayoutPanelMapProperties.Controls.Add(this.labelMapGoldPersistenceValue, 2, 11);
            this.tableLayoutPanelMapProperties.Controls.Add(this.labelMapOrePersistenceValue, 2, 7);
            this.tableLayoutPanelMapProperties.Controls.Add(this.trackBarMapOrePersistence, 1, 7);
            this.tableLayoutPanelMapProperties.Controls.Add(this.trackBarMapGoldPersistence, 1, 11);
            this.tableLayoutPanelMapProperties.Location = new System.Drawing.Point(3, 92);
            this.tableLayoutPanelMapProperties.Name = "tableLayoutPanelMapProperties";
            this.tableLayoutPanelMapProperties.RowCount = 12;
            this.tableLayoutPanelMapProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMapProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMapProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMapProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMapProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMapProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMapProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMapProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMapProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMapProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMapProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMapProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMapProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMapProperties.Size = new System.Drawing.Size(194, 240);
            this.tableLayoutPanelMapProperties.TabIndex = 8;
            // 
            // labelMapGoldPersistence
            // 
            this.labelMapGoldPersistence.AutoSize = true;
            this.labelMapGoldPersistence.Location = new System.Drawing.Point(3, 220);
            this.labelMapGoldPersistence.Name = "labelMapGoldPersistence";
            this.labelMapGoldPersistence.Size = new System.Drawing.Size(65, 13);
            this.labelMapGoldPersistence.TabIndex = 31;
            this.labelMapGoldPersistence.Text = "Persistence:";
            // 
            // trackBarMapOreScale
            // 
            this.trackBarMapOreScale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarMapOreScale.LargeChange = 1;
            this.trackBarMapOreScale.Location = new System.Drawing.Point(74, 103);
            this.trackBarMapOreScale.Name = "trackBarMapOreScale";
            this.trackBarMapOreScale.Size = new System.Drawing.Size(84, 14);
            this.trackBarMapOreScale.TabIndex = 13;
            this.trackBarMapOreScale.Value = 5;
            this.trackBarMapOreScale.Scroll += new System.EventHandler(this.trackBarMapOreScale_Scroll);
            // 
            // labelMapFoodDensity
            // 
            this.labelMapFoodDensity.AutoSize = true;
            this.labelMapFoodDensity.Location = new System.Drawing.Point(3, 0);
            this.labelMapFoodDensity.Name = "labelMapFoodDensity";
            this.labelMapFoodDensity.Size = new System.Drawing.Size(34, 13);
            this.labelMapFoodDensity.TabIndex = 6;
            this.labelMapFoodDensity.Text = "Food:";
            // 
            // trackBarMapFoodDensity
            // 
            this.trackBarMapFoodDensity.LargeChange = 1;
            this.trackBarMapFoodDensity.Location = new System.Drawing.Point(74, 3);
            this.trackBarMapFoodDensity.Minimum = 1;
            this.trackBarMapFoodDensity.Name = "trackBarMapFoodDensity";
            this.trackBarMapFoodDensity.Size = new System.Drawing.Size(84, 14);
            this.trackBarMapFoodDensity.TabIndex = 8;
            this.trackBarMapFoodDensity.Value = 5;
            this.trackBarMapFoodDensity.Scroll += new System.EventHandler(this.trackBarMapFoodDensity_Scroll);
            // 
            // labelMapFoodDensityValue
            // 
            this.labelMapFoodDensityValue.AutoSize = true;
            this.labelMapFoodDensityValue.Location = new System.Drawing.Point(164, 0);
            this.labelMapFoodDensityValue.Name = "labelMapFoodDensityValue";
            this.labelMapFoodDensityValue.Size = new System.Drawing.Size(27, 13);
            this.labelMapFoodDensityValue.TabIndex = 7;
            this.labelMapFoodDensityValue.Text = "50%";
            // 
            // labelMapFoodOctaves
            // 
            this.labelMapFoodOctaves.AutoSize = true;
            this.labelMapFoodOctaves.Location = new System.Drawing.Point(3, 40);
            this.labelMapFoodOctaves.Name = "labelMapFoodOctaves";
            this.labelMapFoodOctaves.Size = new System.Drawing.Size(50, 13);
            this.labelMapFoodOctaves.TabIndex = 3;
            this.labelMapFoodOctaves.Text = "Octaves:";
            // 
            // labelMapFoodScale
            // 
            this.labelMapFoodScale.AutoSize = true;
            this.labelMapFoodScale.Location = new System.Drawing.Point(3, 20);
            this.labelMapFoodScale.Name = "labelMapFoodScale";
            this.labelMapFoodScale.Size = new System.Drawing.Size(37, 13);
            this.labelMapFoodScale.TabIndex = 0;
            this.labelMapFoodScale.Text = "Scale:";
            // 
            // trackBarMapFoodOctaves
            // 
            this.trackBarMapFoodOctaves.LargeChange = 1;
            this.trackBarMapFoodOctaves.Location = new System.Drawing.Point(74, 43);
            this.trackBarMapFoodOctaves.Maximum = 5;
            this.trackBarMapFoodOctaves.Minimum = 1;
            this.trackBarMapFoodOctaves.Name = "trackBarMapFoodOctaves";
            this.trackBarMapFoodOctaves.Size = new System.Drawing.Size(84, 14);
            this.trackBarMapFoodOctaves.TabIndex = 4;
            this.trackBarMapFoodOctaves.Value = 2;
            this.trackBarMapFoodOctaves.Scroll += new System.EventHandler(this.trackBarMapFoodOctaves_Scroll);
            // 
            // trackBarMapFoodScale
            // 
            this.trackBarMapFoodScale.LargeChange = 1;
            this.trackBarMapFoodScale.Location = new System.Drawing.Point(74, 23);
            this.trackBarMapFoodScale.Maximum = 9;
            this.trackBarMapFoodScale.Name = "trackBarMapFoodScale";
            this.trackBarMapFoodScale.Size = new System.Drawing.Size(84, 14);
            this.trackBarMapFoodScale.TabIndex = 1;
            this.trackBarMapFoodScale.Value = 5;
            this.trackBarMapFoodScale.Scroll += new System.EventHandler(this.trackBarMapFoodScale_Scroll);
            // 
            // labelMapFoodOctavesValue
            // 
            this.labelMapFoodOctavesValue.AutoSize = true;
            this.labelMapFoodOctavesValue.Location = new System.Drawing.Point(164, 40);
            this.labelMapFoodOctavesValue.Name = "labelMapFoodOctavesValue";
            this.labelMapFoodOctavesValue.Size = new System.Drawing.Size(13, 13);
            this.labelMapFoodOctavesValue.TabIndex = 5;
            this.labelMapFoodOctavesValue.Text = "1";
            // 
            // labelMapFoodScaleValue
            // 
            this.labelMapFoodScaleValue.AutoSize = true;
            this.labelMapFoodScaleValue.Location = new System.Drawing.Point(164, 20);
            this.labelMapFoodScaleValue.Name = "labelMapFoodScaleValue";
            this.labelMapFoodScaleValue.Size = new System.Drawing.Size(27, 13);
            this.labelMapFoodScaleValue.TabIndex = 2;
            this.labelMapFoodScaleValue.Text = "50%";
            // 
            // trackBarMapGoldScale
            // 
            this.trackBarMapGoldScale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarMapGoldScale.LargeChange = 1;
            this.trackBarMapGoldScale.Location = new System.Drawing.Point(74, 183);
            this.trackBarMapGoldScale.Name = "trackBarMapGoldScale";
            this.trackBarMapGoldScale.Size = new System.Drawing.Size(84, 14);
            this.trackBarMapGoldScale.TabIndex = 23;
            this.trackBarMapGoldScale.Value = 5;
            this.trackBarMapGoldScale.Scroll += new System.EventHandler(this.trackBarMapGoldScale_Scroll);
            // 
            // labelMapGoldOctaves
            // 
            this.labelMapGoldOctaves.AutoSize = true;
            this.labelMapGoldOctaves.Location = new System.Drawing.Point(3, 200);
            this.labelMapGoldOctaves.Name = "labelMapGoldOctaves";
            this.labelMapGoldOctaves.Size = new System.Drawing.Size(50, 13);
            this.labelMapGoldOctaves.TabIndex = 18;
            this.labelMapGoldOctaves.Text = "Octaves:";
            // 
            // labelMapGoldScale
            // 
            this.labelMapGoldScale.AutoSize = true;
            this.labelMapGoldScale.Location = new System.Drawing.Point(3, 180);
            this.labelMapGoldScale.Name = "labelMapGoldScale";
            this.labelMapGoldScale.Size = new System.Drawing.Size(37, 13);
            this.labelMapGoldScale.TabIndex = 16;
            this.labelMapGoldScale.Text = "Scale:";
            // 
            // labelMapGoldDensity
            // 
            this.labelMapGoldDensity.AutoSize = true;
            this.labelMapGoldDensity.Location = new System.Drawing.Point(3, 160);
            this.labelMapGoldDensity.Name = "labelMapGoldDensity";
            this.labelMapGoldDensity.Size = new System.Drawing.Size(32, 13);
            this.labelMapGoldDensity.TabIndex = 12;
            this.labelMapGoldDensity.Text = "Gold:";
            // 
            // labelMapOreOctaves
            // 
            this.labelMapOreOctaves.AutoSize = true;
            this.labelMapOreOctaves.Location = new System.Drawing.Point(3, 120);
            this.labelMapOreOctaves.Name = "labelMapOreOctaves";
            this.labelMapOreOctaves.Size = new System.Drawing.Size(50, 13);
            this.labelMapOreOctaves.TabIndex = 17;
            this.labelMapOreOctaves.Text = "Octaves:";
            // 
            // labelMapOreScale
            // 
            this.labelMapOreScale.AutoSize = true;
            this.labelMapOreScale.Location = new System.Drawing.Point(3, 100);
            this.labelMapOreScale.Name = "labelMapOreScale";
            this.labelMapOreScale.Size = new System.Drawing.Size(37, 13);
            this.labelMapOreScale.TabIndex = 15;
            this.labelMapOreScale.Text = "Scale:";
            // 
            // labelMapOreDensity
            // 
            this.labelMapOreDensity.AutoSize = true;
            this.labelMapOreDensity.Location = new System.Drawing.Point(3, 80);
            this.labelMapOreDensity.Name = "labelMapOreDensity";
            this.labelMapOreDensity.Size = new System.Drawing.Size(27, 13);
            this.labelMapOreDensity.TabIndex = 9;
            this.labelMapOreDensity.Text = "Ore:";
            // 
            // trackBarMapGoldOctaves
            // 
            this.trackBarMapGoldOctaves.LargeChange = 1;
            this.trackBarMapGoldOctaves.Location = new System.Drawing.Point(74, 203);
            this.trackBarMapGoldOctaves.Minimum = 1;
            this.trackBarMapGoldOctaves.Name = "trackBarMapGoldOctaves";
            this.trackBarMapGoldOctaves.Size = new System.Drawing.Size(84, 14);
            this.trackBarMapGoldOctaves.TabIndex = 25;
            this.trackBarMapGoldOctaves.Value = 1;
            this.trackBarMapGoldOctaves.Scroll += new System.EventHandler(this.trackBarMapGoldOctaves_Scroll);
            // 
            // labelMapGoldOctavesValue
            // 
            this.labelMapGoldOctavesValue.AutoSize = true;
            this.labelMapGoldOctavesValue.Location = new System.Drawing.Point(164, 200);
            this.labelMapGoldOctavesValue.Name = "labelMapGoldOctavesValue";
            this.labelMapGoldOctavesValue.Size = new System.Drawing.Size(13, 13);
            this.labelMapGoldOctavesValue.TabIndex = 24;
            this.labelMapGoldOctavesValue.Text = "1";
            // 
            // labelMapGoldScaleValue
            // 
            this.labelMapGoldScaleValue.AutoSize = true;
            this.labelMapGoldScaleValue.Location = new System.Drawing.Point(164, 180);
            this.labelMapGoldScaleValue.Name = "labelMapGoldScaleValue";
            this.labelMapGoldScaleValue.Size = new System.Drawing.Size(27, 13);
            this.labelMapGoldScaleValue.TabIndex = 26;
            this.labelMapGoldScaleValue.Text = "50%";
            // 
            // trackBarMapGoldDensity
            // 
            this.trackBarMapGoldDensity.LargeChange = 1;
            this.trackBarMapGoldDensity.Location = new System.Drawing.Point(74, 163);
            this.trackBarMapGoldDensity.Name = "trackBarMapGoldDensity";
            this.trackBarMapGoldDensity.Size = new System.Drawing.Size(84, 14);
            this.trackBarMapGoldDensity.TabIndex = 21;
            this.trackBarMapGoldDensity.Value = 5;
            this.trackBarMapGoldDensity.Scroll += new System.EventHandler(this.trackBarMapGoldDensity_Scroll);
            // 
            // labelMapGoldDensityValue
            // 
            this.labelMapGoldDensityValue.AutoSize = true;
            this.labelMapGoldDensityValue.Location = new System.Drawing.Point(164, 160);
            this.labelMapGoldDensityValue.Name = "labelMapGoldDensityValue";
            this.labelMapGoldDensityValue.Size = new System.Drawing.Size(27, 13);
            this.labelMapGoldDensityValue.TabIndex = 22;
            this.labelMapGoldDensityValue.Text = "50%";
            // 
            // trackBarMapOreOctaves
            // 
            this.trackBarMapOreOctaves.LargeChange = 1;
            this.trackBarMapOreOctaves.Location = new System.Drawing.Point(74, 123);
            this.trackBarMapOreOctaves.Minimum = 1;
            this.trackBarMapOreOctaves.Name = "trackBarMapOreOctaves";
            this.trackBarMapOreOctaves.Size = new System.Drawing.Size(84, 14);
            this.trackBarMapOreOctaves.TabIndex = 19;
            this.trackBarMapOreOctaves.Value = 1;
            this.trackBarMapOreOctaves.Scroll += new System.EventHandler(this.trackBarMapOreOctaves_Scroll);
            // 
            // labelMapOreOctavesValue
            // 
            this.labelMapOreOctavesValue.AutoSize = true;
            this.labelMapOreOctavesValue.Location = new System.Drawing.Point(164, 120);
            this.labelMapOreOctavesValue.Name = "labelMapOreOctavesValue";
            this.labelMapOreOctavesValue.Size = new System.Drawing.Size(13, 13);
            this.labelMapOreOctavesValue.TabIndex = 20;
            this.labelMapOreOctavesValue.Text = "1";
            // 
            // labelMapOreScaleValue
            // 
            this.labelMapOreScaleValue.AutoSize = true;
            this.labelMapOreScaleValue.Location = new System.Drawing.Point(164, 100);
            this.labelMapOreScaleValue.Name = "labelMapOreScaleValue";
            this.labelMapOreScaleValue.Size = new System.Drawing.Size(27, 13);
            this.labelMapOreScaleValue.TabIndex = 14;
            this.labelMapOreScaleValue.Text = "50%";
            // 
            // trackBarMapOreDensity
            // 
            this.trackBarMapOreDensity.LargeChange = 1;
            this.trackBarMapOreDensity.Location = new System.Drawing.Point(74, 83);
            this.trackBarMapOreDensity.Name = "trackBarMapOreDensity";
            this.trackBarMapOreDensity.Size = new System.Drawing.Size(84, 14);
            this.trackBarMapOreDensity.TabIndex = 10;
            this.trackBarMapOreDensity.Value = 5;
            this.trackBarMapOreDensity.Scroll += new System.EventHandler(this.trackBarMapOreDensity_Scroll);
            // 
            // labelMapOreDensityValue
            // 
            this.labelMapOreDensityValue.AutoSize = true;
            this.labelMapOreDensityValue.Location = new System.Drawing.Point(164, 80);
            this.labelMapOreDensityValue.Name = "labelMapOreDensityValue";
            this.labelMapOreDensityValue.Size = new System.Drawing.Size(27, 13);
            this.labelMapOreDensityValue.TabIndex = 11;
            this.labelMapOreDensityValue.Text = "50%";
            // 
            // labelMapFoodPersistence
            // 
            this.labelMapFoodPersistence.AutoSize = true;
            this.labelMapFoodPersistence.Location = new System.Drawing.Point(3, 60);
            this.labelMapFoodPersistence.Name = "labelMapFoodPersistence";
            this.labelMapFoodPersistence.Size = new System.Drawing.Size(65, 13);
            this.labelMapFoodPersistence.TabIndex = 27;
            this.labelMapFoodPersistence.Text = "Persistence:";
            // 
            // trackBarMapFoodPersistence
            // 
            this.trackBarMapFoodPersistence.LargeChange = 1;
            this.trackBarMapFoodPersistence.Location = new System.Drawing.Point(74, 63);
            this.trackBarMapFoodPersistence.Name = "trackBarMapFoodPersistence";
            this.trackBarMapFoodPersistence.Size = new System.Drawing.Size(84, 14);
            this.trackBarMapFoodPersistence.TabIndex = 28;
            this.trackBarMapFoodPersistence.Value = 5;
            this.trackBarMapFoodPersistence.Scroll += new System.EventHandler(this.trackBarMapFoodPersistence_Scroll);
            // 
            // labelMapFoodPersistenceValue
            // 
            this.labelMapFoodPersistenceValue.AutoSize = true;
            this.labelMapFoodPersistenceValue.Location = new System.Drawing.Point(164, 60);
            this.labelMapFoodPersistenceValue.Name = "labelMapFoodPersistenceValue";
            this.labelMapFoodPersistenceValue.Size = new System.Drawing.Size(27, 13);
            this.labelMapFoodPersistenceValue.TabIndex = 29;
            this.labelMapFoodPersistenceValue.Text = "50%";
            // 
            // labelMapOrePersistence
            // 
            this.labelMapOrePersistence.AutoSize = true;
            this.labelMapOrePersistence.Location = new System.Drawing.Point(3, 140);
            this.labelMapOrePersistence.Name = "labelMapOrePersistence";
            this.labelMapOrePersistence.Size = new System.Drawing.Size(65, 13);
            this.labelMapOrePersistence.TabIndex = 30;
            this.labelMapOrePersistence.Text = "Persistence:";
            // 
            // labelMapGoldPersistenceValue
            // 
            this.labelMapGoldPersistenceValue.AutoSize = true;
            this.labelMapGoldPersistenceValue.Location = new System.Drawing.Point(164, 220);
            this.labelMapGoldPersistenceValue.Name = "labelMapGoldPersistenceValue";
            this.labelMapGoldPersistenceValue.Size = new System.Drawing.Size(27, 13);
            this.labelMapGoldPersistenceValue.TabIndex = 32;
            this.labelMapGoldPersistenceValue.Text = "50%";
            // 
            // labelMapOrePersistenceValue
            // 
            this.labelMapOrePersistenceValue.AutoSize = true;
            this.labelMapOrePersistenceValue.Location = new System.Drawing.Point(164, 140);
            this.labelMapOrePersistenceValue.Name = "labelMapOrePersistenceValue";
            this.labelMapOrePersistenceValue.Size = new System.Drawing.Size(27, 13);
            this.labelMapOrePersistenceValue.TabIndex = 33;
            this.labelMapOrePersistenceValue.Text = "50%";
            // 
            // trackBarMapOrePersistence
            // 
            this.trackBarMapOrePersistence.LargeChange = 1;
            this.trackBarMapOrePersistence.Location = new System.Drawing.Point(74, 143);
            this.trackBarMapOrePersistence.Minimum = 1;
            this.trackBarMapOrePersistence.Name = "trackBarMapOrePersistence";
            this.trackBarMapOrePersistence.Size = new System.Drawing.Size(84, 14);
            this.trackBarMapOrePersistence.TabIndex = 34;
            this.trackBarMapOrePersistence.Value = 1;
            this.trackBarMapOrePersistence.Scroll += new System.EventHandler(this.trackBarMapOrePersistence_Scroll);
            // 
            // trackBarMapGoldPersistence
            // 
            this.trackBarMapGoldPersistence.LargeChange = 1;
            this.trackBarMapGoldPersistence.Location = new System.Drawing.Point(74, 223);
            this.trackBarMapGoldPersistence.Minimum = 1;
            this.trackBarMapGoldPersistence.Name = "trackBarMapGoldPersistence";
            this.trackBarMapGoldPersistence.Size = new System.Drawing.Size(84, 14);
            this.trackBarMapGoldPersistence.TabIndex = 35;
            this.trackBarMapGoldPersistence.Value = 1;
            this.trackBarMapGoldPersistence.Scroll += new System.EventHandler(this.trackBarMapGoldPersistence_Scroll);
            // 
            // buttonGenerateMap
            // 
            this.buttonGenerateMap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonGenerateMap.AutoSize = true;
            this.buttonGenerateMap.Location = new System.Drawing.Point(5, 337);
            this.buttonGenerateMap.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGenerateMap.Name = "buttonGenerateMap";
            this.buttonGenerateMap.Size = new System.Drawing.Size(190, 23);
            this.buttonGenerateMap.TabIndex = 5;
            this.buttonGenerateMap.Text = "Generate Map";
            this.buttonGenerateMap.UseVisualStyleBackColor = true;
            this.buttonGenerateMap.Click += new System.EventHandler(this.buttonGenerateMap_Click);
            // 
            // labelMapParameters
            // 
            this.labelMapParameters.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelMapParameters.AutoSize = true;
            this.labelMapParameters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMapParameters.Location = new System.Drawing.Point(59, 362);
            this.labelMapParameters.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMapParameters.Name = "labelMapParameters";
            this.labelMapParameters.Size = new System.Drawing.Size(81, 17);
            this.labelMapParameters.TabIndex = 6;
            this.labelMapParameters.Text = "Parameters";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.labelCreaturesValue, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelCreatures, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(41, 382);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(118, 13);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // labelCreaturesValue
            // 
            this.labelCreaturesValue.AutoSize = true;
            this.labelCreaturesValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCreaturesValue.Location = new System.Drawing.Point(61, 0);
            this.labelCreaturesValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCreaturesValue.Name = "labelCreaturesValue";
            this.labelCreaturesValue.Size = new System.Drawing.Size(55, 13);
            this.labelCreaturesValue.TabIndex = 2;
            this.labelCreaturesValue.Text = "num";
            // 
            // labelCreatures
            // 
            this.labelCreatures.AutoSize = true;
            this.labelCreatures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCreatures.Location = new System.Drawing.Point(2, 0);
            this.labelCreatures.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCreatures.Name = "labelCreatures";
            this.labelCreatures.Size = new System.Drawing.Size(55, 13);
            this.labelCreatures.TabIndex = 1;
            this.labelCreatures.Text = "Creatures:";
            // 
            // flowLayoutPanelTile
            // 
            this.flowLayoutPanelTile.AutoSize = true;
            this.flowLayoutPanelTile.Controls.Add(this.labelTile);
            this.flowLayoutPanelTile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelTile.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelTile.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelTile.Name = "flowLayoutPanelTile";
            this.flowLayoutPanelTile.Size = new System.Drawing.Size(200, 676);
            this.flowLayoutPanelTile.TabIndex = 6;
            this.flowLayoutPanelTile.Visible = false;
            // 
            // labelTile
            // 
            this.labelTile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTile.AutoSize = true;
            this.labelTile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTile.Location = new System.Drawing.Point(2, 0);
            this.labelTile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTile.Name = "labelTile";
            this.labelTile.Size = new System.Drawing.Size(31, 17);
            this.labelTile.TabIndex = 3;
            this.labelTile.Text = "Tile";
            // 
            // toolStripContainer
            // 
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.Controls.Add(this.labelFrameRate);
            this.toolStripContainer.ContentPanel.Controls.Add(this.map);
            this.toolStripContainer.ContentPanel.Margin = new System.Windows.Forms.Padding(2);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(1066, 649);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.Margin = new System.Windows.Forms.Padding(2);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.Size = new System.Drawing.Size(1066, 676);
            this.toolStripContainer.TabIndex = 0;
            this.toolStripContainer.Text = "toolStripContainer1";
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStripMapFilter);
            // 
            // labelFrameRate
            // 
            this.labelFrameRate.AutoSize = true;
            this.labelFrameRate.BackColor = System.Drawing.Color.Transparent;
            this.labelFrameRate.Location = new System.Drawing.Point(3, 3);
            this.labelFrameRate.Name = "labelFrameRate";
            this.labelFrameRate.Size = new System.Drawing.Size(27, 13);
            this.labelFrameRate.TabIndex = 2;
            this.labelFrameRate.Text = "num";
            // 
            // map
            // 
            this.map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.map.Location = new System.Drawing.Point(0, 0);
            this.map.Margin = new System.Windows.Forms.Padding(2);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(1066, 649);
            this.map.TabIndex = 1;
            this.map.Text = "map";
            this.map.KeyDown += new System.Windows.Forms.KeyEventHandler(this.map_KeyDown);
            this.map.KeyUp += new System.Windows.Forms.KeyEventHandler(this.map_KeyUp);
            this.map.MouseDown += new System.Windows.Forms.MouseEventHandler(this.map_MouseDown);
            this.map.MouseEnter += new System.EventHandler(this.map_MouseEnter);
            this.map.MouseLeave += new System.EventHandler(this.map_MouseLeave);
            this.map.MouseMove += new System.Windows.Forms.MouseEventHandler(this.map_MouseMove);
            this.map.MouseUp += new System.Windows.Forms.MouseEventHandler(this.map_MouseUp);
            this.map.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.map_MouseWheel);
            // 
            // toolStripMapFilter
            // 
            this.toolStripMapFilter.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripMapFilter.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMapFilter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonFood,
            this.toolStripButtonOre,
            this.toolStripButtonGold});
            this.toolStripMapFilter.Location = new System.Drawing.Point(3, 0);
            this.toolStripMapFilter.Name = "toolStripMapFilter";
            this.toolStripMapFilter.Size = new System.Drawing.Size(84, 27);
            this.toolStripMapFilter.TabIndex = 0;
            // 
            // toolStripButtonFood
            // 
            this.toolStripButtonFood.Checked = true;
            this.toolStripButtonFood.CheckOnClick = true;
            this.toolStripButtonFood.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButtonFood.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFood.Image = global::Evolve.Properties.Resources.leaf;
            this.toolStripButtonFood.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFood.Name = "toolStripButtonFood";
            this.toolStripButtonFood.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonFood.Text = "toolStripButton1";
            this.toolStripButtonFood.ToolTipText = "Display Food Layer";
            this.toolStripButtonFood.CheckedChanged += new System.EventHandler(this.toolStripButtonFood_CheckedChanged);
            // 
            // toolStripButtonOre
            // 
            this.toolStripButtonOre.Checked = true;
            this.toolStripButtonOre.CheckOnClick = true;
            this.toolStripButtonOre.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButtonOre.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOre.Image = global::Evolve.Properties.Resources.diamond;
            this.toolStripButtonOre.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOre.Name = "toolStripButtonOre";
            this.toolStripButtonOre.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonOre.Text = "toolStripButton2";
            this.toolStripButtonOre.ToolTipText = "Show Ore Layer";
            this.toolStripButtonOre.CheckedChanged += new System.EventHandler(this.toolStripButtonOre_CheckedChanged);
            // 
            // toolStripButtonGold
            // 
            this.toolStripButtonGold.Checked = true;
            this.toolStripButtonGold.CheckOnClick = true;
            this.toolStripButtonGold.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButtonGold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonGold.Image = global::Evolve.Properties.Resources.gold;
            this.toolStripButtonGold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGold.Name = "toolStripButtonGold";
            this.toolStripButtonGold.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonGold.Text = "toolStripButton3";
            this.toolStripButtonGold.ToolTipText = "Show Gold Layer";
            this.toolStripButtonGold.CheckedChanged += new System.EventHandler(this.toolStripButtonGold_CheckedChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 676);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainWindow";
            this.Text = "Evolve";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanelCreature.ResumeLayout(false);
            this.flowLayoutPanelCreature.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanelSkills.ResumeLayout(false);
            this.tableLayoutPanelSkills.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanelNeuralNetwork.ResumeLayout(false);
            this.tableLayoutPanelNeuralNetwork.PerformLayout();
            this.flowLayoutPanelGenerateMap.ResumeLayout(false);
            this.flowLayoutPanelGenerateMap.PerformLayout();
            this.tableLayoutPanelMapSize.ResumeLayout(false);
            this.tableLayoutPanelMapSize.PerformLayout();
            this.tableLayoutPanelMapProperties.ResumeLayout(false);
            this.tableLayoutPanelMapProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMapOreScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMapFoodDensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMapFoodOctaves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMapFoodScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMapGoldScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMapGoldOctaves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMapGoldDensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMapOreOctaves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMapOreDensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMapFoodPersistence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMapOrePersistence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMapGoldPersistence)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.flowLayoutPanelTile.ResumeLayout(false);
            this.flowLayoutPanelTile.PerformLayout();
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.ContentPanel.PerformLayout();
            this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.PerformLayout();
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.toolStripMapFilter.ResumeLayout(false);
            this.toolStripMapFilter.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private SplitContainer splitContainer1;
		private Map map;
		private ToolStripContainer toolStripContainer;
		private ToolStrip toolStripMapFilter;
		private ToolStripButton toolStripButtonFood;
		private ToolStripButton toolStripButtonOre;
		private FlowLayoutPanel flowLayoutPanelTile;
		private Label labelTile;
		private FlowLayoutPanel flowLayoutPanelCreature;
		private Label labelCreature;
		private TableLayoutPanel tableLayoutPanelNeuralNetwork;
		private Label labelFoodSelf;
		private Label labelFarm;
		private Label labelFoodSelfValue;
		private Label labelFarmValue;
		private Label labelCreatureOutputs;
		private Label labelCreatureInputs;
		private TableLayoutPanel tableLayoutPanel2;
		private Label labelActivity;
		private Label labelActivityValue;
		private Label labelFoodCostValue;
		private Label labelFoodCost;
		private Label labelOreTileValue;
		private Label labelOreTile;
		private Label labelOreMoveValue;
		private Label labelOreMove;
		private Label labelOreSelfValue;
		private Label labelOreSelf;
		private Label labelMineValue;
		private Label labelMine;
		private Label labelFoodAreaValue;
		private Label labelFoodMove;
		private Label labelFoodTileValue;
		private Label labelFoodTile;
		private Label labelFoodArea;
		private Label labelResources;
		private TableLayoutPanel tableLayoutPanel3;
		private Label labelFoodOwnedValue;
		private Label labelFoodOwned;
		private Label labelThoughts;
		private Label labelOreArea;
		private Label labelOreAreaValue;
		private Label labelOreOwned;
		private Label labelOreOwnedValue;
		private Label labelOrePrice;
		private Label labelOreCost;
		private Label labelOreCostValue;
		private Label labelFoodPrice;
		private Label labelFoodPriceValue;
		private Label labelOrePriceValue;
		private Label labelTrade;
		private Label labelTradeValue;
		private Label labelSkills;
		private TableLayoutPanel tableLayoutPanelSkills;
		private Label labelSkillMining;
		private Label labelSkillFarmingValue;
		private Label labelSkillFarming;
		private Label labelSkillMiningValue;
		private ToolStripButton toolStripButtonGold;
		private FlowLayoutPanel flowLayoutPanelGenerateMap;
		private Label labelGenerateMap;
		private TableLayoutPanel tableLayoutPanelMapSize;
		private Label labelMapWidth;
		private TextBox textBoxMapWidth;
		private TextBox textBoxMapHeight;
		private Label labelMapHeight;
		private Label labelCreatureCount;
		private TextBox textBoxCreatureCount;
		private TableLayoutPanel tableLayoutPanelMapProperties;
		private Label labelMapGoldScaleValue;
		private TrackBar trackBarMapGoldOctaves;
		private Label labelMapOreDensity;
		private TrackBar trackBarMapOreDensity;
		private Label labelMapOreDensityValue;
		private TrackBar trackBarMapOreScale;
		private Label labelMapOreScaleValue;
		private Label labelMapFoodDensity;
		private TrackBar trackBarMapFoodDensity;
		private Label labelMapFoodDensityValue;
		private Label labelMapFoodOctaves;
		private Label labelMapFoodScale;
		private TrackBar trackBarMapFoodOctaves;
		private TrackBar trackBarMapFoodScale;
		private Label labelMapFoodOctavesValue;
		private Label labelMapFoodScaleValue;
		private Label labelMapOreScale;
		private Label labelMapGoldDensity;
		private Label labelMapOreOctaves;
		private Label labelMapGoldScale;
		private TrackBar trackBarMapOreOctaves;
		private Label labelMapOreOctavesValue;
		private TrackBar trackBarMapGoldDensity;
		private Label labelMapGoldDensityValue;
		private TrackBar trackBarMapGoldScale;
		private Label labelMapGoldOctaves;
		private Label labelMapGoldOctavesValue;
		private Button buttonGenerateMap;
		private Label labelMapParameters;
		private TableLayoutPanel tableLayoutPanel4;
		private Label labelCreaturesValue;
		private Label labelCreatures;
		private Label labelMapGoldPersistence;
		private Label labelMapFoodPersistence;
		private TrackBar trackBarMapFoodPersistence;
		private Label labelMapFoodPersistenceValue;
		private Label labelMapOrePersistence;
		private Label labelMapGoldPersistenceValue;
		private Label labelMapOrePersistenceValue;
		private TrackBar trackBarMapOrePersistence;
		private TrackBar trackBarMapGoldPersistence;
		private Label labelBuyLand;
		private Label labelBuyLandValue;
		private Label labelFoodProperty;
		private Label labelFoodPropertyValue;
		private Label labelFoodMoveValue;
		private Label labelMoveProperty;
		private Label labelMovePropertyValue;
		private Label labelLootProspect;
		private Label labelLootProspectValue;
		private Label labelLoot;
		private Label labelLootValue;
		private Label labelFrameRate;
        private Label labelAgeOwned;
        private Label labelAgeOwnedValue;
        private Label labelSkillFighting;
        private Label labelSkillFightingValue;
    }
}