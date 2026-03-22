using NUnit.Framework;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
public class Plate : MonoBehaviour
{
    public List<ClickDrag> list = new List<ClickDrag>();
    public CookingScript cook;
    public GameObject foodOnPlate;
    public int Score = 0;
    public static int HighScore = 0;
    public GameObject ServeButton;
    public int OrderRule = 0;
    public TextMeshProUGUI MenuText;
    public TextMeshProUGUI ScoreText;
    public Timer Timer;
    public float AddedTime = 10f;
    public float RemovedTime = -10f;

    private void Start()
    {
        OrderGenerate();
    }
    public void OrderGenerate()
    {
        OrderRule = Random.Range(0, 16);
        if (OrderRule == 0)
        {
            MenuText.text = "CURRENT \nORDER:" + "\n Sunny Side \n Cake" + "\n 1 Egg \n 1 Pancake";
        }
        else if (OrderRule == 1)
        {
            MenuText.text = "CURRENT \nORDER:" + "\n Eggy Day" + "\n 2 Eggs";
        }
        else if (OrderRule == 2)
        {
            MenuText.text = "CURRENT \nORDER:"  + "\n Egg Toast" + "\n 1 Egg \n 1 Toast";
        }
        else if (OrderRule == 3)
        {
            MenuText.text = "CURRENT \nORDER:" + "\n NYC Classic" + "\n 1 Egg \n 1 Bacon";
        }
        else if (OrderRule == 4)
        {
            MenuText.text = "CURRENT \nORDER:"  + "\n Sausy Egg" + "\n 1 Egg \n 1 Sausage";
        }
        else if (OrderRule == 5)
        {
            MenuText.text = "CURRENT \nORDER:" + "\n All Carbs!" + "\n 1 Toast \n 1 Pancake";
        }
        else if (OrderRule == 6)
        {
            MenuText.text = "CURRENT \nORDER:" +  "\n Denny \nSpecial" + "\n 1 Bacon \n 1 Pancake";
        }
        else if (OrderRule == 7)
        {
            MenuText.text = "CURRENT \nORDER:" + "\n Pork n Carbs" + "\n 1 Sausage \n 1 Pancake";
        }
        else if (OrderRule == 8)
        {
            MenuText.text = "CURRENT \nORDER:" + "\n Pancake \n Stack" + "\n 2 Pancakes";
        }
        else if (OrderRule == 9)
        {
            MenuText.text = "CURRENT \nORDER:" +  "\n Easy Morning \n Breakfast" + "\n 1 Bacon \n 1 Toast";
        }
        else if (OrderRule == 10)
        {
            MenuText.text = "CURRENT \nORDER:" + "\n Meat Lover" + "\n 1 Bacon \n 1 Sausage";
        }
        else if (OrderRule == 11)
        {
            MenuText.text = "CURRENT \nORDER:" + "\n Bacon Fan" + "\n 2 Bacons";
        }
        else if (OrderRule == 12)
        {
            MenuText.text = "CURRENT \nORDER:" + "\n Toast n \n Meat" + "\n 1 Sausage \n 1 Toast";
        }
        else if (OrderRule == 13)
        {
            MenuText.text = "CURRENT \nORDER:" + "\n Sausage \n Fanatic" + "\n 2 Sausage";
        }
        else if (OrderRule == 14)
        {
            MenuText.text = "CURRENT \nORDER:" + "\n Toasty" + "\n 2 Toasts ";
        }

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Food"))
        {
            ClickDrag o = other.gameObject.GetComponent<ClickDrag>();
            if (!list.Contains(o))
            {
                list.Add(o);
                foodOnPlate = other.gameObject; // other is linking to what you bump into !  atleast for on collision and Trigger enter
                Debug.Log("FoodOnPlateis" + other.gameObject);
            }
            
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        ClickDrag o = other.gameObject.GetComponent<ClickDrag>();

        if (list.Contains(o))
        {
            list.Remove(o);

            Debug.Log("FoodRemoved" + other.gameObject);
        }
    }
    void Update()
    {    
       
    }
    public void Serve()
    {

       
        int EggCount = 0;
        int PancakeCount = 0;
        int ToastCount = 0; 
        int SausageCount = 0;
        int BaconCount = 0;
        
        foreach (ClickDrag drag in list)
        {
            CookingScript cook = drag.GetComponent<CookingScript>();
            if (drag.foodType == "Egg" && cook !=null && cook.cooked)
            {
                EggCount += 1;
            }
            if (drag.foodType == "Pancake" && cook !=null && cook.cooked)
            {
                PancakeCount += 1;   
            }
            if (drag.foodType == "Sausage" && cook !=null && cook.cooked)
            {
                SausageCount += 1;
            }
            if (drag.foodType == "Toast" && cook !=null && cook.cooked)
            {
                ToastCount += 1;
            }
            if (drag.foodType == "Bacon" && cook !=null && cook.cooked)
            {
                BaconCount += 1;
            }
        }
        //-------------- BATCH OF ORDERS ----------
        Debug.Log("order: "+PancakeCount+"/"+EggCount+ "/" + BaconCount + "/" + SausageCount + "/" + ToastCount + "/" + OrderRule);
        if (OrderRule == 0 && EggCount == 1 && PancakeCount == 1 )           
        {
            Debug.Log("Order0Done");
            foreach (ClickDrag drag in list.ToArray()) // the array is making a copy of the original list which prevents the og list from being destroyed
            {
                Destroy(drag.gameObject);
                list.Clear();
            }
            Score += 2;
            Timer.OrderAddTime(AddedTime);
            
        }
        else if (OrderRule == 1 && EggCount == 2)
        {
            Debug.Log("Order1DONE");
            foreach (ClickDrag drag in list.ToArray()) 
            {
                Destroy(drag.gameObject);
                list.Clear();
            }
            Score += 2;
            Timer.OrderAddTime(AddedTime);
        }

        else if (OrderRule == 2 && EggCount == 1 && ToastCount == 1)
        {
            Debug.Log("Order2DONE");
            foreach (ClickDrag drag in list.ToArray())
            {
                Destroy(drag.gameObject);
                list.Clear();
            }
            Score += 2;
            Timer.OrderAddTime(AddedTime);
        }
        else if (OrderRule == 3 && EggCount == 1 && BaconCount == 1)
        {
            Debug.Log("Order3DONE");
            foreach (ClickDrag drag in list.ToArray())
            {
                Destroy(drag.gameObject);
                list.Clear();
            }
            Score += 2;
            Timer.OrderAddTime(AddedTime);
        }
        else if (OrderRule == 4 && EggCount == 1 && SausageCount == 1)
        {
            Debug.Log("Order4DONE");
            foreach (ClickDrag drag in list.ToArray())
            {
                Destroy(drag.gameObject);
                list.Clear();
            }
            Score += 2;
            Timer.OrderAddTime(AddedTime);
        }
        else if (OrderRule == 5 && PancakeCount == 1 && ToastCount == 1)
        {
            Debug.Log("Order5DONE");
            foreach (ClickDrag drag in list.ToArray())
            {
                Destroy(drag.gameObject);
                list.Clear();
            }
            Score += 2;
            Timer.OrderAddTime(AddedTime);
        }
        else if (OrderRule == 6 && PancakeCount == 1 &&  BaconCount == 1)
        {
            Debug.Log("Order6DONE");
            foreach (ClickDrag drag in list.ToArray())
            {
                Destroy(drag.gameObject);
                list.Clear();
            }
            Score += 2;
            Timer.OrderAddTime(AddedTime);
        }
        else if (OrderRule == 7 && PancakeCount == 1 && SausageCount == 1)
        {
            Debug.Log("Order7DONE");
            foreach (ClickDrag drag in list.ToArray())
            {
                Destroy(drag.gameObject);
                list.Clear();
            }
            Score += 2;
            Timer.OrderAddTime(AddedTime);
        }
        else if (OrderRule == 8 && PancakeCount == 2)
        {
            Debug.Log("Order8DONE");
            foreach (ClickDrag drag in list.ToArray())
            {
                Destroy(drag.gameObject);
                list.Clear();
            }
            Score += 2;
            Timer.OrderAddTime(AddedTime);
        }
        else if (OrderRule == 9 && BaconCount == 1 && ToastCount == 1)
        {
            Debug.Log("Order9DONE");
            foreach (ClickDrag drag in list.ToArray())
            {
                Destroy(drag.gameObject);
                list.Clear();
            }
            Score += 2;
            Timer.OrderAddTime(AddedTime);
        }
        else if (OrderRule == 10 && BaconCount == 1 && SausageCount == 1)
        {
            Debug.Log("Order10DONE");
            foreach (ClickDrag drag in list.ToArray())
            {
                Destroy(drag.gameObject);
                list.Clear();
            }
            Score += 2;
            Timer.OrderAddTime(AddedTime);
        }
        else if (OrderRule == 11 && BaconCount == 2)
        {
            Debug.Log("Order11DONE");
            foreach (ClickDrag drag in list.ToArray())
            {
                Destroy(drag.gameObject);
                list.Clear();
            }
            Score += 2;
            Timer.OrderAddTime(AddedTime);
        }
        else if (OrderRule == 12 && SausageCount == 1 && ToastCount == 1)
        {
            Debug.Log("Order12DONE");
            foreach (ClickDrag drag in list.ToArray())
            {
                Destroy(drag.gameObject);
                list.Clear();
            }
            Score += 2;
            Timer.OrderAddTime(AddedTime);
        }
        else if (OrderRule == 13 && SausageCount == 2)
        {
            Debug.Log("Order13DONE");
            foreach (ClickDrag drag in list.ToArray())
            {
                Destroy(drag.gameObject);
                list.Clear();
            }
            Score += 2;
            Timer.OrderAddTime(AddedTime);
        }
        else if (OrderRule == 14 && ToastCount == 2)
        {
            Debug.Log("Order14DONE");
            foreach (ClickDrag drag in list.ToArray())
            {
                Destroy(drag.gameObject);
                list.Clear();
            }
            Score += 2;
            Timer.OrderAddTime(AddedTime);
        }

        else 
        {
            Debug.Log("LOSE");
            foreach (ClickDrag drag in list.ToArray())
            {
                if (cook ==null || !cook.cooked)
                    {
                    Destroy(drag.gameObject);
                    list.Clear();
                }
                Score += -2;
                Timer.OrderAddTime(RemovedTime);

            }
        }
        ScoreText.text = "Score:" + Score;
        HighScore = Score;
        OrderGenerate();
        
    }

} 

