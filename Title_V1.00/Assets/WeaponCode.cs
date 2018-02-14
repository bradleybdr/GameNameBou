using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponCode : MonoBehaviour {

    public float range;
    public Transform Player;

    public GameObject bulletPrefab;

    public float shootCooldown;
    public float shootTime;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Vector2.Distance(Player.position, transform.position) <= range)
        {
            //if player in range, determine shooting path and create projectile

           if(shootCooldown <= 0)
            {
                Vector2 shootingAngle = Player.position - transform.position;

                GameObject clone = Instantiate(bulletPrefab, transform.position, transform.rotation);

                if (shootingAngle.x < 0)
                {
                    if (shootingAngle.y > 0)
                    {
                        //shoot up to the left
                        


                    }
                    else if (shootingAngle.y == 0)
                    {
                        //shoot direcly to the left
                    }
                    else if (shootingAngle.y < 0)
                    {
                        //shoot down to the left
                    }

                }
                else if (shootingAngle.x == 0)
                {
                    if (shootingAngle.y > 0)
                    {
                        //shoot directly up
                    }
                    else if (shootingAngle.y < 0)
                    {
                        //shoot direcly down
                    }

                }
                else if (shootingAngle.x > 0)
                {
                    if (shootingAngle.y > 0)
                    {
                        //shoot up and to the right
                    }
                    else if (shootingAngle.y == 0)
                    {
                        //shoot directly right
                    }
                    else if (shootingAngle.y < 0)
                    {
                        //shoot down and to the right
                    }
                }

                shootCooldown = shootTime;
            }
           else
            {
                shootCooldown = shootCooldown - 1;
            }

        }
    }
}
