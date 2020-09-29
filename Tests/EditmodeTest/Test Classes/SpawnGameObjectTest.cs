using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class SpawnGameObjectTest
    {
        // A Test behaves as an ordinary method
        [Test]
		public void spawnTimimg_Test(){
			//ARRANGE
			var spawnGameObject = new SpawnGameObject();
			var min =5f;
			var max=10f;
			var expectedOutput = 5f;

			//ACT
			var points=spawnGameObject.spawnTimimg(min,max);

			//ASSERT
			Assert.That(points, Is.EqualTo(expectedOutput));
		}
    }
}
