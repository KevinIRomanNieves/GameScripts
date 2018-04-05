//Se puede utilizar sistemas de collicion y auto generacion de objetos con esta librerias
using System.Collections;
using System.Collections.Generic;
//Libreria para poder interpresar las palabras predeterminadas por el Engine de Unity
using UnityEngine;

public class BackgroundMoveScript : MonoBehaviour
{

	//Indica un rango de movimiento de 1 a 20f en el cual tendra lugar el movimiento 
	//Es el Esenario en el cual el background estara moviendose se incrementara por uno
	[Range(1f, 20f)]
	public float scrollSpeed = 1f;

	
	//Hace que el valor del scrollOffset se repita 
	public float scrollOffset;

	// Posicion de inicio del movimiento en x del background
	Vector2 startPos;

	// Nueva posicion de inicio del Backgrounds 
	float newPos;

	
	void Start ()
	{
		// Hace que el background empiezen el la posicion de inicio
		startPos = transform.position;
	}
	
	// Se llama la funcion por frames
	void Update () 
	{
		// Calcula la nueva posicion del background y lo repite dependiendo del  scrollOffset que tenia un rango de 1f a 20f
		newPos = Mathf.Repeat (Time.time * - scrollSpeed, scrollOffset);

		// Se encarga de hacer la iteracion para asignar la nueva posicion del background
		transform.position = startPos + Vector2.right * newPos;
	}
}
