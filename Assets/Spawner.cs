using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    [SerializeField] private int numberOfKitties = 10;

    public GameObject kitties;

    private Transform _spawnerTransform;

    private void Start()
    {
        _spawnerTransform = transform;
        for (int i = 1; i <= numberOfKitties; i++)
        {
            Vector3 kittyPosition = _spawnerTransform.position;
            kittyPosition.x += Random.Range(-10, 11);
            kittyPosition.y += Random.Range(-5, 5);
            Transform kittyTransform =  Instantiate(kitties, _spawnerTransform).transform;
            kittyTransform.position = kittyPosition; 
        }
    }
    
}
