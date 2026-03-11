using UnityEngine;

public class ClickAndDrag : MonoBehaviour
{
    [SerializeField] private bool isDragging = false;
    
    void Update()
    {
        if(isDragging)
        {
            transform.position = (Vector3)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
    }

    private void OnMouseDown()
    {

        isDragging = true;
    }

    private void OnMouseUp()
    {

        isDragging = false;
    }
}
