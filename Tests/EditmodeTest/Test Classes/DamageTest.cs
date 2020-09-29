using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class DamageTest
    {
		[Test]
		public void calculateDamage_Test(){
			//ARRANGE
			var damage = new Damage();
			var damageDone =5f;
			var count=10f;
			var expectedOutput = 20f;

			//ACT
			var points=damage.calculateDamage(damageDone,count);

			//ASSERT
			Assert.That(points, Is.EqualTo(expectedOutput));
		}
    }
}
