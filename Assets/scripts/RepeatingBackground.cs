using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{
	
	private BoxCollider2D groundCollider;
	private float ghl;
    // Start is called before the first frame update
    void Start()
    {
        groundCollider = GetComponent<BoxCollider2D>();
		ghl = groundCollider.size.x;	
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -ghl)
			reposition();
    }
	
	private void reposition(){
		Vector2 grdoffset = new Vector2(ghl*2f,0);
		transform.position = (Vector2)transform.position+grdoffset;
		
	}
}
