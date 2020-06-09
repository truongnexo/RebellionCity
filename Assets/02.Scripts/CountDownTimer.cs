using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour
{
	float currentTime = 0f;
	public float startTime = 4f;
	public Text countDownText;
	public GameObject overGame;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countDownText.text = currentTime.ToString("0");
        if (currentTime <= 0) {
        	currentTime = 0;
        	// Time.timeScale = 0f;
        	//overGame.SetActive(true);
            SceneManager.LoadScene("EndGame");
        }
    }
}
