using UnityEngine;

public class ClickDrag : MonoBehaviour
{
    private Vector3 mousePosition;
    private Vector3 startPosition;
    public string foodType;
    public bool cooked;
    public bool burnt;
    private Camera mainCamera;
    private bool isDragging;
    private bool SpawnNewFood;
    public GameObject EggPrefab;
    public GameObject BaconPrefab;
    public GameObject SausagePrefab;
    public GameObject PancakePrefab;
    public GameObject ToastPrefab;

    void Start()
    {
        startPosition = transform.position;
        mainCamera = Camera.main;

    }

     
    private Vector3 GetMousePos()
    {
        return Camera.main.WorldToScreenPoint(transform.position);
    }

    private void OnMouseDown()
    {
        mousePosition = Input.mousePosition - GetMousePos();
        isDragging = true;

        if (!SpawnNewFood)
        {

            Instantiate(EggPrefab, startPosition, Quaternion.identity);
            SpawnNewFood = true;

            //Instantiate(ToastPrefab, startPosition, Quaternion.identity);
            //SpawnNewFood = true;
        }
            
        
    }

    void SetCookingBool(bool tf) // this is to determine if its cooking or not
    {

    }

    private void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition - mousePosition);
        isDragging = false;
    }

   void Update()
    {
        
       if (isDragging)
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 10f;
            transform.position = mainCamera.ScreenToWorldPoint(mousePos);

        }
    }
}
