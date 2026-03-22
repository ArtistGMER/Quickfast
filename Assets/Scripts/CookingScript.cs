using UnityEngine;

public class CookingScript : MonoBehaviour
{

    public bool cooked;
    public bool burnt;
    public SpriteRenderer sr;
    public Sprite CookedArt; // declares and referes to the sprite !
    public Sprite BurntArt;
    public Sprite OnPanArt;
    public bool isCooking = false;
    public bool inPan = false;
    public bool undercooked = false;
    
    //public GameObject EggPrefab;


    public float CookingTimer = 0f;

    void Start()
    {
        cooked = false;
        sr = GetComponent<SpriteRenderer>();
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("Pan"))
        {
            inPan = true;
            isCooking = true;
            
        }
       
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("Pan"))
        {
            inPan = false;
            isCooking = false;
        }

    }
    void Update()
    {
        if (!inPan) return;
        {
            CookingTimer += Time.deltaTime;
        }



       
        if (CookingTimer >= 20f)
        {
            if (!burnt)
            {
                sr.sprite = BurntArt;
                burnt = true;
                Debug.Log("BURNT");
            }
        }

        else if (CookingTimer >= 10f)
        {
            if (!cooked)
            {
                sr.sprite = CookedArt;
                cooked = true;
                Debug.Log("COOKED");
            }
        }
        else if (CookingTimer >= 5f)
        {
            undercooked = true;
        }
        else if (CookingTimer >= 0.1f)
        {
            sr.sprite = OnPanArt;
            inPan = true;

        }
    }

    
}

