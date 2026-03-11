using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.Rendering;

public class StoveController : MonoBehaviour
{
    public SpriteRenderer sr; //declaring a variable, names it, and declares what the variable is
    public bool isCooking;
    public Vector3 CookingTime;
    public Vector3 startPos;

    void Start() //code here will run at the start of the game 
    {
        startPos = transform.position;
        isCooking = false;
    }

  

    //public void SetCookingBool(bool b)
    //{
    //    isCooking = b;
    //}

    void Update() // code here will run each frame
    {
        
    }
}
