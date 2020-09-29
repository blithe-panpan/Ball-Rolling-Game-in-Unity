using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class HealthTest
    {
		public void numOfLives_Test(){
			//ARRANGE
			var health = new Health();
			var numberOfLives =10;
			var expectedOutput = 20;

			//ACT
			var points=health.numOfLives(numberOfLives);

			//ASSERT
			Assert.That(points, Is.EqualTo(expectedOutput));
		}
		public void Alive_Test(){
			//ARRANGE
			var health = new Health();
			var value =true;
			var expectedOutput = true;

			//ACT
			var flag=health.Alive(value);

			//ASSERT
			Assert.That(flag, Is.EqualTo(expectedOutput));
		}
    }
}
