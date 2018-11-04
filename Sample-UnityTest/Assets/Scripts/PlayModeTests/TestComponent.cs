using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestComponent : MonoBehaviour
{
	public int Counter { get; private set; } = 0;

	void Start()
	{
		Counter = 1;
	}
}
