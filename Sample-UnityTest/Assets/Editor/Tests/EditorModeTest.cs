using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class EditorModeTest
{

	[Test]
	public void SimplePasses()
	{
		int a = 1;
		int b = 2;

		UnityEngine.Assertions.Assert.IsTrue(a==b, "aとbが同じではないよ");
	}

	// [UnityTest] はPlayModeのコルーチンのように動きます
	// ただし、EditModeではyield nullでフレームをスキップすることしかできません
	[UnityTest]
	public IEnumerator EnumeratorPasses()
	{
		int a = 1;
		int b = 2;

		yield return null;

		NUnit.Framework.Assert.IsTrue(a==b, "aとbが同じではないよ");
	}
}
