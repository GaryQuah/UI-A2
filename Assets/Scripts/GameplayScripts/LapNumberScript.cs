using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LapNumberScript : MonoBehaviour
{
    private TextMeshProUGUI textmeshPro;

    private GameObject objectivesTrackerObject;

    private ObjectivesTracker objectivesTracker;

    // Start is called before the first frame update
    void Start()
    {
        textmeshPro = GetComponent<TextMeshProUGUI>();

        objectivesTrackerObject = GameObject.Find("ObjectivesTracker");

        objectivesTracker = objectivesTrackerObject.GetComponent<ObjectivesTracker>();

        textmeshPro.text = objectivesTracker.getCurrentLap() + " / " + objectivesTracker.getTotalLaps();
    }

    // Update is called once per frame
    void Update()
    {
        textmeshPro.text = objectivesTracker.getCurrentLap() + " / " + objectivesTracker.getTotalLaps();
    }
}
