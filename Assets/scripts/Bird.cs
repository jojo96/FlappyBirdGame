using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
	public float upForce = 200.0f;
	private bool isDead = false;
	private Rigidbody2D rb2d;
	private Animator anim;
	
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
		rb2d.isKinematic = false;
		anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isDead == false){
			if(Input.GetMouseButton(0)){
				anim.SetTrigger("Flap");
				rb2d.velocity = Vector2.zero;
				rb2d.AddForce(new Vector2(0,upForce));
				
			}
		}
    }
	
	void OnCollisionEnter2D(){
		
		rb2d.velocity = Vector2.zero;
		//Debug.Log("Test");
		isDead = true;
		anim.SetTrigger("Die");
		GameControl.instance.BirdDied();
		//GameControl.instance.BirdDied ();
		
	}
	
}
