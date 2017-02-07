using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evolve {
	public partial class MainWindow : Form {
		private Timer updateTimer = new Timer();
		internal static readonly int tickRatems = 100;

		public MainWindow() {
			//this.DoubleBuffered = true;
			InitializeComponent();

			panTimer.Interval = panSpeedMs;
			panTimer.Tick += PanTimer_Tick;

			//Update Timer
			updateTimer.Tick += UpdateTimer_Tick;
			updateTimer.Interval = tickRatems;
			if(System.ComponentModel.LicenseManager.UsageMode != System.ComponentModel.LicenseUsageMode.Designtime) {
				updateTimer.Start();
			}

		}

		private void UpdateTimer_Tick(object sender, EventArgs e) {
			map?.UpdateTick();
			// Update GUI
			// FPS
			labelFrameRate.Text = String.Format("{0}", Map.lastFrameRate);

			// Update Creature
			if(map.selectedCreature != null) {
				labelFoodOwnedValue.Text = String.Format("{0:0.}", map.selectedCreature.food);
				labelOreOwnedValue.Text = String.Format("{0:0.}", map.selectedCreature.ore);

				labelSkillFarmingValue.Text = String.Format("{0:0.}", map.selectedCreature.farmSkill);
				labelSkillMiningValue.Text = String.Format("{0:0.}", map.selectedCreature.mineSkill);

				switch(map.selectedCreature.activity) {
					case Creature.Activity.FARM:
						labelActivityValue.Text = String.Format("Farm");
						break;
					case Creature.Activity.MINE:
						labelActivityValue.Text = String.Format("Mine");
						break;
					case Creature.Activity.MOVERANDOM:
						labelActivityValue.Text = String.Format("Move Random");
						break;
					case Creature.Activity.MOVETOFOOD:
						labelActivityValue.Text = String.Format("Looking for Food");
						break;
					case Creature.Activity.MOVETOORE:
						labelActivityValue.Text = String.Format("Looking for Ore");
						break;
					case Creature.Activity.MOVETOPROPERTY:
						labelActivityValue.Text = String.Format("Moving to Property");
						break;
					case Creature.Activity.THINK:
						labelActivityValue.Text = String.Format("Thinking");
						break;
					case Creature.Activity.TRADE:
						labelActivityValue.Text = String.Format("Trading");
						break;
					case Creature.Activity.LOOT:
						labelActivityValue.Text = String.Format("Looting");
						break;
				}

				labelFoodSelfValue.Text = String.Format("{0:0.}", map.selectedCreature.mainNet.nodeList[0][0].value * 100);
				labelFoodTileValue.Text = String.Format("{0:0.}", map.selectedCreature.mainNet.nodeList[0][1].value * 100);
				labelFoodAreaValue.Text = String.Format("{0:0.}", map.selectedCreature.mainNet.nodeList[0][2].value * 100);
				labelFoodPropertyValue.Text = String.Format("{0:0.}", map.selectedCreature.mainNet.nodeList[0][3].value * 100);
				labelOreSelfValue.Text = String.Format("{0:0.}", map.selectedCreature.mainNet.nodeList[0][4].value * 100);
				labelOreTileValue.Text = String.Format("{0:0.}", map.selectedCreature.mainNet.nodeList[0][5].value * 100);
				labelOreAreaValue.Text = String.Format("{0:0.}", map.selectedCreature.mainNet.nodeList[0][6].value * 100);
				labelFoodPriceValue.Text = String.Format("{0:0.}", map.selectedCreature.mainNet.nodeList[0][7].value * 100);
				labelOrePriceValue.Text = String.Format("{0:0.}", map.selectedCreature.mainNet.nodeList[0][8].value * 100);
				//labelLootProspectValue.Text = String.Format("{0:0.}", map.selectedCreature.mainNet.nodeList[0][9].value * 100);

				labelFarmValue.Text = String.Format("{0:0.}", map.selectedCreature.mainNet.nodeList[1][0].value * 100);
				labelFoodMoveValue.Text = String.Format("{0:0.}", map.selectedCreature.mainNet.nodeList[1][1].value * 100);
				labelMineValue.Text = String.Format("{0:0.}", map.selectedCreature.mainNet.nodeList[1][2].value * 100);
				labelOreMoveValue.Text = String.Format("{0:0.}", map.selectedCreature.mainNet.nodeList[1][3].value * 100);
				labelFoodCostValue.Text = String.Format("{0:0.}", map.selectedCreature.mainNet.nodeList[1][4].value * 100);
				labelOreCostValue.Text = String.Format("{0:0.}", map.selectedCreature.mainNet.nodeList[1][5].value * 100);
				labelTradeValue.Text = String.Format("{0:0.}", map.selectedCreature.mainNet.nodeList[1][6].value * 100);
				labelBuyLandValue.Text = String.Format("{0:0.}", map.selectedCreature.mainNet.nodeList[1][7].value * 100);
				labelMovePropertyValue.Text = String.Format("{0:0.}", map.selectedCreature.mainNet.nodeList[1][7].value * 100);

			} else {
				labelCreaturesValue.Text = String.Format("{0:0.}", map.creatureList.Count);
			}
		}

		private void buttonGenerateMap_Click(object sender, EventArgs e) {
			generateMapFromUI();
		}

		private void generateMapFromUI() {
			if(textBoxMapWidth.TextLength == 0) {
				textBoxMapWidth.BackColor = Color.Orange;
			} else {
				int mapWidth = Convert.ToInt32(textBoxMapWidth.Text);
				textBoxMapWidth.BackColor = Color.White;

				if(textBoxMapHeight.TextLength == 0) {
					textBoxMapHeight.BackColor = Color.Orange;

				} else {
					int mapHeight = Convert.ToInt32(textBoxMapHeight.Text);
					textBoxMapHeight.BackColor = Color.White;

					if(textBoxCreatureCount.TextLength == 0) {
						textBoxCreatureCount.BackColor = Color.Orange;

					} else {
						int creatureCount = Convert.ToInt32(textBoxCreatureCount.Text);
						textBoxCreatureCount.BackColor = Color.White;

						Map.MapOptions mapOptions;
						mapOptions.foodLayerOptions.density = trackBarMapFoodDensity.Value * 10;
						mapOptions.foodLayerOptions.mapScale = - 0.01f * trackBarMapFoodScale.Value + 0.1f;			// 0.1 to .01
						mapOptions.foodLayerOptions.octaves = trackBarMapFoodOctaves.Value;
						mapOptions.foodLayerOptions.persistence = trackBarMapFoodPersistence.Value / 10f + 0.0f;	// 0.015 to 0.15

						mapOptions.oreLayerOptions.density = trackBarMapOreDensity.Value * 10;
						mapOptions.oreLayerOptions.mapScale = - 0.01f * trackBarMapFoodScale.Value + 0.1f;			// 0.1 to .01
						mapOptions.oreLayerOptions.octaves = trackBarMapOreOctaves.Value;
						mapOptions.oreLayerOptions.persistence = trackBarMapOrePersistence.Value / 10f + 0.0f;	// 0.015 to 0.15

						mapOptions.goldLayerOptions.density = trackBarMapGoldDensity.Value * 10;
						mapOptions.goldLayerOptions.mapScale = - 0.01f * trackBarMapFoodScale.Value + 0.1f;			// 0.1 to .01
						mapOptions.goldLayerOptions.octaves = trackBarMapGoldOctaves.Value;
						mapOptions.goldLayerOptions.persistence = trackBarMapGoldPersistence.Value / 10f + 0.0f;	// 0.015 to 0.15

						map.Generate(mapWidth, mapHeight, creatureCount, mapOptions);
						map.Invalidate();
					}
				}

			}
		}

		private void textBoxMapWidth_KeyPress(object sender, KeyPressEventArgs e) {
			switch(e.KeyChar) {
				case '\r':
					SendKeys.Send("{TAB}");
					e.Handled = true;
					break;
				default:
					Regex regex = new Regex("[0-9\b]");
					e.Handled = !regex.IsMatch(Convert.ToString(e.KeyChar));
					break;
			}
		}

		private void textBoxMapHeight_KeyPress(object sender, KeyPressEventArgs e) {
			switch(e.KeyChar) {
				case '\r':
					SendKeys.Send("{TAB}");
					e.Handled = true;
					break;
				default:
					Regex regex = new Regex("[0-9\b]");
					e.Handled = !regex.IsMatch(Convert.ToString(e.KeyChar));
					break;
			}
		}

		static readonly float zoomRate = 0.9f;
		private void map_MouseWheel(object sender, MouseEventArgs e) {
			Point mousePoint = e.Location;
			mousePoint.X -= map.Location.X;
			mousePoint.Y -= map.Location.Y;
			mousePoint.X -= Convert.ToInt32(map.viewTransform.OffsetX);
			mousePoint.Y -= Convert.ToInt32(map.viewTransform.OffsetY);
			mousePoint.X = Convert.ToInt32(mousePoint.X / map.viewTransform.Elements[0]);
			mousePoint.Y = Convert.ToInt32(mousePoint.Y / map.viewTransform.Elements[0]);
			if(e.Delta < 0) {
				// Zoom out
				map.viewTransform.Translate(mousePoint.X, mousePoint.Y);
				map.viewTransform.Scale(zoomRate, zoomRate);
				map.viewTransform.Translate(-1 * mousePoint.X, -1 * mousePoint.Y);
			} else {
				// Zoom in
				map.viewTransform.Translate(mousePoint.X, mousePoint.Y);
				map.viewTransform.Scale(1 / zoomRate, 1 / zoomRate);
				map.viewTransform.Translate(-1 * mousePoint.X, -1 * mousePoint.Y);
			}
			map.Invalidate();
		}

		bool isPanning = false;
		Point translation = new Point(0, 0);    // How much to pan the map (prior to current pan, if any)
		Point panStartPoint;                     // Where we started the current pan

		private void map_MouseDown(object sender, MouseEventArgs e) {
			if(e.Button == MouseButtons.Middle) {
				isPanning = true;
				panStartPoint = e.Location;
			}
			if(e.Button == MouseButtons.Left) {
				map.selectedCreature = map.getCreatureFromMouse(e.Location);
				if(map.selectedCreature != null) {
					map.selectedTile = null;
					flowLayoutPanelGenerateMap.Visible = false;
					flowLayoutPanelTile.Visible = false;
					flowLayoutPanelCreature.Visible = true;
				} else {
					map.selectedTile = map.getTileFromMouse(e.Location);
					if(map.selectedTile != null) {
						map.selectedCreature = null;
						flowLayoutPanelGenerateMap.Visible = false;
						flowLayoutPanelTile.Visible = true;
						flowLayoutPanelCreature.Visible = false;
					} else {
						flowLayoutPanelGenerateMap.Visible = true;
						flowLayoutPanelTile.Visible = false;
						flowLayoutPanelCreature.Visible = false;
					}
				}
				map.Invalidate();
			}
			if(e.Button == MouseButtons.Right) {
				map.selectedTile = null;
				map.selectedCreature = null;
				flowLayoutPanelGenerateMap.Visible = true;
				flowLayoutPanelTile.Visible = false;
				flowLayoutPanelCreature.Visible = false;
				map.Invalidate();
			}
		}

		private void map_MouseLeave(object sender, EventArgs e) {
			isPanning = false;
		}

		private void map_MouseUp(object sender, MouseEventArgs e) {
			if(e.Button == MouseButtons.Middle) {
				isPanning = false;
			}
		}

		private void map_MouseMove(object sender, MouseEventArgs e) {
			// Pan
			if(isPanning) {
				map.viewTransform.Translate((e.X - panStartPoint.X) / map.viewTransform.Elements[0], (e.Y - panStartPoint.Y) / map.viewTransform.Elements[0]);
				panStartPoint = e.Location;
			}
			// Select hovered tile
			map.hoveredTile = map.getTileFromMouse(e.Location);

			map.Invalidate();
		}

		private void map_MouseEnter(object sender, EventArgs e) {
			map.Focus();
		}

		static readonly int panSpeedMs = 10;
		private Timer panTimer = new Timer();
		bool panUp, panLeft, panDown, panRight = false;

		private void map_KeyUp(object sender, KeyEventArgs e) {
			if(e.KeyCode == Keys.W) {
				panUp = false;
			}
			if(e.KeyCode == Keys.S) {
				panDown = false;
			}
			if(e.KeyCode == Keys.A) {
				panLeft = false;
			}
			if(e.KeyCode == Keys.D) {
				panRight = false;
			}
			if(!panLeft && !panRight && !panUp && !panDown) {
				panTimer.Stop();
			}
		}

		private void textBoxMapWidth_Enter(object sender, EventArgs e) {
			textBoxMapWidth.SelectAll();
		}

		private void textBoxMapWidth_MouseEnter(object sender, EventArgs e) {
			textBoxMapWidth.SelectAll();
			textBoxMapWidth.Focus();
		}

		private void textBoxMapHeight_Enter(object sender, EventArgs e) {
			textBoxMapHeight.SelectAll();
		}

		private void textBoxMapHeight_MouseEnter(object sender, EventArgs e) {
			textBoxMapHeight.SelectAll();
			textBoxMapHeight.Focus();
		}

		private void toolStripButtonFood_CheckedChanged(object sender, EventArgs e) {
			map.viewLayer.layerFood = toolStripButtonFood.Checked;
			foreach(Tile tile in map.tileList) {
				tile.UpdateBrush(map.viewLayer);
			}
			map.Invalidate();
		}

		private void toolStripButtonOre_CheckedChanged(object sender, EventArgs e) {
			map.viewLayer.layerOre = toolStripButtonOre.Checked;
			foreach(Tile tile in map.tileList) {
				tile.UpdateBrush(map.viewLayer);
			}
			map.Invalidate();
		}

		private void toolStripButtonGold_CheckedChanged(object sender, EventArgs e) {
			map.viewLayer.layerGold = toolStripButtonGold.Checked;
			foreach(Tile tile in map.tileList) {
				tile.UpdateBrush(map.viewLayer);
			}
			map.Invalidate();
		}

		private void textBoxCreatureCount_Enter(object sender, EventArgs e) {
			textBoxCreatureCount.SelectAll();
		}

		private void textBoxCreatureCount_KeyPress(object sender, KeyPressEventArgs e) {
			switch(e.KeyChar) {
				case '\r':
					generateMapFromUI();
					e.Handled = true;
					break;
				default:
					Regex regex = new Regex("[0-9\b]");
					e.Handled = !regex.IsMatch(Convert.ToString(e.KeyChar));
					break;
			}
		}

		private void textBoxCreatureCount_MouseEnter(object sender, EventArgs e) {
			textBoxCreatureCount.SelectAll();
			textBoxCreatureCount.Focus();
		}

		private void trackBarMapFoodDensity_Scroll(object sender, EventArgs e) {
			labelMapFoodDensityValue.Text = String.Format("{0:0.}%", trackBarMapFoodDensity.Value * 10);
		}

		private void trackBarMapFoodScale_Scroll(object sender, EventArgs e) {
			labelMapFoodScaleValue.Text = String.Format("{0:0.}%", trackBarMapFoodScale.Value * 10);
		}

		private void trackBarMapFoodOctaves_Scroll(object sender, EventArgs e) {
			labelMapFoodOctavesValue.Text = String.Format("{0}", trackBarMapFoodOctaves.Value);
		}

		private void trackBarMapFoodPersistence_Scroll(object sender, EventArgs e) {
			labelMapFoodPersistenceValue.Text = String.Format("{0:0.}%", trackBarMapFoodPersistence.Value * 10);
		}



		private void trackBarMapOreDensity_Scroll(object sender, EventArgs e) {
			labelMapOreDensityValue.Text = String.Format("{0:0.}%", trackBarMapOreDensity.Value * 10);
		}

		private void trackBarMapOreScale_Scroll(object sender, EventArgs e) {
			labelMapOreScaleValue.Text = String.Format("{0:0.}%", trackBarMapOreScale.Value * 10);
		}

		private void trackBarMapOreOctaves_Scroll(object sender, EventArgs e) {
			labelMapOreOctavesValue.Text = String.Format("{0}", trackBarMapOreOctaves.Value);
		}

		private void trackBarMapOrePersistence_Scroll(object sender, EventArgs e) {
			labelMapOrePersistenceValue.Text = String.Format("{0:0.}%", trackBarMapOrePersistence.Value * 10);
		}



		private void trackBarMapGoldDensity_Scroll(object sender, EventArgs e) {
			labelMapGoldDensityValue.Text = String.Format("{0:0.}%", trackBarMapGoldDensity.Value * 10);
		}

		private void trackBarMapGoldScale_Scroll(object sender, EventArgs e) {
			labelMapGoldScaleValue.Text = String.Format("{0:0.}%", trackBarMapGoldScale.Value * 10);
		}

		private void trackBarMapGoldOctaves_Scroll(object sender, EventArgs e) {
			labelMapGoldOctavesValue.Text = String.Format("{0}", trackBarMapGoldOctaves.Value);
		}

		private void trackBarMapGoldPersistence_Scroll(object sender, EventArgs e) {
			labelMapGoldPersistenceValue.Text = String.Format("{0:0.}%", trackBarMapGoldPersistence.Value * 10);
		}

		private void map_KeyDown(object sender, KeyEventArgs e) {
			if(e.KeyCode == Keys.W) {
				panUp = true;
				panDown = false;
				panTimer.Start();
			}
			if(e.KeyCode == Keys.S) {
				panUp = false;
				panDown = true;
				panTimer.Start();
			}
			if(e.KeyCode == Keys.A) {
				panLeft = true;
				panRight = false;
				panTimer.Start();
			}
			if(e.KeyCode == Keys.D) {
				panLeft = false;
				panRight = true;
				panTimer.Start();
			}
		}

		static readonly uint panRate = 20;
		private void PanTimer_Tick(object source, EventArgs e) {
			if(panDown) {
				map.viewTransform.Translate(0, -1 * panRate / map.viewTransform.Elements[0]);
			} else if(panUp) {
				map.viewTransform.Translate(0, panRate / map.viewTransform.Elements[0]);
			}
			if(panRight) {
				map.viewTransform.Translate(-1 * panRate / map.viewTransform.Elements[0], 0);
			} else if(panLeft) {
				map.viewTransform.Translate(panRate / map.viewTransform.Elements[0], 0);
			}
			map.Invalidate();
		}
	}
}