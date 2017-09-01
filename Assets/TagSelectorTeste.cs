using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TagSelectorTeste : MonoBehaviour {

	[TagSelector]
	public string MinhaTag;

	private void Update()
	{
		gameObject.tag = MinhaTag;
	}


}
