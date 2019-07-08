using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

    public AudioSource shotgunSound;

    void Start()
    {

    }

    void Update()
    {

        if(Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        shotgunSound.Play();
    }
}
