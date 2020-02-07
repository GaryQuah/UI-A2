using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

public class LeftScreenControl : MonoBehaviour , IPointerDownHandler , IPointerUpHandler
{
    private GameObject objectivesTrackerObject;
    private ObjectivesTracker objectivesTracker;
    private PlayerMoverScript speedController;
    private GameObject player;

    private bool pointerDown = false;

    // Start is called before the first frame update
    void Start()
    {
        objectivesTrackerObject = GameObject.Find("ObjectivesTracker");

        objectivesTracker = objectivesTrackerObject.GetComponent<ObjectivesTracker>();
        player = GameObject.Find("Player");
        speedController = player.GetComponent<PlayerMoverScript>();
    }

    public void OnPointerDown(PointerEventData data)
    {
        pointerDown = true;
    }

    public void OnPointerUp(PointerEventData data)
    {
        pointerDown = false;
    }

    public void Update()
    {
        if (pointerDown)
        {
            speedController.addToSpeed(-100.0f * Time.deltaTime);
        }
    }
}
