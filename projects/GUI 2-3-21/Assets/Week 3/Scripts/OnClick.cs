using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick : MonoBehaviour

{
	[SerializeField] private GameObject;
	void Start()
	{
		renderer.material.color = Color.black;
	}

	void OnMouseEnter()
	{
		renderer.material.color = Color.red;
	}

	void OnMouseExit()
	{
		renderer.material.color = Color.black;
	}
}
