using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AlertAheadPlayer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textOne;
    [SerializeField] TextMeshProUGUI textTwo;

    [SerializeField] GameObject player;
    [SerializeField] GameObject enemyAI;

    private GameObject objectivesTrackerObject;

    private ObjectivesTracker objectivesTracker;

    // Start is called before the first frame update
    void Start()
    {
        objectivesTrackerObject = GameObject.Find("ObjectivesTracker");

        objectivesTracker = objectivesTrackerObject.GetComponent<ObjectivesTracker>();
    }

    // Update is called once per frame
    void Update()
    {
        int distanceBetweenPlayers = (int)Vector3.Distance(enemyAI.transform.position, player.transform.position) * 10;

        if (distanceBetweenPlayers <= 500)
        {
            if (objectivesTracker.getCurrentPosition() == 1)
            {
                textOne.text = "2nd ";
                textTwo.text = "2nd ";
            }
            else
            {
                textOne.text = "1st ";
                textTwo.text = "1st ";
            }

            textOne.text += distanceBetweenPlayers.ToString() + "m";
            textTwo.text += distanceBetweenPlayers.ToString() + "m";
        }
        else
        {
            textOne.text = "";
            textTwo.text = "";
        }
    }
}
