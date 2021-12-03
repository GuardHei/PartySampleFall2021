﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject bulletPrefab;
    public CrimeBroadcast cb;
    public int cost;
    public int damage;
    public float fireRate = 0.2f;
    public float fireTime = 0;

    private void Awake() {
        cb = GetComponentInParent<CrimeBroadcast>();
    }

    public virtual void Shoot(Transform start)
    {
        
    }

    public void Update()
    {
        // Debug.Log("yeet");
    }

    public void ChangeWeaponDamage(int damage)
    {
        bulletPrefab.GetComponent<Bullet>().damage += damage;
    }

    public void ChangeWeaponAttackSpeed(float damage)
    {
        fireRate += damage;
    }
}
