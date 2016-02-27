using UnityEngine;
using System.Collections;

public class Anims : MonoBehaviour {
    public Animator anim;
    
     // Use this for initialization
	void Start () {
	 anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	    
        //Show.Cursor = false;
        
        if (Input.GetKeyDown("w"))
        {       
        anim.SetFloat("Walk", 0.2f);
        }
	
        if (Input.GetKeyUp("w"))
        {       
        anim.SetFloat("Walk", 0f);
        }
    
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {       
        anim.SetFloat("Sprint", 0.2f);
        }
    
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {       
        anim.SetFloat("Sprint", 0f);
        }
    
        if (Input.GetMouseButtonDown(0))
        {       
        anim.Play("Shoot");
        }
    }
}
