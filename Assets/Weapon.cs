using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

	public GameObject gunBarrel;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {

			Fire ();
		}
	}

	void Fire()
	{
		RaycastHit hit;

		if (Physics.Raycast(gunBarrel.transform.position, gunBarrel.transform.forward, out hit))
		{
			if(hit.collider.tag == "Enemy")
			{
				print ("Hit : " + hit.collider.gameObject.name);
			}
		}
	}

}


