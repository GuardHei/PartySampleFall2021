﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : Weapon
{
    public override void Shoot(Transform start)
    {
        fireTime -= Time.deltaTime;
        if (fireTime <= 0)
        {
            fireTime = fireRate;
            Debug.Log("shotgun shoot");
            var b = Instantiate(bulletPrefab, start.position, start.rotation);
            b.GetComponent<Bullet>().playerTrans = playerTrans;
            b = Instantiate(bulletPrefab, start.position, start.rotation * Quaternion.Euler(new Vector3(0, 0, -5)));
            b.GetComponent<Bullet>().playerTrans = playerTrans;
            b = Instantiate(bulletPrefab, start.position, start.rotation * Quaternion.Euler(new Vector3(0, 0, +5)));
            b.GetComponent<Bullet>().playerTrans = playerTrans;
            cb?.Broadcast();
        }
    }
}
