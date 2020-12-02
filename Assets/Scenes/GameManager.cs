using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager _instance;

    public float score = 0;

    public Canvas gameOverCanvas;
    public Text scoreText;
    
    public bool isGameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
        {
            if (Input.GetButtonDown("Jump"))
            {
                // restart scene
                RestartScene();
            }
        }   
    }

    public void GameOver()
    {
        gameOverCanvas.enabled = true;
        isGameOver = true;
    }

    public static void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void UpdateScore(int addValue)
    {
        score += addValue;
        scoreText.text = score.ToString();
    }
}
