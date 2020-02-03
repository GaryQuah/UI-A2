using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIClampToWorld : MonoBehaviour
{
    private TextMeshProUGUI textmeshPro;

    private Canvas theCanavs;

    private GameObject objectivesTrackerObject;

    private ObjectivesTracker objectivesTracker;

    // Start is called before the first frame update
    void Start()
    {
        GameObject tempGo = GameObject.Find("PositioningBackground");
        textmeshPro = tempGo.GetComponent<TextMeshProUGUI>();

        tempGo = GameObject.Find("PositioningTrackerCanvas");

        theCanavs = tempGo.GetComponent<Canvas>();

        theCanavs.renderMode = RenderMode.ScreenSpaceOverlay;

        objectivesTrackerObject = GameObject.Find("ObjectivesTracker");

        objectivesTracker = objectivesTrackerObject.GetComponent<ObjectivesTracker>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 namePose = Camera.main.WorldToScreenPoint(this.transform.position);
        textmeshPro.transform.position = namePose;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "RaceCar")
            theCanavs.gameObject.SetActive(false);

        if (objectivesTracker.getCurrentPosition() > 1)
            objectivesTracker.setCurrentPosition(objectivesTracker.getCurrentPosition() - 1);

        Debug.Log("passed through");
    }
}
