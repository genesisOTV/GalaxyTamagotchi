using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainQuarkSpawnButton : MonoBehaviour {

    //public Object spawnOriginal;
    //float x = -8;
    string typeOfElement = "Quark";

    public event QuarkSpawnHandler QuarkSpawned;

    //public void SpawnSht ()
    //{
    //    Instantiate(spawnOriginal, new Vector3(x, 3), Quaternion.identity);
    //}

    public void Incrementor ()
    {
        //x++;
        QuarkSpawned(this, new SpawnEventargs(typeOfElement));
    }
}
