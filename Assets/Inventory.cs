﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public Shooter shooter;
    public BasicVehicleMotor basicVehicle;
    public MoneyGrab moneyGrab;
    public Image[] itemUI;
    public List<Item> currentItems;

    // Start is called before the first frame update
    void Start()
    {
        basicVehicle = GetComponent<BasicVehicleMotor>();
        moneyGrab = GetComponent<MoneyGrab>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))        
            Click(0);   
        else if (Input.GetKeyDown(KeyCode.Alpha2))       
            Click(1);     
        else if (Input.GetKeyDown(KeyCode.Alpha3))       
            Click(2);        
        else if (Input.GetKeyDown(KeyCode.Alpha4))       
            Click(3);
        
    }

    public void Click(int key)
    {
        currentItems[key].OnActivate();    
    }

    public bool Equip(Item item)
    {
        if (currentItems.Count <= 4)
        {
            currentItems.Add(item);
            return true;
        }
        return false;
    }

    public bool CanEquip(Weapon wep)
    {
        if (shooter.primaryWeapon == null) {
            return true;
        }
        else if (shooter.secondaryWeapon == null) {
            return true;
        }
        return false;
    }

    public void Equip(Weapon wep)
    {
        if (shooter.primaryWeapon == null)      
            shooter.primaryWeapon = wep;
        else if (shooter.secondaryWeapon == null)       
            shooter.secondaryWeapon = wep;
    }
}