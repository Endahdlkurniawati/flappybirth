using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject GameOverCanvas;
    


    // Start is called before the first frame update

    public void Start()
    {
        Time.timeScale = 1;
        ScoreManagement.Score = 0;
    }
    public void gameOver()
    {
        GameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void Retry()
    {
        GameOverCanvas.SetActive(false);
        SceneManager.LoadScene(0);
    }
}
