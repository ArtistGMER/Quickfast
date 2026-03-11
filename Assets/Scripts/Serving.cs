using TMPro;
using UnityEngine;

public class Serving : MonoBehaviour
{
    public int Score = 0;
    public TextMeshProUGUI ScoreText;
   


    //when you press the button, and theres food on the plate, the score should go up by 1 per food item
    private void OnMouseDown()
    {
       //if(collision)
        GetPoint();
    }

    public void GetPoint()
    {
        Score++;
        ScoreText.text = "Score:" + Score;
    }
    void Update()
    {
        
    }
}
