using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedometerNeedleHandler : MonoBehaviour
{
    private GameObject needle;

    private GameObject player;

    private float speed ;

    private PlayerMoverScript speedController;


    // Start is called before the first frame update
    void Start()
    {
        needle = transform.gameObject;

        //Get a reference to players rigid body.

        player = GameObject.Find("RaceCar");

        speedController = player.GetComponent<PlayerMoverScript>();
        speed = speedController.getSpeed();
    }

    // Update is called once per frame
    void Update()
    {
        speed = speedController.getSpeed();

        //0 to -240 for rotation of needle.

        if (speed >= 0)
        transform.localRotation = Quaternion.AngleAxis(-speed , new Vector3(0 , 0 , 1));
    }
}
