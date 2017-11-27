using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;

    private Rigidbody rb;
	private Auxiliar aux;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
		aux = new Auxiliar ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //before performing any physics calculation
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

		speed = aux.GivemeSomething ();
		rb.AddForce(movement*speed);
    }
}
