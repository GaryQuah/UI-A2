using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ObjectivesTracker : MonoBehaviour
{
    //Elapsed time tracker
    private float elapsedTime = 0.0f;

    //Reference to player script
    private PlayerMoverScript speedController;
    private Canvas scoreSummary;
    private GameObject scoreSummaryObject;

    private int currentPosition;

    private int totalPlayers = 2;

    private int currentLap = 0;
    private const int totalLaps = 2;
    private float nitro = 0.0f;
    private bool nitroActivate = false;

    [SerializeField] private Slider slider;

    //Reference to the car object itself.
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;

        player = GameObject.Find("Player");

        speedController = player.GetComponent<PlayerMoverScript>();

        scoreSummaryObject = GameObject.Find("ScoreSummary");
        scoreSummary = scoreSummaryObject.GetComponent<Canvas>();
        scoreSummary.renderMode = RenderMode.ScreenSpaceOverlay;
        scoreSummaryObject.SetActive(false);
        //
        currentPosition = totalPlayers;

         totalPlayers = 2;

         currentLap = 0;
         nitro = 0.0f;
         nitroActivate = false;
      }

    public int getTotalPlayers()
    {
        return totalPlayers;
    }

    public int getCurrentPosition()
    {
        return currentPosition;
    }

    public void setCurrentPosition(int value)
    {
        currentPosition = value;
    }

    public void activateNitro()
    {
        nitroActivate = true;
        nitro -= 0.25f;

        speedController.addToSpeed(25.0f);
    }

    public void setNitroActive(bool condition)
    {
        nitroActivate = condition;
    }

    public bool getNitroActive()
    {
        return nitroActivate;
    }

    public float getElapsedTime()
    {
        return elapsedTime;
    }

    public void resetElapsedTime()
    {
        elapsedTime = 0;
    }

    public float getNitro()
    {
        return nitro;
    }

    public void reduceNitro()
    {
        nitro -= 25.0f;
    }

    public int getCurrentLap()
    {
        return currentLap;
    }

    public int getTotalLaps()
    {
        return totalLaps;
    }

    public void updateCurrentLap()
    {
        currentLap += 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentLap > totalLaps)
        {
            scoreSummaryObject.SetActive(true);

            GameObject tempGo = GameObject.Find("TimingText");
            TextMeshProUGUI timingText = tempGo.GetComponent<TextMeshProUGUI>();
            tempGo = GameObject.Find("TimerText");
            TextMeshProUGUI raceTimerText = tempGo.GetComponent<TextMeshProUGUI>();

            timingText.text = "Timing : " + raceTimerText.text;

            Time.timeScale = 0;
        }
        else
        {
            elapsedTime += Time.deltaTime;

            if (nitro < 1.0f)
                nitro += 0.05f * (float)(Time.deltaTime);
            else
                nitro = 1.0f;

            slider.value = nitro;
        }
    }
}
