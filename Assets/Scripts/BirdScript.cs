using UnityEngine;
using System.Collections;

public class BirdScript : MonoBehaviour {

//Respuestas parte 1: 4,6,5,3,1,2

	public float jumpForce = 100 ;
	public Rigidbody2D rb;
	public float forwardSpeed = 2;
	public GameObject cam;
	public bool dead = false;
	
	// Use this for initialization
	void Start () {
	rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
	
	if (dead== false){
		
	
	rb.transform.Translate(new Vector3(1,0,0)*forwardSpeed*Time.deltaTime);
	cam.transform.Translate(new Vector3(1,0,0)*forwardSpeed*Time.deltaTime);
	
	 if (Input.GetButtonDown("Jump"))
	 {
	 rb.velocity = Vector2.zero;
	 rb.AddForce(Vector2.up * jumpForce);
	 }
	 
	 if (rb.transform.position.x >17){
		 dead = true; 
	 }
	 
	}
	
	}
	
	//pos final x = 17 
	
	private void OnCollisionEnter2D(Collision2D collision){
		dead= true;
	}
	
}
