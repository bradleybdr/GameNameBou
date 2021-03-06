﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCode : MonoBehaviour {

    public float range;
    public Transform Player;
    public float speed;
    public GameObject bulletPrefab;
    public float shootingCooldown;
    public float timeBetweenShots;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float step = speed * Time.deltaTime;
		if(Vector2.Distance(Player.position, transform.position) <= range)
        {
            //transform.Translate(Vector2.MoveTowards(transform.position, -Player.position, 0) * Time.deltaTime);
            transform.position = Vector2.MoveTowards(transform.position, Player.position, step);

            if(shootingCooldown <= 0)
            {
                //Create bullet
                GameObject clone = Instantiate(bulletPrefab, transform.position, transform.rotation);
                shootingCooldown = timeBetweenShots;
            }
            else
            {
                //reduce cooldown
                shootingCooldown = shootingCooldown - 1;
            }
        }
	}
}
