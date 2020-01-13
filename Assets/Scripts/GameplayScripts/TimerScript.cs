using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerScript : MonoBehaviour
{
    private TextMeshProUGUI textmeshPro;

    private double timer = 0.0f;
    private int minutes = 0;

    private GameObject objectivesTrackerObject;

    private ObjectivesTracker objectivesTracker;

    // Start is called before the first frame update
    void Start()
    {
        textmeshPro = GetComponent<TextMeshProUGUI>();

        textmeshPro.text = timer.ToString();

        objectivesTrackerObject = GameObject.Find("ObjectivesTracker");

        objectivesTracker = objectivesTrackerObject.GetComponent<ObjectivesTracker>();

        timer = objectivesTracker.getElapsedTime();
    }

    // Update is called once per frame
    void Update()
    {
        timer = objectivesTracker.getElapsedTime();

        int seconds;
        double miliseconds;

        if (timer >= 60)
        {
            minutes += 1;
            timer = 0;
        }

         seconds = (int)(timer);
         miliseconds = (timer - seconds) * 100;

        if (minutes < 10)
            textmeshPro.text = "0" + minutes.ToString();
        else
            textmeshPro.text = minutes.ToString();

        if (seconds < 10)
            textmeshPro.text += " : 0" + seconds.ToString();
        else
            textmeshPro.text += " : " + seconds.ToString();

        if (miliseconds < 10)
            textmeshPro.text += " : 0" + miliseconds.ToString("f0");
        else
            textmeshPro.text += " : " + miliseconds.ToString("f0");
    }
}
