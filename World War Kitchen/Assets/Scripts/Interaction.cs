using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour {

    private int targetLife;

    

    void Start()
    {
        this.targetLife = 3;
    }

    void Update()
    {

    }

    public void Damage()
    {
        this.targetLife--;
        if (this.targetLife <= 0)
        {
            gameObject.SetActive(false);
            Navigation.explode();

        }
    }

}
