using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    private int PlayerHealth  = 100;
    private int MP443Damage = 40;
    
    void Start () {
	
	}

	void Update () {
	
	}

    public void ApplyDamage()
    {
        EnemyHealth -= WeaponDamage();
    }

    public void WeaponDamage()
    {
        //CurrentWeaponDamage = 
    }

}
