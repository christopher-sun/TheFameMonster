using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimerToEnd : MonoBehaviour {
    [SerializeField]
    private float delay = 0f;
    [SerializeField]
    private string sceneName;
    [SerializeField]
    private string currScene;
    [SerializeField]
    float timer = 300f;

    public Text gameTimerText;

    void Update() {
        timer -= Time.deltaTime;

        int seconds = (int)(timer % 60);
        int minutes = (int)(timer / 60) % 60;
        int hours = (int)(timer / 3600) % 24;

        string timerString = string.Format("{0:0}:{1:00}:{2:00}", hours, minutes, seconds);

        gameTimerText.text = timerString;

        if (timer < delay)
        {
            SceneManager.UnloadScene(currScene);
            SceneManager.LoadScene(sceneName);
        }

    }
}
