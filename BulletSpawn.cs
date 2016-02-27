using UnityEngine;
using System.Collections;

public class BulletSpawn : MonoBehaviour {

    public GameObject bullet;
    public GameObject bulletHole;
    public float delayTime;
    
    private float counter = 0;

	void Start () {
	
	}
	
	void FixedUpdate () {
	if (Input.GetMouseButtonDown(0) && counter > delayTime)
        {
            GetComponent<AudioSource>().Play();
            Instantiate(bullet, transform.position, transform.rotation);
            counter = 0;
            
            RaycastHit hit;
            Ray ray = new Ray(transform.position, transform.forward);
            if(Physics.Raycast(ray, out hit, 100f))
            {
                Instantiate(bulletHole, hit.point, Quaternion.FromToRotation(Vector3.up, hit.normal));
            }
        
            if(hit.collider.tag == "Enemy")
            {
                ApplyDamage();
            }
        }
        counter += Time.deltaTime;
    }
}
