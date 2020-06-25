using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour

{
    public Text scoreText;
    public Text timerText;
    public Text IntroGameMenuText;
    public Text GameOverText;
    public int score = 100;
    float timer = 30;
    public GameObject gameOverMenu;
    public GameObject IntroGameMenu;
    // Start is called before the first frame update
    void Start()
    {
        gameOverMenu.SetActive(true);
        IntroGameMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        scoreText.text = score.ToString();
        timerText.text = Mathf.Floor(timer).ToString();

    }

    public void ButtonPressed()
    {
        Debug.Log("Button was pressed!");
        gameOverMenu.SetActive(false);
        SceneManager.LoadScene("Bella");

    }
    public void CloseMenu()
    {
        IntroGameMenu.SetActive(false);
    }
    public void OpenMenu()
    {
        IntroGameMenu.SetActive(true);
    }

}
