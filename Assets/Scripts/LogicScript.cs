using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class LogicScript : MonoBehaviour
{
    public int Score;
    public TMP_Text ScoreText;
    public GameObject GameOverPanel;
    private bool IsGameOver = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void AddScore(int IncreaseScore)
    {
        Score += IncreaseScore;
        ScoreText.text = "Score: " + Score;

    }

    public void GameOver()
    {
        IsGameOver = true;
        GameOverPanel.SetActive(true);
    }

    public void Update()
    {
        if (IsGameOver && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(1);
        }
    }
}
