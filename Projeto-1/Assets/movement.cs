using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

	public float velocity = 1f;
	private float positionx = -5f;


	// Use this for initialization
	void Start () {

		//Definindo a posicao inicial do objeto
		transform.position = new Vector3(positionx, 0, 0);

	}
	
	// Update is called once per frame
	void Update () {

		//Atualizacao da posicao em x
		positionx = positionx + velocity*Time.deltaTime;
		transform.position = new Vector3(positionx, 0, 0);


	}
}
