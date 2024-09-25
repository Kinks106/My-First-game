using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logic : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject GameOverScreen;
    [ContextMenu("Increase Score")]
    public void add_score()
    {
        playerScore++;
        scoreText.text=playerScore.ToString();
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Is_Hit()
    {
        GameOverScreen.SetActive(true);
    }
}
