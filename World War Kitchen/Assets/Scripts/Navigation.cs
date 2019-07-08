using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigation : MonoBehaviour {

    private float airplaneMovementSpeed;
    private float airplaneRotationSpeed;

    private float xRotation;
    private float yRotation;

    public static AudioSource explosionSound;

    void Start()
    {
        explosionSound = GetComponent<AudioSource>();

        this.airplaneMovementSpeed = 1.0f;
        this.airplaneRotationSpeed = 1.0f;

        this.xRotation = 0.0f;
        this.yRotation = 0.0f;
    }

    void Update()
    {
        this.transform.position += this.transform.forward * Time.deltaTime * airplaneMovementSpeed;
        xRotation += GvrVRHelpers.GetHeadRotation().x;
        yRotation += -GvrVRHelpers.GetHeadRotation().z;

        this.transform.eulerAngles = new Vector3(xRotation, yRotation, 0.0f);
    }


    public static void explode()
    {
        explosionSound.Play();
    }
}
