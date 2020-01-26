using SenseiGameJam.DependencyInjection;
using SenseiGameJam.SettingsPack;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    [SerializeField] private int numberOfKitties = 700;

    public GameObject kitties;

    List<Rigidbody2D> kittensList = new List<Rigidbody2D>();

    private Transform _spawnerTransform;
    private Settings settings;

    private void Start()
    {
        SetNumber(Settings.settings.catsNumber);
        SetGravity(Settings.settings.gravity);
    }

    public void SetGravity(bool gravity)
    {
        if (!gravity)
        {
            for (int i = 0; i <= kittensList.Count; i++)
            {
                kittensList[i].isKinematic = true;
            }
        }
        else
        {
            for (int i = 0; i <= kittensList.Count; i++)
            {
                kittensList[i].isKinematic = false;
            }
        }
       
    }
    public void SetNumber(int kittyNumber)
    {
        numberOfKitties = kittyNumber;
        _spawnerTransform = transform;
        for (int i = 1; i <= kittyNumber; i++)
        {
            Vector3 kittyPosition = _spawnerTransform.position;
            kittyPosition.x += Random.Range(-10, 10);
            kittyPosition.y += Random.Range(-5, 20);
            Transform kittyTransform = Instantiate(kitties, _spawnerTransform).transform;
            kittyTransform.position = kittyPosition;
            kittensList.Add(kittyTransform.GetComponent<Rigidbody2D>());
        }
    }

}
