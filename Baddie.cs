/*
 * Created by SharpDevelop.
 * User: ed
 * Date: 08/03/2012
 * Time: 11:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;

namespace MoveAndFight
{
	/// <summary>
	/// Baddie extends Character and represents the forces of evil.
	/// </summary>
	/// 
	public class Baddie : Character
	{
		public Baddie(Point location) : base (location)
		{
			
		}
		
		public void Move(Direction moveDirection)
		{
			switch (moveDirection)
			{
				case Direction.North: this.location.Y -= 100; break;
				case Direction.East: this.location.X += 100; break;
				case Direction.South: this.location.Y += 100; break;
				case Direction.West: this.location.X -= 100; break;
			}
			
		}
	}
}
