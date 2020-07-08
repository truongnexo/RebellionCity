using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour
{
	public static float currentTime = 0f;
    float timeLoadScene = 0;
	public float startTime = 4f;
	public Text countDownText;
	public GameObject overGame;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startTime;
        timeLoadScene = currentTime + 5;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        timeLoadScene -= 1 * Time.deltaTime;
        countDownText.text = currentTime.ToString("0");
        if (currentTime <= 0) {
        	currentTime = 0;
        	// Time.timeScale = 0f;
        	//overGame.SetActive(true);


        }
        //if (timeLoadScene <= 0)
        //{
        //    timeLoadScene = 0;
        //    SceneManager.LoadScene("EndGame");
        //}
    }
}
