using UnityEngine;

public class OrderScript : MonoBehaviour 
{
    
    //public GameObject Egg;
    //public GameObject Toast;
    //public GameObject Pancake;
    //public GameObject Sausage;
    //public GameObject Bacon;
    public bool foodOnPlate = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Food"))
        {
            foodOnPlate = true;
            Debug.Log("hasfoodlol");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Food"))
        {
            foodOnPlate = false;
            Debug.Log("hasnofoodlol");
        }
    }

    void Update()
    {

       

    }
   
}
