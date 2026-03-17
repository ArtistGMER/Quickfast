using TMPro;
using UnityEngine;

public class Serving : MonoBehaviour
{
    //public int Score = 0;
    public TextMeshProUGUI ScoreText;
    
    public Plate Serve;
   


    //when you press the button, and theres food on the plate, the score should go up by 1 per food item
    private void OnMouseDown()
    {

        Serve.Serve();// Saying the variable name + .  is what teleports the code into the function within the other script
    }

    //public void GetPoint()
    //{
    //    Score++;
    //    ScoreText.text = "Score:" + Score;
    //}
    void Update()
    {
        
    }
}
