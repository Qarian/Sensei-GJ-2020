using SenseiGameJam.DependencyInjection;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Progress
{
    public bool properAutoSettings;
    public float minBloom = 1f;
    public float maxBloom = 20f;
    public int minResolution = 5;

    public bool CanProceed(float currentBloom, int currentResolution)
    {
        return currentResolution >= minResolution && currentBloom > minBloom && currentBloom <= maxBloom;
    }
}
