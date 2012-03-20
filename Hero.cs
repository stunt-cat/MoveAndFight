/*
 * Created by SharpDevelop.
 * User: ed
 * Date: 06/03/2012
 * Time: 10:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;


namespace MoveAndFight
{
	/// <summary>
	/// Hero extends Character and represents the forces of good.
	/// </summary>
	public class Hero : Character
	{
		public Direction facing;
		public int number;
		
		public Hero(Point location, Direction facing, int number) : base (location)
		{
			this.facing = facing;
			this.number = number;
		}
		
		public void TurnLeft()
		{
			switch (this.facing)
			{
				case Direction.North: this.facing = Direction.West; break;
				case Direction.East: this.facing = Direction.North; break;
				case Direction.South: this.facing = Direction.East; break;
				case Direction.West: this.facing = Direction.South; break;
			}
		}
		
		public void TurnRight()
		{
			switch (this.facing)
			{
				case Direction.North: this.facing = Direction.East; break;
				case Direction.East: this.facing = Direction.South; break;
				case Direction.South: this.facing = Direction.West; break;
				case Direction.West: this.facing = Direction.North; break;
			}
		}
		
		public void MoveForward()
		{
			switch (this.facing)
			{
				case Direction.North: this.location.Y -= 100; break;
				case Direction.East: this.location.X += 100; break;
				case Direction.South: this.location.Y += 100; break;
				case Direction.West: this.location.X -= 100; break;
			}
		}
	}
}
