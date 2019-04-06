using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject hazard;
    public Vector3 spawnValues;
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;

    public Text ScoreText;
    private int score;
    public Text RestartText;
    public Text GameOverText;
    public Text WinText;
    
    private bool gameOver;
    private bool restart;
    

    private void Start()
    {
        gameOver = false;
        restart = false;
        RestartText.text = "";
        GameOverText.text = "";
        WinText.text = "";
        score = 0;
        UpdateScore();
        StartCoroutine (SpawnWaves());
    }
    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i < hazardCount; i++)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(hazard, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);

            if (gameOver)
            {
                RestartText.text = "Press 'H' for Restart";
                restart = true;
                break;
            }
        }
    }
    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }

    void UpdateScore()
    {
        ScoreText.text = "Points: " + score;
        if (score >= 100)
        {
            WinText.text = "Game Created by: Bryce Lush";
            gameOver = true;
            restart = true;
              
        }
    }

    public void GameOver()
    {
        GameOverText.text = "Game Created by: Bryce Lush";
        gameOver = true;
    }

    void Update()
    {
        if (restart)
        {
            if (Input.GetKeyDown (KeyCode.H))
            {
                SceneManager.LoadScene("Space Shooter");
            }
        }

        if (Input.GetKey("escape"))
            Application.Quit();
    }
}
