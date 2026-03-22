using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public TextMeshProUGUI FinalScoreText;
    public Plate HighScore;
    public void SetUp(int score)
    {
        gameObject.SetActive(true);
        FinalScoreText.text = Plate.HighScore + "\n" + "POINTS";
    }

    public void RetryButton()
    {
        SceneManager.LoadScene(0);
    }
    public void QuitButton()
    {
        SceneManager.LoadScene(1);
    }
}
