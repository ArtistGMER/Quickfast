using System.Collections.Generic;
using UnityEngine;
public class OrderScript : MonoBehaviour 
{

    public bool orderComplete = false;
    public GameObject EggPrefab;
    public GameObject BaconPrefab;
    public GameObject SausagePrefab;
    public GameObject PancakePrefab;
    public GameObject ToastPrefab;
    public List<OrderScript> Orders = new List<OrderScript>();
    public bool activeOrders = false;

    // I want to make it so that the order script will generate an order from a prepare list of orders. The Plate needs to also know what order is current active

    void Update()
    {
        //int EggPrefab 


    }

    public void OrderList()
    {
        
        if (Orders.Count == 0) return;
        foreach (OrderScript o in Orders) ;

        //OrderScript b = other.gameObject.GetComponent<OrderScript>();
    }
}

