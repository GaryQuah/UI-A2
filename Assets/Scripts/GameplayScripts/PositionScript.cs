using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PositionScript : MonoBehaviour
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

        //textmeshPro.text = timer.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
