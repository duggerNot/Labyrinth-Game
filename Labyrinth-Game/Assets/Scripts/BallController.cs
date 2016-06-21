using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    private static int Score = 1;
    public Text scoreText;
    public Text winText;

    void Start()
    {
        Rigidbody rb = gameObject.GetComponent<Rigidbody>();
        rb.sleepThreshold = -1f;
        SetScoreText();
        winText.text = "";
    }

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
            winText.text = "Well Done!  You Did It!";
        }
    }

    void SetScoreText()
    {
        scoreText.text = "Tries: " + Score.ToString();
    }

}
