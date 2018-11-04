using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class PlayModeTest
{

	[Test]
	public void NewTestScriptSimplePasses() {
		// Use the Assert class to test conditions.
	}


	[UnityTest]
	public IEnumerator EnumeratorPasses()
	{
		var gameObject = new GameObject();
		var testComponent = gameObject.AddComponent<TestComponent>();

		Assert.AreEqual(testComponent.Counter, 0);

		yield return null;

		Assert.AreEqual(testComponent.Counter, 1);
	}
}
