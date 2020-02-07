using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseButton : MonoBehaviour
{
    private Button pauseButton;
    private GameObject pausePanel;
    bool isPaused = false;
    private AudioSource engineAudio;

    // Start is called before the first frame update
    void Start()
    {
        GameObject temp = GameObject.Find("Player");
        engineAudio = temp.GetComponent<AudioSource>();

        pauseButton = GetComponent<Button>();
        pauseButton.onClick.AddListener(pause);

        pausePanel = GameObject.Find("PausePanel");
    }

    public void resume()
    {
        isPaused = false;
        Time.timeScale = 1;
        Debug.Log("button pressed");
        engineAudio.UnPause();
    }

    public void restart()
    {
        Time.timeScale = 1;
        int scene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }

    public void exit()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainmenuScene", LoadSceneMode.Single);
    }

    void pause()
    {
        isPaused = true;
        Time.timeScale = 0;
        Debug.Log("pause pressed");
        engineAudio.Pause();
    }

    // Update is called once per frame
    void Update()
    {
        if (isPaused)
            pausePanel.SetActive(true);
        else
            pausePanel.SetActive(false);
    }
}
