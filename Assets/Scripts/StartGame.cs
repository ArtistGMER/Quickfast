using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public StartGame Start;
    
    public void LoadGame()
    {
    }

    public void OnMouseDown()
    {
       
        SceneManager.LoadScene(0);
        //Start.LoadGame();
    }
    
    void Update()
    {
        
    }
}
