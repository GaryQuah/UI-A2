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

    [SerializeField] GameObject AlertEnemyController;
    [SerializeField] GameObject enemyCar;

    // Start is called before the first frame update
    void Start()
    {
        GameObject tempGo = GameObject.Find("PositioningBackground");
        textmeshPro = tempGo.GetComponent<TextMeshProUGUI>();

        tempGo = GameObject.Find("PositioningTrackerCanvas");

        theCanavs = tempGo.GetComponent<Canvas>();

       // theCanavs.renderMode = RenderMode.ScreenSpaceOverlay;

        objectivesTrackerObject = GameObject.Find("ObjectivesTracker");

        objectivesTracker = objectivesTrackerObject.GetComponent<ObjectivesTracker>();

        textmeshPro.transform.position = enemyCar.transform.position;
        textmeshPro.transform.position += new Vector3(0, 1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 namePose = Camera.main.WorldToScreenPoint(this.transform.position);
       
    }

    private void OnTriggerEnter(Collider other)
    {
        //if (other.name == "RaceCar")
        //    theCanavs.gameObject.SetActive(false);

        if (objectivesTracker.getCurrentPosition() > 1)
            objectivesTracker.setCurrentPosition(objectivesTracker.getCurrentPosition() - 1);

        AlertEnemyController.SetActive(true);
        Debug.Log("passed through");
    }
}
