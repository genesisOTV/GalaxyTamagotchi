using System.Collections;
using System.Collections.Generic;
using System;

public class SpawnEventargs : EventArgs {

    public SpawnEventargs(string typeOfElement)
    {
        this.typeOfElement = typeOfElement;
    }

    public string typeOfElement { get; set; }
}
