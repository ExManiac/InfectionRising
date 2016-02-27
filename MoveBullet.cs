using UnityEngine;
using System.Collections;

public class MoveBullet : MonoBehaviour {

	public float speed;
    
    void Start () {
	
	}
	
	void Update () {
	transform.Translate(0, 0, speed);
	}
}
