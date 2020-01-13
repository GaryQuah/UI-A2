﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMoverScript : MonoBehaviour
{
    private float moveSpeed = 0.0f;

    [SerializeField] private float rayCastDistance = 1.0f;
    [SerializeField] private float jumpForce = 10.0f;

    //RigidBody
    private Rigidbody rigidbody;

    private GameObject objectivesTrackerObject;

    private ObjectivesTracker objectivesTracker;

    private RawImage windImage;

    // Start is called before the first frame update
    void Start()
    {
        //Reference to the rigidBody.
        rigidbody = GetComponent<Rigidbody>();

        //Reference to objectives
        objectivesTrackerObject = GameObject.Find("ObjectivesTracker");

        objectivesTracker = objectivesTrackerObject.GetComponent<ObjectivesTracker>();

        //Getting a reference to the wind effect image.
        GameObject tempGo = GameObject.Find("WindImageEffect");

        windImage = tempGo.GetComponent<RawImage>();
        windImage.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (objectivesTracker.getNitro() >= 0.25f)
                objectivesTracker.activateNitro();
        }

        move();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "FinishingLine")
        {
            objectivesTracker.updateCurrentLap();
        }
    }

    public float getSpeed()
    {
        return moveSpeed;
    }

    public void addToSpeed(float value)
    {
        moveSpeed += value;
    }

    private void move()
    {
        //A & D Key , Left & Right Arrow input
        float horizontalAxis = Input.GetAxisRaw("Horizontal");
        //W & S Key , Up & Down Arrow input
        float verticalAxis = Input.GetAxisRaw("Vertical");

        if (verticalAxis < 0)
            moveSpeed -= 1.5f;
        else if (verticalAxis >= 0)
        {
            if (moveSpeed < 200)
            {
                moveSpeed += 1.0f;

                objectivesTracker.setNitroActive(false);
                windImage.enabled = false;
            }
            else
                moveSpeed -= 0.1f;

            if (moveSpeed > 240)
                moveSpeed = 240;
        }

        if (objectivesTracker.getNitroActive())
        {
            windImage.enabled = true;
        }

        Vector3 movement = new Vector3(0, 0, moveSpeed) * 0.002f;

        //Move based on the direction you are looking.
        Vector3 updatedPosition = rigidbody.position + rigidbody.transform.TransformDirection(movement);

        rigidbody.MovePosition(updatedPosition);
    }
}
