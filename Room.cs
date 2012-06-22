/*
 * Created by SharpDevelop.
 * User: ed
 * Date: 12/03/2012
 * Time: 09:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace MoveAndFight
{
	/// <summary>
	/// Room in which amazing action takes place.
	/// </summary>
	public class Room
	{
		int pixelsX;
		int pixelsY;
		
		public Room(int squaresX, int squaresY)
		{
			this.pixelsX = squaresX*100;
			this.pixelsY = squaresY*100;
		}
		
		public Boolean WallCollision(Character character, Direction direction)
		{
			Boolean result = false;
			if (direction == Direction.North && character.location.Y == 0
			    || direction == Direction.East && character.location.X == this.pixelsX - 100
			    || direction == Direction.South && character.location.Y == this.pixelsY - 100
			    || direction == Direction.West && character.location.X == 0)
			{
				result = true;
			}
			return result;
		}
	}
}
