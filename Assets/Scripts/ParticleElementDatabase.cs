using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;


public class ParticleElementDatabase : MonoBehaviour
{
    public Text amountofQuarksText; 
    int amountOfQuarks = 0;

    void Start()
    {
        amountofQuarksText.text = "0" + " Quarks";
        FindObjectOfType<MainQuarkSpawnButton>().QuarkSpawned += HandleQuarkSpawned;
    }


    void HandleQuarkSpawned(object sender, SpawnEventargs e)
    {
        if (e.typeOfElement == "Quark")
        {
            amountOfQuarks += 1;
            amountofQuarksText.text = amountOfQuarks.ToString() + " Quarks";
        }
    }
}
