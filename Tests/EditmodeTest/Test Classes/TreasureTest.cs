using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class TreasureTest
    {
        // A Test behaves as an ordinary method
        [Test]
		public void treasureValue_Test(){
			//ARRANGE
			var treasure = new Treasure();
			var value =5;
			var expectedOutput = 10;

			//ACT
			var points=treausure.treasureValue(value);

			//ASSERT
			Assert.That(points, Is.EqualTo(expectedOutput));
		}
    }
}
