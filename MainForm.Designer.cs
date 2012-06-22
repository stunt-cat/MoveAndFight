/*
 * Created by SharpDevelop.
 * User: ed
 * Date: 24/02/2012
 * Time: 15:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MoveAndFight
	
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.closeCombatButton = new System.Windows.Forms.Button();
			this.forwardButton = new System.Windows.Forms.Button();
			this.startButton = new System.Windows.Forms.Button();
			this.outOfBoundsButton = new System.Windows.Forms.Button();
			this.failedFightButton = new System.Windows.Forms.Button();
			this.leftTurnButton = new System.Windows.Forms.Button();
			this.rightTurnButton = new System.Windows.Forms.Button();
			this.successfulFightButton = new System.Windows.Forms.Button();
			this.rangedCombatButton = new System.Windows.Forms.Button();
			this.scoreLabel = new System.Windows.Forms.Label();
			this.scoreTextBox = new System.Windows.Forms.TextBox();
			this.gameOverButton = new System.Windows.Forms.Button();
			this.gameClock = new System.Windows.Forms.Timer(this.components);
			this.numberOfBaddiesLabel = new System.Windows.Forms.Label();
			this.numberOfHeroesLabel = new System.Windows.Forms.Label();
			this.baddieSelectorPanel = new System.Windows.Forms.Panel();
			this.baddieSelectorButton6 = new System.Windows.Forms.RadioButton();
			this.baddieSelectorButton5 = new System.Windows.Forms.RadioButton();
			this.baddieSelectorButton4 = new System.Windows.Forms.RadioButton();
			this.baddieSelectorButton3 = new System.Windows.Forms.RadioButton();
			this.baddieSelectorButton2 = new System.Windows.Forms.RadioButton();
			this.baddieSelectorButton1 = new System.Windows.Forms.RadioButton();
			this.heroesSelectorPanel = new System.Windows.Forms.Panel();
			this.heroSelectorButton4 = new System.Windows.Forms.RadioButton();
			this.heroSelectorButton3 = new System.Windows.Forms.RadioButton();
			this.heroSelectorButton2 = new System.Windows.Forms.RadioButton();
			this.heroSelectorButton1 = new System.Windows.Forms.RadioButton();
			this.activateHeroButton2 = new System.Windows.Forms.Button();
			this.activateHeroButton1 = new System.Windows.Forms.Button();
			this.activateHeroButton3 = new System.Windows.Forms.Button();
			this.activateHeroButton4 = new System.Windows.Forms.Button();
			this.roomSizeLabel = new System.Windows.Forms.Label();
			this.roomSizeSelectorPanel = new System.Windows.Forms.Panel();
			this.roomSelectorButton3 = new System.Windows.Forms.RadioButton();
			this.roomSelectorButton2 = new System.Windows.Forms.RadioButton();
			this.roomSelectorButton1 = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.baddieSelectorPanel.SuspendLayout();
			this.heroesSelectorPanel.SuspendLayout();
			this.roomSizeSelectorPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBox1.Location = new System.Drawing.Point(16, 71);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(500, 500);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// closeCombatButton
			// 
			this.closeCombatButton.Enabled = false;
			this.closeCombatButton.Image = global::MoveAndFight.Images.closeCombat;
			this.closeCombatButton.Location = new System.Drawing.Point(593, 249);
			this.closeCombatButton.Name = "closeCombatButton";
			this.closeCombatButton.Size = new System.Drawing.Size(100, 100);
			this.closeCombatButton.TabIndex = 1;
			this.closeCombatButton.UseVisualStyleBackColor = true;
			this.closeCombatButton.Click += new System.EventHandler(this.FightButtonClick);
			// 
			// forwardButton
			// 
			this.forwardButton.Enabled = false;
			this.forwardButton.Image = global::MoveAndFight.Images.arrow_north_1;
			this.forwardButton.Location = new System.Drawing.Point(655, 31);
			this.forwardButton.Name = "forwardButton";
			this.forwardButton.Size = new System.Drawing.Size(100, 100);
			this.forwardButton.TabIndex = 5;
			this.forwardButton.UseVisualStyleBackColor = true;
			this.forwardButton.Click += new System.EventHandler(this.ForwardButtonClick);
			// 
			// startButton
			// 
			this.startButton.Location = new System.Drawing.Point(62, 116);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(409, 413);
			this.startButton.TabIndex = 8;
			this.startButton.Text = resources.GetString("startButton.Text");
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.StartButtonClick);
			// 
			// outOfBoundsButton
			// 
			this.outOfBoundsButton.Location = new System.Drawing.Point(536, 444);
			this.outOfBoundsButton.Name = "outOfBoundsButton";
			this.outOfBoundsButton.Size = new System.Drawing.Size(167, 161);
			this.outOfBoundsButton.TabIndex = 9;
			this.outOfBoundsButton.Text = "STOP IT you cretin.\r\nThere is an obstruction. Durr.\r\n\r\nClick to continue.";
			this.outOfBoundsButton.UseVisualStyleBackColor = true;
			this.outOfBoundsButton.Visible = false;
			this.outOfBoundsButton.Click += new System.EventHandler(this.OutOfBoundsButtonClick);
			// 
			// failedFightButton
			// 
			this.failedFightButton.Location = new System.Drawing.Point(724, 444);
			this.failedFightButton.Name = "failedFightButton";
			this.failedFightButton.Size = new System.Drawing.Size(167, 161);
			this.failedFightButton.TabIndex = 10;
			this.failedFightButton.Text = "You miss.\r\nWell done.\r\n\r\nClick to continue.";
			this.failedFightButton.UseVisualStyleBackColor = true;
			this.failedFightButton.Visible = false;
			this.failedFightButton.Click += new System.EventHandler(this.FailedFightButtonClick);
			// 
			// leftTurnButton
			// 
			this.leftTurnButton.Enabled = false;
			this.leftTurnButton.Image = global::MoveAndFight.Images.arrow_leftturn_1;
			this.leftTurnButton.Location = new System.Drawing.Point(536, 66);
			this.leftTurnButton.Name = "leftTurnButton";
			this.leftTurnButton.Size = new System.Drawing.Size(100, 100);
			this.leftTurnButton.TabIndex = 11;
			this.leftTurnButton.UseVisualStyleBackColor = true;
			this.leftTurnButton.Click += new System.EventHandler(this.LeftTurnButtonClick);
			// 
			// rightTurnButton
			// 
			this.rightTurnButton.Enabled = false;
			this.rightTurnButton.Image = global::MoveAndFight.Images.arrow_rightturn_1;
			this.rightTurnButton.Location = new System.Drawing.Point(773, 66);
			this.rightTurnButton.Name = "rightTurnButton";
			this.rightTurnButton.Size = new System.Drawing.Size(100, 100);
			this.rightTurnButton.TabIndex = 12;
			this.rightTurnButton.UseVisualStyleBackColor = true;
			this.rightTurnButton.Click += new System.EventHandler(this.RightTurnButtonClick);
			// 
			// successfulFightButton
			// 
			this.successfulFightButton.Location = new System.Drawing.Point(575, 364);
			this.successfulFightButton.Name = "successfulFightButton";
			this.successfulFightButton.Size = new System.Drawing.Size(269, 64);
			this.successfulFightButton.TabIndex = 13;
			this.successfulFightButton.Text = "YOU KILLED HIM!\r\n\r\nClick to continue.";
			this.successfulFightButton.UseVisualStyleBackColor = true;
			this.successfulFightButton.Visible = false;
			this.successfulFightButton.Click += new System.EventHandler(this.SuccessfulFightButtonClick);
			// 
			// rangedCombatButton
			// 
			this.rangedCombatButton.Enabled = false;
			this.rangedCombatButton.Image = global::MoveAndFight.Images.rangedCombat;
			this.rangedCombatButton.Location = new System.Drawing.Point(712, 249);
			this.rangedCombatButton.Name = "rangedCombatButton";
			this.rangedCombatButton.Size = new System.Drawing.Size(100, 100);
			this.rangedCombatButton.TabIndex = 14;
			this.rangedCombatButton.UseVisualStyleBackColor = true;
			this.rangedCombatButton.Click += new System.EventHandler(this.RangedCombatButtonClick);
			// 
			// scoreLabel
			// 
			this.scoreLabel.Location = new System.Drawing.Point(216, 597);
			this.scoreLabel.Name = "scoreLabel";
			this.scoreLabel.Size = new System.Drawing.Size(59, 27);
			this.scoreLabel.TabIndex = 15;
			this.scoreLabel.Text = "SCORE";
			// 
			// scoreTextBox
			// 
			this.scoreTextBox.Location = new System.Drawing.Point(295, 594);
			this.scoreTextBox.Name = "scoreTextBox";
			this.scoreTextBox.ReadOnly = true;
			this.scoreTextBox.Size = new System.Drawing.Size(70, 20);
			this.scoreTextBox.TabIndex = 16;
			this.scoreTextBox.Text = "0";
			// 
			// gameOverButton
			// 
			this.gameOverButton.Location = new System.Drawing.Point(75, 133);
			this.gameOverButton.Name = "gameOverButton";
			this.gameOverButton.Size = new System.Drawing.Size(382, 383);
			this.gameOverButton.TabIndex = 18;
			this.gameOverButton.UseVisualStyleBackColor = true;
			this.gameOverButton.Visible = false;
			this.gameOverButton.Click += new System.EventHandler(this.GameOverButtonClick);
			// 
			// gameClock
			// 
			this.gameClock.Interval = 60000;
			// 
			// numberOfBaddiesLabel
			// 
			this.numberOfBaddiesLabel.Location = new System.Drawing.Point(21, 13);
			this.numberOfBaddiesLabel.Name = "numberOfBaddiesLabel";
			this.numberOfBaddiesLabel.Size = new System.Drawing.Size(103, 22);
			this.numberOfBaddiesLabel.TabIndex = 20;
			this.numberOfBaddiesLabel.Text = "Number of baddies";
			// 
			// numberOfHeroesLabel
			// 
			this.numberOfHeroesLabel.Location = new System.Drawing.Point(201, 12);
			this.numberOfHeroesLabel.Name = "numberOfHeroesLabel";
			this.numberOfHeroesLabel.Size = new System.Drawing.Size(103, 22);
			this.numberOfHeroesLabel.TabIndex = 22;
			this.numberOfHeroesLabel.Text = "Number of heroes";
			// 
			// baddieSelectorPanel
			// 
			this.baddieSelectorPanel.Controls.Add(this.baddieSelectorButton6);
			this.baddieSelectorPanel.Controls.Add(this.baddieSelectorButton5);
			this.baddieSelectorPanel.Controls.Add(this.baddieSelectorButton4);
			this.baddieSelectorPanel.Controls.Add(this.baddieSelectorButton3);
			this.baddieSelectorPanel.Controls.Add(this.baddieSelectorButton2);
			this.baddieSelectorPanel.Controls.Add(this.baddieSelectorButton1);
			this.baddieSelectorPanel.Location = new System.Drawing.Point(122, 7);
			this.baddieSelectorPanel.Name = "baddieSelectorPanel";
			this.baddieSelectorPanel.Size = new System.Drawing.Size(70, 59);
			this.baddieSelectorPanel.TabIndex = 23;
			// 
			// baddieSelectorButton6
			// 
			this.baddieSelectorButton6.Location = new System.Drawing.Point(37, 38);
			this.baddieSelectorButton6.Name = "baddieSelectorButton6";
			this.baddieSelectorButton6.Size = new System.Drawing.Size(33, 20);
			this.baddieSelectorButton6.TabIndex = 5;
			this.baddieSelectorButton6.Text = "6";
			this.baddieSelectorButton6.UseVisualStyleBackColor = true;
			// 
			// baddieSelectorButton5
			// 
			this.baddieSelectorButton5.Location = new System.Drawing.Point(37, 19);
			this.baddieSelectorButton5.Name = "baddieSelectorButton5";
			this.baddieSelectorButton5.Size = new System.Drawing.Size(33, 20);
			this.baddieSelectorButton5.TabIndex = 4;
			this.baddieSelectorButton5.Text = "5";
			this.baddieSelectorButton5.UseVisualStyleBackColor = true;
			// 
			// baddieSelectorButton4
			// 
			this.baddieSelectorButton4.Location = new System.Drawing.Point(37, 0);
			this.baddieSelectorButton4.Name = "baddieSelectorButton4";
			this.baddieSelectorButton4.Size = new System.Drawing.Size(33, 20);
			this.baddieSelectorButton4.TabIndex = 3;
			this.baddieSelectorButton4.Text = "4";
			this.baddieSelectorButton4.UseVisualStyleBackColor = true;
			// 
			// baddieSelectorButton3
			// 
			this.baddieSelectorButton3.Location = new System.Drawing.Point(7, 38);
			this.baddieSelectorButton3.Name = "baddieSelectorButton3";
			this.baddieSelectorButton3.Size = new System.Drawing.Size(56, 20);
			this.baddieSelectorButton3.TabIndex = 2;
			this.baddieSelectorButton3.Text = "3";
			this.baddieSelectorButton3.UseVisualStyleBackColor = true;
			// 
			// baddieSelectorButton2
			// 
			this.baddieSelectorButton2.Location = new System.Drawing.Point(7, 19);
			this.baddieSelectorButton2.Name = "baddieSelectorButton2";
			this.baddieSelectorButton2.Size = new System.Drawing.Size(56, 20);
			this.baddieSelectorButton2.TabIndex = 1;
			this.baddieSelectorButton2.Text = "2";
			this.baddieSelectorButton2.UseVisualStyleBackColor = true;
			// 
			// baddieSelectorButton1
			// 
			this.baddieSelectorButton1.Checked = true;
			this.baddieSelectorButton1.Location = new System.Drawing.Point(7, 0);
			this.baddieSelectorButton1.Name = "baddieSelectorButton1";
			this.baddieSelectorButton1.Size = new System.Drawing.Size(56, 20);
			this.baddieSelectorButton1.TabIndex = 0;
			this.baddieSelectorButton1.TabStop = true;
			this.baddieSelectorButton1.Text = "1";
			this.baddieSelectorButton1.UseVisualStyleBackColor = true;
			// 
			// heroesSelectorPanel
			// 
			this.heroesSelectorPanel.Controls.Add(this.heroSelectorButton4);
			this.heroesSelectorPanel.Controls.Add(this.heroSelectorButton3);
			this.heroesSelectorPanel.Controls.Add(this.heroSelectorButton2);
			this.heroesSelectorPanel.Controls.Add(this.heroSelectorButton1);
			this.heroesSelectorPanel.Location = new System.Drawing.Point(295, 7);
			this.heroesSelectorPanel.Name = "heroesSelectorPanel";
			this.heroesSelectorPanel.Size = new System.Drawing.Size(84, 59);
			this.heroesSelectorPanel.TabIndex = 24;
			// 
			// heroSelectorButton4
			// 
			this.heroSelectorButton4.Location = new System.Drawing.Point(41, 19);
			this.heroSelectorButton4.Name = "heroSelectorButton4";
			this.heroSelectorButton4.Size = new System.Drawing.Size(32, 22);
			this.heroSelectorButton4.TabIndex = 3;
			this.heroSelectorButton4.TabStop = true;
			this.heroSelectorButton4.Text = "4";
			this.heroSelectorButton4.UseVisualStyleBackColor = true;
			// 
			// heroSelectorButton3
			// 
			this.heroSelectorButton3.Location = new System.Drawing.Point(41, 1);
			this.heroSelectorButton3.Name = "heroSelectorButton3";
			this.heroSelectorButton3.Size = new System.Drawing.Size(32, 22);
			this.heroSelectorButton3.TabIndex = 2;
			this.heroSelectorButton3.TabStop = true;
			this.heroSelectorButton3.Text = "3";
			this.heroSelectorButton3.UseVisualStyleBackColor = true;
			// 
			// heroSelectorButton2
			// 
			this.heroSelectorButton2.Location = new System.Drawing.Point(3, 18);
			this.heroSelectorButton2.Name = "heroSelectorButton2";
			this.heroSelectorButton2.Size = new System.Drawing.Size(32, 21);
			this.heroSelectorButton2.TabIndex = 1;
			this.heroSelectorButton2.TabStop = true;
			this.heroSelectorButton2.Text = "2";
			this.heroSelectorButton2.UseVisualStyleBackColor = true;
			// 
			// heroSelectorButton1
			// 
			this.heroSelectorButton1.Checked = true;
			this.heroSelectorButton1.Location = new System.Drawing.Point(3, -2);
			this.heroSelectorButton1.Name = "heroSelectorButton1";
			this.heroSelectorButton1.Size = new System.Drawing.Size(38, 25);
			this.heroSelectorButton1.TabIndex = 0;
			this.heroSelectorButton1.TabStop = true;
			this.heroSelectorButton1.Text = "1";
			this.heroSelectorButton1.UseVisualStyleBackColor = true;
			// 
			// activateHeroButton2
			// 
			this.activateHeroButton2.Enabled = false;
			this.activateHeroButton2.Image = global::MoveAndFight.Images.hero_select_2;
			this.activateHeroButton2.Location = new System.Drawing.Point(650, 182);
			this.activateHeroButton2.Name = "activateHeroButton2";
			this.activateHeroButton2.Size = new System.Drawing.Size(50, 50);
			this.activateHeroButton2.TabIndex = 17;
			this.activateHeroButton2.UseVisualStyleBackColor = true;
			this.activateHeroButton2.Visible = false;
			this.activateHeroButton2.Click += new System.EventHandler(this.ActivateHeroButton2Click);
			// 
			// activateHeroButton1
			// 
			this.activateHeroButton1.Enabled = false;
			this.activateHeroButton1.Image = global::MoveAndFight.Images.hero_select_1;
			this.activateHeroButton1.Location = new System.Drawing.Point(594, 182);
			this.activateHeroButton1.Name = "activateHeroButton1";
			this.activateHeroButton1.Size = new System.Drawing.Size(50, 50);
			this.activateHeroButton1.TabIndex = 25;
			this.activateHeroButton1.UseVisualStyleBackColor = true;
			this.activateHeroButton1.Visible = false;
			this.activateHeroButton1.Click += new System.EventHandler(this.ActivateHeroButton1Click);
			// 
			// activateHeroButton3
			// 
			this.activateHeroButton3.Enabled = false;
			this.activateHeroButton3.Image = global::MoveAndFight.Images.hero_select_3;
			this.activateHeroButton3.Location = new System.Drawing.Point(706, 182);
			this.activateHeroButton3.Name = "activateHeroButton3";
			this.activateHeroButton3.Size = new System.Drawing.Size(50, 50);
			this.activateHeroButton3.TabIndex = 26;
			this.activateHeroButton3.UseVisualStyleBackColor = true;
			this.activateHeroButton3.Visible = false;
			this.activateHeroButton3.Click += new System.EventHandler(this.ActivateHeroButton3Click);
			// 
			// activateHeroButton4
			// 
			this.activateHeroButton4.Enabled = false;
			this.activateHeroButton4.Image = global::MoveAndFight.Images.hero_select_4;
			this.activateHeroButton4.Location = new System.Drawing.Point(762, 182);
			this.activateHeroButton4.Name = "activateHeroButton4";
			this.activateHeroButton4.Size = new System.Drawing.Size(50, 50);
			this.activateHeroButton4.TabIndex = 27;
			this.activateHeroButton4.UseVisualStyleBackColor = true;
			this.activateHeroButton4.Visible = false;
			this.activateHeroButton4.Click += new System.EventHandler(this.ActivateHeroButton4Click);
			// 
			// roomSizeLabel
			// 
			this.roomSizeLabel.Location = new System.Drawing.Point(397, 9);
			this.roomSizeLabel.Name = "roomSizeLabel";
			this.roomSizeLabel.Size = new System.Drawing.Size(103, 22);
			this.roomSizeLabel.TabIndex = 28;
			this.roomSizeLabel.Text = "Room size";
			// 
			// roomSizeSelectorPanel
			// 
			this.roomSizeSelectorPanel.Controls.Add(this.roomSelectorButton3);
			this.roomSizeSelectorPanel.Controls.Add(this.roomSelectorButton2);
			this.roomSizeSelectorPanel.Controls.Add(this.roomSelectorButton1);
			this.roomSizeSelectorPanel.Location = new System.Drawing.Point(456, 6);
			this.roomSizeSelectorPanel.Name = "roomSizeSelectorPanel";
			this.roomSizeSelectorPanel.Size = new System.Drawing.Size(84, 59);
			this.roomSizeSelectorPanel.TabIndex = 25;
			// 
			// roomSelectorButton3
			// 
			this.roomSelectorButton3.Location = new System.Drawing.Point(5, 37);
			this.roomSelectorButton3.Name = "roomSelectorButton3";
			this.roomSelectorButton3.Size = new System.Drawing.Size(53, 22);
			this.roomSelectorButton3.TabIndex = 4;
			this.roomSelectorButton3.Text = "5x5";
			this.roomSelectorButton3.UseVisualStyleBackColor = true;
			// 
			// roomSelectorButton2
			// 
			this.roomSelectorButton2.Location = new System.Drawing.Point(5, 19);
			this.roomSelectorButton2.Name = "roomSelectorButton2";
			this.roomSelectorButton2.Size = new System.Drawing.Size(53, 22);
			this.roomSelectorButton2.TabIndex = 3;
			this.roomSelectorButton2.Text = "4x4";
			this.roomSelectorButton2.UseVisualStyleBackColor = true;
			// 
			// roomSelectorButton1
			// 
			this.roomSelectorButton1.Checked = true;
			this.roomSelectorButton1.Location = new System.Drawing.Point(5, 1);
			this.roomSelectorButton1.Name = "roomSelectorButton1";
			this.roomSelectorButton1.Size = new System.Drawing.Size(53, 22);
			this.roomSelectorButton1.TabIndex = 2;
			this.roomSelectorButton1.TabStop = true;
			this.roomSelectorButton1.Text = "3x5";
			this.roomSelectorButton1.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(897, 736);
			this.Controls.Add(this.roomSizeSelectorPanel);
			this.Controls.Add(this.roomSizeLabel);
			this.Controls.Add(this.activateHeroButton4);
			this.Controls.Add(this.activateHeroButton3);
			this.Controls.Add(this.heroesSelectorPanel);
			this.Controls.Add(this.activateHeroButton1);
			this.Controls.Add(this.activateHeroButton2);
			this.Controls.Add(this.baddieSelectorPanel);
			this.Controls.Add(this.numberOfHeroesLabel);
			this.Controls.Add(this.numberOfBaddiesLabel);
			this.Controls.Add(this.gameOverButton);
			this.Controls.Add(this.scoreTextBox);
			this.Controls.Add(this.scoreLabel);
			this.Controls.Add(this.rangedCombatButton);
			this.Controls.Add(this.successfulFightButton);
			this.Controls.Add(this.rightTurnButton);
			this.Controls.Add(this.leftTurnButton);
			this.Controls.Add(this.failedFightButton);
			this.Controls.Add(this.outOfBoundsButton);
			this.Controls.Add(this.startButton);
			this.Controls.Add(this.forwardButton);
			this.Controls.Add(this.closeCombatButton);
			this.Controls.Add(this.pictureBox1);
			this.Name = "MainForm";
			this.Text = "Graphics Tester";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.baddieSelectorPanel.ResumeLayout(false);
			this.heroesSelectorPanel.ResumeLayout(false);
			this.roomSizeSelectorPanel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.RadioButton roomSelectorButton1;
		private System.Windows.Forms.RadioButton roomSelectorButton2;
		private System.Windows.Forms.RadioButton roomSelectorButton3;
		private System.Windows.Forms.Panel roomSizeSelectorPanel;
		private System.Windows.Forms.Label roomSizeLabel;
		private System.Windows.Forms.Button activateHeroButton4;
		private System.Windows.Forms.Button activateHeroButton3;
		private System.Windows.Forms.RadioButton baddieSelectorButton4;
		private System.Windows.Forms.RadioButton baddieSelectorButton5;
		private System.Windows.Forms.RadioButton baddieSelectorButton6;
		private System.Windows.Forms.Button activateHeroButton1;
		private System.Windows.Forms.RadioButton heroSelectorButton4;
		private System.Windows.Forms.RadioButton heroSelectorButton1;
		private System.Windows.Forms.RadioButton heroSelectorButton2;
		private System.Windows.Forms.RadioButton heroSelectorButton3;
		private System.Windows.Forms.Panel heroesSelectorPanel;
		private System.Windows.Forms.RadioButton baddieSelectorButton1;
		private System.Windows.Forms.RadioButton baddieSelectorButton2;
		private System.Windows.Forms.RadioButton baddieSelectorButton3;
		private System.Windows.Forms.Panel baddieSelectorPanel;
		private System.Windows.Forms.Label numberOfHeroesLabel;
		private System.Windows.Forms.Label numberOfBaddiesLabel;
		private System.Windows.Forms.Timer gameClock;
		private System.Windows.Forms.Button gameOverButton;
		private System.Windows.Forms.Button activateHeroButton2;
		private System.Windows.Forms.TextBox scoreTextBox;
		private System.Windows.Forms.Label scoreLabel;
		private System.Windows.Forms.Button rangedCombatButton;
		private System.Windows.Forms.Button successfulFightButton;
		private System.Windows.Forms.Button rightTurnButton;
		private System.Windows.Forms.Button leftTurnButton;
		private System.Windows.Forms.Button failedFightButton;
		private System.Windows.Forms.Button outOfBoundsButton;
		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.Button closeCombatButton;
		private System.Windows.Forms.Button forwardButton;
		private System.Windows.Forms.PictureBox pictureBox1;
		
		}
	}

