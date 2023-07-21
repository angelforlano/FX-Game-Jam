using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotPart : MonoBehaviour
{


	public string part;

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			var player = other.gameObject.GetComponent<Player>();
			player.AddPart(part);
			//Destroy(gameObject);
		}
	}
}