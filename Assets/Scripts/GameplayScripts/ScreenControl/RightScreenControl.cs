using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class RightScreenControl : MonoBehaviour 
{
    private GameObject objectivesTrackerObject;
    private ObjectivesTracker objectivesTracker;
    private PlayerMoverScript speedController;
    private GameObject player;
    private Button button;

    private bool pointerDown = false;

    // Start is called before the first frame update
    void Start()
    {
        objectivesTrackerObject = GameObject.Find("ObjectivesTracker");

        objectivesTracker = objectivesTrackerObject.GetComponent<ObjectivesTracker>();
        player = GameObject.Find("Player");
        speedController = player.GetComponent<PlayerMoverScript>();


        button = GetComponent<Button>();
        button.onClick.AddListener(nitro);
    }

    public void nitro()
    {
        if (objectivesTracker.getNitro() >= 0.25f)
            objectivesTracker.activateNitro();
    }

    public void Update()
    {
       
    }
}
