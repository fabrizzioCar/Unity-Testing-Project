using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SeguiCamara : MonoBehaviour
{
    // Start is called before the first frame update
   	public GameObject follow;
	public Vector2  Mincampo, Maxcampo;
	
	public Text item;
	public GameObject items;


	private int total;
	//private int Puntaje;
	//private int tt=0;
	private int recepcion;

	//void Start () {
	//	Puntaje=EstadoCompartir.estadoComr.cont;
	//	total=items.transform.childCount;
	//}
	//void Update () {
	//	recepcion=total-items.transform.childCount;
	//	tt = Puntaje + recepcion*50;
	//	EstadoCompartir.estadoComr.cont=tt;
	//	enunciado.text= tt.ToString();
	//}
	void Start(){
		total=items.transform.childCount;
	}
	void Update(){
		recepcion=(total-items.transform.childCount)*50;
		item.text=recepcion.ToString();
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
