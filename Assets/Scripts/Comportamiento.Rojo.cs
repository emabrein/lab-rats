using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
	{
		// Si se ha pulsado, modificar velocidad hacia arriba con una fuerza de 5
		myRigidbody.velocity  =  Vector2.up  *  5.0f;
    }
    if (Input.GetKeyDown(KeyCode.W))
	{
		// Si se ha pulsado, modificar velocidad hacia arriba con una fuerza de 5
		myRigidbody.velocity  =  Vector2.up  *  5.0f;
}
