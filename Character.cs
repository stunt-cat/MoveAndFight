/*
 * Created by SharpDevelop.
 * User: ed
 * Date: 08/03/2012
 * Time: 10:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;

namespace MoveAndFight
{
	
	public enum Direction {North, East, South, West};
	
	/// <summary>
	/// Character contains members common to both Hero and Baddie, which inherit from it.
	/// N.B. Hero and Baddie use Direction for different operations.
	/// </summary>
	
	public abstract class Character
	{
		public Point location;
		
		public Character(Point location)
		{
			this.location = location;
		}
	
	}
}
