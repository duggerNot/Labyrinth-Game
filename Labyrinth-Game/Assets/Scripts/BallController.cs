using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    private static int Score = 1;
    public Text scoreText;
    public Text winText;


    //Initialize Game
    void Start()
    {
        Rigidbody rb = gameObject.GetComponent<Rigidbody>();
        rb.sleepThreshold = -1f;
        SetScoreText();
        winText.text = "";
        StartCoroutine(BackToMenu());
    }

    //Handle "game reset" and "Finish" zones
    void OnTriggerEnter(Collider zone)
    {
        if (zone.gameObject.CompareTag("Game Reset"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Score++;
            SetScoreText();
        }
        if (zone.gameObject.CompareTag("Finish"))
        {
            StartCoroutine(EndGame());
        }
    }

    //Applying the the "score" to the scene ui
    void SetScoreText()
    {
        scoreText.text = "Tries: " + Score.ToString();
    }

    //coroutine to handle what happens when the game ends
    //returns to the menu screen
    IEnumerator EndGame()
    {
        winText.text = "Well Done!  You Did It!";
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Game-Menu");
    }

    //coroutine to handle leaving the game while playing
    IEnumerator BackToMenu()
    {
        yield return new WaitUntil(() => Input.GetKeyUp(KeyCode.Escape));
        SceneManager.LoadScene("Game-Menu");
    }

}
