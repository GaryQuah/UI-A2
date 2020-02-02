using System.Collections;
using System.Collections.Generic;
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
    //Lap tracker
    private int currentLap = 0;

    private const int totalLaps = 2;

    //Nitro
    private float nitro = 0.0f;

    private bool nitroActivate = false;

    [SerializeField] private Slider slider;

    //Reference to the car object itself.
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("RaceCar");

        speedController = player.GetComponent<PlayerMoverScript>();

        scoreSummaryObject = GameObject.Find("ScoreSummary");
        scoreSummary = scoreSummaryObject.GetComponent<Canvas>();
        scoreSummary.renderMode = RenderMode.ScreenSpaceOverlay;
        scoreSummaryObject.SetActive(false);
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
