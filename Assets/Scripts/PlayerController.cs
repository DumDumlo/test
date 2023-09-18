using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Configurable Variables
    [Header("Cached Refrences")]
    [SerializeField] Rigidbody playerRigidbody = null;

    [Header("Movement")]
    [SerializeField] float thrustForce = 1000.0f;
    [SerializeField] float rotationRate = 50f;

    //Private Varibles

    //Cached Refrences


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        ProcessThrust();
        ProcessRotation();
    }

    void ProcessThrust()
    {
        if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            playerRigidbody.AddRelativeForce(Vector3.up * thrustForce * Time.deltaTime);
        }
    }

    void ProcessRotation()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            ApplyRotation(1.0f);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            ApplyRotation(-1.0f);
        }
    }

    public void ApplyRotation(float desiredRotation)
    {
        playerRigidbody.freezeRotation = true;
        transform.Rotate(Vector3.forward * desiredRotation * rotationRate * Time.deltaTime);
    }
}