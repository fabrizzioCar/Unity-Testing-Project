using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguiCamara : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject follow;

	void Start () {
		
	}
	
	void FixedUpdate () {
		float posX = follow.transform.position.x;
		float posY = follow.transform.position.y;

		transform.position = new Vector3(posX, posY,transform.position.z);
	}
}
