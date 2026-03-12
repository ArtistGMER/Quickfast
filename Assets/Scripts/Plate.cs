using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
public class Plate : MonoBehaviour
{
    public List<GameObject> breakfastFoodList = new List<GameObject>();
    public bool foodOnPlate = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Food"))
        {
            if (!breakfastFoodList.Contains(other.gameObject))
            {
                breakfastFoodList.Add(other.gameObject);
                foodOnPlate = true;
                Debug.Log(other.name + "hasfoodlol");
            }
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (breakfastFoodList.Contains(other.gameObject))
        {
            breakfastFoodList.Remove(other.gameObject);
            foodOnPlate = false;
            Debug.Log("hasnofoodlol" + other.gameObject);
        }
    }

    void Update()
    {

    }
   
}