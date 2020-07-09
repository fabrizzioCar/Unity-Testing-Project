using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguiCamara : MonoBehaviour
{
    // Start is called before the first frame update
   public GameObject follow;
	public Vector2  Mincampo, Maxcampo;

	void Start () {
		
	}
	
	void FixedUpdate () {
		float posX = follow.transform.position.x;
		float posY = follow.transform.position.y;

		transform.position = new Vector3(
			Mathf.Clamp(posX,Mincampo.x, Maxcampo.x),
			Mathf.Clamp(posY,Mincampo.y, Maxcampo.y),
			 transform.position.z);
	}
}
