using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public Player Player;
    public CameraFollow CameraFollow;
    public Canvas DeathMenu;
    public Canvas WinMenu;
    public TextMeshProUGUI ScoreOnScreen;
    public TextMeshProUGUI CurrentLevelOnScreen;
    public TextMeshProUGUI TotalScoreTextDeath;
    public TextMeshProUGUI LevelScoreTextDeath;
    public TextMeshProUGUI TotalScoreTextWin;
    public TextMeshProUGUI LevelScoreTextWin;
    public AudioSource GameAudioSource;
    public int CurrentLevel { get; private set; }
    private int score = 0;
    public int levelScore { get; private set; }
    void Awake()
    {
        CurrentLevel = SceneManager.GetActiveScene().buildIndex;
        CurrentLevelOnScreen.text = "Level: " + (CurrentLevel + 1).ToString();
        ScoreOnScreen.text = levelScore.ToString();
        OnStartLevel();
        levelScore = Player.score;
    }

    void Update()
    {
        ScoreOnScreen.text = "Score: " + levelScore.ToString();
        levelScore = Player.score;
        //Debug.Log("Level Score: " + levelScore + "\nScore: " + score);
        //Debug.Log("Current level: " + CurrentLevel);
    }



    public void OnStartLevel()
    {
        Player.AddScore(-Player.score);
    }
    public void OnReachFinish()
    {
        score += levelScore;
        CameraFollow.enabled = false;
        Debug.Log("YOU WON");
        WinMenu.gameObject.SetActive(true);
        TotalScoreTextWin.text = TotalScoreTextWin.text + score.ToString();
        LevelScoreTextWin.text = LevelScoreTextWin.text + levelScore.ToString();
    }

    public void OnDeath()
    {
        score += levelScore;
        Debug.Log("YOU LOSE");
        DeathMenu.gameObject.SetActive(true);
        TotalScoreTextDeath.text = TotalScoreTextDeath.text + score.ToString();
        LevelScoreTextDeath.text = LevelScoreTextDeath.text + levelScore.ToString();
        ScoreOnScreen.gameObject.SetActive(false);
        GameAudioSource.Play();
    }

    public void ReloadLevel()
    {
        SceneManager.LoadScene(CurrentLevel);
    }

    public void NextLevel()
    {
        if(CurrentLevel == 2)
        {
            CurrentLevel = 0;
            SceneManager.LoadScene(CurrentLevel);
            return;
        }
        SceneManager.LoadScene(CurrentLevel + 1);
    }

    public void AddScore()
    {
        score++;
    }

    public void SetScore()
    {

    }
}
