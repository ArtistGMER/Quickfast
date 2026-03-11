using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
public class Plate : MonoBehaviour
{
    public GameObject breakfastFood;
    public List<GameObject> breakfastFoodList = new List<GameObject>();
    public bool foodOnPlate = false;

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("Food"))
    //    {
    //        if (!foodOnPlate.Contains(other.gameObject))
    //        {
    //            foodOnPlate.Add(other.gameObject);
    //            foodOnPlate = true;
    //            Debug.Log(other.name + "hasfoodlol");
    //        }
    //    }
    //}
    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.CompareTag("Food"))
    //    {
    //        foodOnPlate = false;
    //        Debug.Log("hasnofoodlol");
    //    }
    //}

    void Update()
    {

    }
   
}