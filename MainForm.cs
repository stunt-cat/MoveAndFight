/*
 * Created by SharpDevelop.
 * User: ed
 * Date: 24/02/2012
 * Time: 15:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using System.Resources;
using System.Timers;
using System.Linq;

namespace MoveAndFight
{
	/// <summary>
	/// MainForm is where all the jazz goes down.
	/// </summary>
	

	public partial class MainForm : Form
	{
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//	
		}
		
		// list populated in StartButtonClick(), from user parameters
		public List<Character> heroes;
		Hero activeHero;
		int numberOfHeroes;
		
		// list populated in StartButtonClick(), from user parameters
		public List<Character> baddies;
		Baddie activeBaddie;
		int numberOfBaddies;
		public Direction baddieMoveDirection;
		
		public IEnumerable<Character> everybody;
		public Point shotLocation;
		public Character shotVictim;
		
		// Create Room for action to take place in
		// TODO get user selected values for variable game setup
		// i.e.
		// int roomSquaresX;  (get from user input - form element to be created)
		// int roomSquaresY;  (get from user input - form element to be created)
		//
		// Room room = new Room(roomSquaresX, roomSquaresY);
		
		ResourceManager resources = new ResourceManager("MoveAndFight.images", Assembly.GetExecutingAssembly());
		private System.Drawing.Graphics g;
		private System.Drawing.Pen pen1 = new System.Drawing.Pen(Color.Blue, 7F);
		private System.Drawing.Pen pen2 = new System.Drawing.Pen(Color.Red, 10F);
		private System.Drawing.Pen pen3 = new System.Drawing.Pen(Color.Magenta, 10F);
		
		public int score = 0;
		Random random = new Random();
		
		
		void StartButtonClick(object sender, EventArgs e)
		{
			
			// Get numberOfBaddies from RadioBox in baddieSelectorPanel
			if (baddieSelectorButton1.Checked) numberOfBaddies = 1;
			else if (baddieSelectorButton2.Checked) numberOfBaddies = 2;
			else if (baddieSelectorButton3.Checked) numberOfBaddies = 3;
			else if (baddieSelectorButton4.Checked) numberOfBaddies = 4;
			else if (baddieSelectorButton5.Checked) numberOfBaddies = 5;
			else if (baddieSelectorButton6.Checked) numberOfBaddies = 6;
			
			baddies = new List<Character>(numberOfBaddies);
			
			// Get numberOfHeroes from RadioBox in heroSelectorPanel
			if (heroSelectorButton1.Checked) numberOfHeroes = 1;
			else if (heroSelectorButton2.Checked) numberOfHeroes = 2;
			else if (heroSelectorButton3.Checked) numberOfHeroes = 3;
			else if (heroSelectorButton4.Checked) numberOfHeroes = 4;
			
			heroes = new List<Character>(numberOfHeroes);
			
			// Randomly select hero start point(s), ensuring there are no conflicts with other heroes (N.B. no baddies exist at this point)
			for (int i = 0; i < numberOfHeroes; i++)
			{
				Point bufferLocation = RandomLocation();
				Boolean pointAvailable = true;
				
				// Check other Hero locations and reassign bufferLocation until it is an available location
				if(heroes.Count>0){
					do{
						// Assume location is initially free
						pointAvailable = true;
						foreach (Character hero in heroes)
						{
							if (bufferLocation == hero.location)
							{
								// If location not free, choose another and check everybody again
								bufferLocation = RandomLocation();
								pointAvailable = false;
								break;
							}
						}
					} while (!pointAvailable);	
				}
				
				// bufferLocation is available, so assign it to new Hero
				heroes.Add(new Hero (bufferLocation, (Direction) random.Next(4), i+1));
			}
			
			// Randomly select baddie start point(s), ensuring there are no conflicts with heroes or other baddies
			AssignBaddieLocations();
			
			// Assign active hero (green/1)
			activeHero = (Hero) heroes[0];
			
			gameClock.Start();
			gameClock.Tick += new EventHandler(GameTimeUp);
			ResetGame();
			
		}

		// This method is called from multiple locations, so is not part of StartButtonClick() (unlike Hero location assignment)
		void AssignBaddieLocations()
			{
			// Only assigns location if it is not occupied already by hero or preceding baddie
			for (int i = 0; i < numberOfBaddies; i++) {
				
				Point bufferLocation = RandomLocation();
				Boolean pointAvailable = true;
				IEnumerable<Character> everybody = heroes.Concat(baddies);
				
				// Check other locations and reassign bufferLocation until it is an available location
				do{
					// Assume location is initially free
					pointAvailable = true;
					foreach (Character anybody in everybody)
					{
						if (bufferLocation == anybody.location)
						{
							// If location not free, chooose another and check everybody again
							bufferLocation = RandomLocation();
							pointAvailable = false;
							break;
						}
					}
				} while (!pointAvailable);
					
				// bufferLocation is available, so assign it to new Baddie
				baddies.Add(new Baddie (bufferLocation));
			}
		}
		
		public Point RandomLocation()
		{
			// TODO make this generic by passing in Room size to the 'Next(x)', when Room class is up and running
			Point randomPoint = new Point(random.Next(5)*100, random.Next(5)*100);
			return randomPoint;
		}
		
		void ResetGame()
		{
			baddieSelectorPanel.Visible = false;
			heroesSelectorPanel.Visible = false;
			gameOverButton.Visible = false;
			startButton.Visible = false;
			forwardButton.Enabled = true;
			leftTurnButton.Enabled = true;
			rightTurnButton.Enabled = true;
			closeCombatButton.Enabled = true;
			rangedCombatButton.Enabled = true;
			drawHeroSelectorButtons(numberOfHeroes);	
			DrawLocation();
		}
		
		private void drawHeroSelectorButtons(int i)
		{
			// Display correct active hero selector buttons for number of heroes
			switch (i)
			{	
				case 1 : break;
				case 2 : activateHeroButton1.Visible = true;
				activateHeroButton1.Enabled = true;
				activateHeroButton2.Visible = true;
				activateHeroButton2.Enabled = true;
				break;
				
				case 3 : 
				activateHeroButton3.Visible = true;
				activateHeroButton3.Enabled = true;
				goto case 2;
				
				case 4: 
				activateHeroButton4.Visible = true;
				activateHeroButton4.Enabled = true;
				goto case 3;
			}
		}
		
		private void DrawLocation()
		{
			pictureBox1.Refresh();
			g = pictureBox1.CreateGraphics();
			
			// Draw baddie(s)
			foreach (Baddie baddie in baddies) {
				g.DrawImageUnscaled((Bitmap)resources.GetObject("baddie"), baddie.location);
			}    
			
			// Draw hero(es)
			foreach (Hero hero in heroes) {
				string arrow = string.Format("hero_{0}_{1}", hero.facing.ToString().ToLower(), hero.number.ToString());
				g.DrawImageUnscaled((Bitmap)resources.GetObject(arrow), hero.location);
			}                                       
		}
		
		void ActivateHeroButton1Click(object sender, EventArgs e)
		{
			leftTurnButton.Image = global::MoveAndFight.Images.arrow_leftturn_1;
			rightTurnButton.Image = global::MoveAndFight.Images.arrow_rightturn_1;
			forwardButton.Image = global::MoveAndFight.Images.arrow_north_1;
			activeHero = (Hero) heroes[0];
		}
		
		void ActivateHeroButton2Click(object sender, EventArgs e)
		{
			leftTurnButton.Image = global::MoveAndFight.Images.arrow_leftturn_2;
			rightTurnButton.Image = global::MoveAndFight.Images.arrow_rightturn_2;
			forwardButton.Image = global::MoveAndFight.Images.arrow_north_2;
			activeHero = (Hero) heroes[1];
		}
		
		void ActivateHeroButton3Click(object sender, EventArgs e)
		{
			leftTurnButton.Image = global::MoveAndFight.Images.arrow_leftturn_3;
			rightTurnButton.Image = global::MoveAndFight.Images.arrow_rightturn_3;
			forwardButton.Image = global::MoveAndFight.Images.arrow_north_3;
			activeHero = (Hero) heroes[2];
		}

		void ActivateHeroButton4Click(object sender, EventArgs e)
		{
			leftTurnButton.Image = global::MoveAndFight.Images.arrow_leftturn_4;
			rightTurnButton.Image = global::MoveAndFight.Images.arrow_rightturn_4;
			forwardButton.Image = global::MoveAndFight.Images.arrow_north_4;
			activeHero = (Hero) heroes[3];
		}
		
		void ForwardButtonClick(object sender, System.EventArgs e)
		
		{
			Boolean moveProblem = false;
				
			// Check hero isn't trying to walk into a wall
			if (activeHero.facing == Direction.North && activeHero.location.Y == 0
		    || activeHero.facing == Direction.East && activeHero.location.X == 400
		    || activeHero.facing == Direction.South && activeHero.location.Y == 400
		    || activeHero.facing == Direction.West && activeHero.location.X == 0)
			{
				moveProblem = true;
			}
			
			// Check hero isn't trying to walk into baddie(s) or other hero(es)
			everybody = heroes.Concat(baddies);
			foreach (Character anybody in everybody)
			{
				if (!CheckAdjacencyAvailable(activeHero.facing, activeHero.location, anybody.location))
				{
				moveProblem = true;
				break;
				}
			}
			
			if(moveProblem)
			{
				OutOfBounds();
				DrawLocation();
			} else
			{
				// Move is okay to execute!
				activeHero.MoveForward();
				
				// Possibly move baddie also! (1/2 chance for each baddie)
				if (random.Next(2) == 0) MoveBaddie();
				
				DrawLocation();
			}
			
		}
		
		void MoveBaddie()
		{
			// N.B. Baddies only have one chance to move - if the baddieMoveDirection turns out to not be possible
			// 		the baddie doesn't move i.e. they don't get to keep trying directions until they can move.
			
			everybody = heroes.Concat(baddies);
			
			foreach (Baddie movingBaddie in baddies)
			{
				Boolean moveProblem = false;
				
				// Choose direction for baddie
				baddieMoveDirection = (Direction)(random.Next(4));
				
				// Check no wall
				if (baddieMoveDirection == Direction.North && movingBaddie.location.Y == 0
				    || baddieMoveDirection == Direction.East && movingBaddie.location.X == 400
				    || baddieMoveDirection == Direction.South && movingBaddie.location.Y == 400
				    || baddieMoveDirection == Direction.West && movingBaddie.location.X == 0)
				{
					moveProblem = true;
				}
				
				// check baddie isn't trying to walk into baddie(s) or hero(es)
				foreach (Character anybody in everybody)
				{
					if (!CheckAdjacencyAvailable(baddieMoveDirection, movingBaddie.location, anybody.location))
					{
					moveProblem = true;
					break;
					}
				}
				
				if(!moveProblem)
				{
					// Move is okay to execute!
					movingBaddie.Move(baddieMoveDirection);
					DrawLocation();
					
					// N.B. If (moveProblem) movingBaddie doesn't move
				} 
			}
		}
		
		Boolean CheckAdjacencyAvailable(Direction intendedDirection, Point startLocation, Point intendedLocation)
		{
			
			Boolean result = true;
			switch (intendedDirection)
			{
					case Direction.North: if((intendedLocation.X == startLocation.X) && (intendedLocation.Y == startLocation.Y -100)) result = false; break;
					case Direction.East: if((intendedLocation.Y == startLocation.Y) && (intendedLocation.X == startLocation.X +100)) result = false; break;
					case Direction.South: if((intendedLocation.X == startLocation.X) && (intendedLocation.Y == startLocation.Y +100)) result = false; break;
					case Direction.West: if((intendedLocation.Y == startLocation.Y) && (intendedLocation.X == startLocation.X -100)) result = false; break;
			}
			return result;
		}
		
		private void OutOfBounds()
		{
			outOfBoundsButton.Visible = true;
			forwardButton.Enabled = false;
			leftTurnButton.Enabled = false;
			rightTurnButton.Enabled = false;
			closeCombatButton.Enabled = false;
			activateHeroButton2.Enabled = false;
		}
		
		void OutOfBoundsButtonClick(object sender, System.EventArgs e)
		{
			outOfBoundsButton.Visible = false;
			forwardButton.Enabled = true;
			leftTurnButton.Enabled = true;
			rightTurnButton.Enabled = true;
			closeCombatButton.Enabled = true;
			activateHeroButton2.Enabled = true;
			DrawLocation();
		}
		
		void LeftTurnButtonClick(object sender, EventArgs e)
		{
			activeHero.TurnLeft();
			DrawLocation();
		}
		
		void RightTurnButtonClick(object sender, EventArgs e)
		{
			activeHero.TurnRight();
			DrawLocation();
		}
		
		void FightButtonClick(object sender, System.EventArgs e)
		{
			forwardButton.Enabled = false;
			leftTurnButton.Enabled = false;
			rightTurnButton.Enabled = false;
			closeCombatButton.Enabled = false;
			rangedCombatButton.Enabled = false;

			// Find if there is a baddie adjacent to activeHero, and if so set activeBaddie to it
			activeBaddie = null;
			foreach (Baddie baddie in baddies)
			{
				switch(activeHero.facing){
					case Direction.North: if (!CheckAdjacencyAvailable(Direction.North, activeHero.location, baddie.location))
								activeBaddie = baddie; break;
					case Direction.East : if (!CheckAdjacencyAvailable(Direction.East, activeHero.location, baddie.location))
								activeBaddie = baddie; break;
					case Direction.South : if (!CheckAdjacencyAvailable(Direction.South, activeHero.location, baddie.location))
								activeBaddie = baddie; break;
					case Direction.West : if (!CheckAdjacencyAvailable(Direction.West, activeHero.location, baddie.location))
								activeBaddie = baddie; break;
				}
			}
			
			// If there is a baddie infront of activeHero, kill it
			if (activeBaddie !=null)
			{
				successfulFightButton.Visible = true;
				this.score += 5;
				scoreTextBox.Clear();
				scoreTextBox.Text = score.ToString();
				
				// Draw dead baddie
				g.DrawImageUnscaled((Bitmap) resources.GetObject("dead_baddie"), activeBaddie.location);
				g.DrawRectangle (pen2, activeBaddie.location.X, activeBaddie.location.Y, 100, 100);
				
				// Remove baddie from baddies
				baddies.Remove(activeBaddie);
			} else failedFightButton.Visible = true;
		}
		
		void SuccessfulFightButtonClick(object sender, EventArgs e)
		{
			successfulFightButton.Visible = false;
			if (baddies.Count == 0)
			{
				// Get more baddies! N.B. same number as initial user selection
				AssignBaddieLocations();
			}
			ResetGame();
		}
		
		
		void FailedFightButtonClick(object sender, EventArgs e)
		{
			failedFightButton.Visible = false;
			forwardButton.Enabled = true;
			leftTurnButton.Enabled = true;
			rightTurnButton.Enabled = true;
			closeCombatButton.Enabled = true;
			rangedCombatButton.Enabled = true;
			activateHeroButton2.Enabled = true;
			DrawLocation();
		}
		
		void RangedCombatButtonClick(object sender, EventArgs e)
		{
			shotLocation = activeHero.location;
			activeBaddie = null;
			shotVictim = null;
			everybody = heroes.Concat(baddies);
			
			// Shoot in straight line until hit wall or other Character. If Character encountered, decide outcome based on Type.
			
			switch(activeHero.facing)
			{
					case Direction.North: 
						while ((shotVictim == null) && (shotLocation.Y > 0))
							{
								foreach (Character potentialVictim in everybody)
								{
									if (!CheckAdjacencyAvailable(Direction.North, shotLocation, potentialVictim.location))
									{
										shotVictim = potentialVictim;
										break;
									}
								}
							g.DrawRectangle(pen1, shotLocation.X, shotLocation.Y - 100, 100, 100);
							shotLocation.Y -= 100;
						} break;
					case Direction.East:
						while ((shotVictim == null) && (shotLocation.X < 400))
							{
								foreach (Character potentialVictim in everybody)
								{
									if (!CheckAdjacencyAvailable(Direction.East, shotLocation, potentialVictim.location))
									{
										shotVictim = potentialVictim;
										break;
									}
								}
							g.DrawRectangle(pen1, shotLocation.X + 100, shotLocation.Y, 100, 100);
							shotLocation.X += 100;
						}						
						break;
					case Direction.South: 
						while ((shotVictim == null) && (shotLocation.Y < 400))
							{
								foreach (Character potentialVictim in everybody)
								{
									if (!CheckAdjacencyAvailable(Direction.South, shotLocation, potentialVictim.location))
									{
										shotVictim = potentialVictim;
										break;
									}
								}
							g.DrawRectangle(pen1, shotLocation.X, shotLocation.Y + 100, 100, 100);
							shotLocation.Y += 100;
						}
						break;
					case Direction.West: 
						while ((shotVictim == null) && (shotLocation.X > 0))
							{
								foreach (Character potentialVictim in everybody)
								{
									if (!CheckAdjacencyAvailable(Direction.West, shotLocation, potentialVictim.location))
									{
										shotVictim = potentialVictim;
										break;
									}
								}
							g.DrawRectangle(pen1, shotLocation.X - 100, shotLocation.Y, 100, 100);
							shotLocation.X -= 100;
						}
						break;
			}
			
			// If there is a shotVictim, check its type. If if it a Baddie, kill it! If it is a Hero, shot does nothing.
			if(shotVictim != null)
			{
				if (shotVictim.GetType() != activeHero.GetType())
				{
					activeBaddie = (Baddie) shotVictim;
					KillShot();
				} else FailShot();
			} else FailShot();
		}
		
		Boolean FreeLocation(Point location)
		{
			Boolean result = true;
			foreach (Character anybody in everybody)
			{
				if(location == anybody.location)
					result = false;
			}
			return result;
		}
		
		void KillShot()
		{
			g.DrawImageUnscaled((Bitmap) resources.GetObject("dead_baddie"), activeBaddie.location);
			g.DrawRectangle(pen3, shotLocation.X, shotLocation.Y, 100, 100);
			this.score += 3;
			scoreTextBox.Clear();
			scoreTextBox.Text = score.ToString();
			forwardButton.Enabled = false;
			leftTurnButton.Enabled = false;
			rightTurnButton.Enabled = false;
			closeCombatButton.Enabled = false;
			rangedCombatButton.Enabled = false;
			successfulFightButton.Visible = true;
			baddies.Remove(activeBaddie);
		}
		
		void FailShot()
		{
			forwardButton.Enabled = false;
			leftTurnButton.Enabled = false;
			rightTurnButton.Enabled = false;
			closeCombatButton.Enabled = false;
			rangedCombatButton.Enabled = false;
			activateHeroButton2.Enabled = false;
			failedFightButton.Visible = true;
		}
		
		void GameTimeUp(Object o, EventArgs e)
		{
			gameClock.Stop();
			GameOver();
		}
	
		public void GameOver()
		{
			forwardButton.Enabled = false;
			leftTurnButton.Enabled = false;
			rightTurnButton.Enabled = false;
			closeCombatButton.Enabled = false;
			rangedCombatButton.Enabled = false;
			
			// Fire ActivateHeroButton1Click event so correct movement buttons displayed if number of heroes goes from > 1 to 1.
			activateHeroButton1.PerformClick();
			
			// If game stops with the following buttons visible, then GameOver() will hide them
			successfulFightButton.Visible = false;
			outOfBoundsButton.Visible = false;
			failedFightButton.Visible = false;
			activateHeroButton1.Visible = false;
			activateHeroButton2.Visible = false;
			activateHeroButton3.Visible = false;
			activateHeroButton4.Visible = false;
			
			gameOverButton.Visible = true;
			gameOverButton.Enabled = true;
			gameOverButton.Text = "GAME OVER!\rYou scored " + score + "\r Click to play again!";
		}
		
		void GameOverButtonClick(object sender, EventArgs e)
		{
			this.score = 0;
			scoreTextBox.Clear();
			scoreTextBox.Text = score.ToString();
			startButton.Visible = true;
			heroesSelectorPanel.Visible = true;
			baddieSelectorPanel.Visible = true;
			gameOverButton.Visible = false;
		}
	}
}


