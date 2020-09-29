using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;
public class EnemyMoveTest
namespace Tests{
{
	public void CalculateTotalEnemyMovement_Test(){
		var enemyMove= new EnemyMove();
		var points=10;
		var expectedOutput= 20;
		var count = enemyMove.CalculateTotalEnemyMovement(points);
		Assert.That(points, Is.EqualTo(expectedOutput));
	}
}
}