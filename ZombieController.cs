using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

	private int EnemyHealth = 100;
	private int EnemyDamage = 40;
	private int SpawnRate = 0;
    private int ZombieRange = 2;
	

    [SerializeField]
    private int Round = 0;

    void Start(){
        
	    if (Round <= 0)
        {
            RoundStart + 1;
        }
    }
		

	void Update(){
	
        RaycastHit hit;
	    Ray ray = new ray(transform.position, transform.forward);
	    if(Physics.Raycast(ray, out hit, ZombieRange))
        {
            ApplyDamage();
        }
    }


    public void ApplyDamage(){
            
            PlayerHealth = PlayerHealth -= 40;
        
        }

    public void SpawnZombie()
    {
        if (RoundStart
    }

}