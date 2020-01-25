using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using SenseiGameJam.DependencyInjection;
using SenseiGameJam.SettingsPack;
using TMPro;

public class ButtonListener : MonoBehaviour
{
    IDependency dependency;
    Settings settings;
    [SerializeField]
    Coroutine listenCoroutine;
    [SerializeField]
    KeyCode code;
    TextMeshProUGUI text;

    void Start()
    {
        listenCoroutine = null;
        text = GetComponentInChildren<TextMeshProUGUI>();
        SetDI();
        text.text = settings.input.jump.GetValue().ToString();
    }

    void SetDI()
    {
        if(settings == null)
        {
            DI.GetSingleton(typeof(Settings), out dependency);
            settings = (Settings)dependency;
        }
    }

    public void Listen()
    {
        if(listenCoroutine == null)
        {
            listenCoroutine = StartCoroutine(ListenAction());
        }
        else
        {
            Debug.Log("Can't enter");
        }
    }

    IEnumerator ListenAction()
    {
        bool isClicked = false;
        while(!isClicked)
        {
            if(Input.anyKeyDown)
            {
                foreach(KeyCode kcode in Enum.GetValues(typeof(KeyCode)))
                {
                    if(Input.GetKey(kcode))
                    {
                        SetDI();
                        code = kcode;
                        settings.input.jump.SetValue(code);
                        text.text = code.ToString();
                        Debug.Log("KeyCode down: " + kcode);
                        isClicked = true;
                        Debug.Log("Exit listener");
                    }                               
                }                                                              
            }
            yield return null;
        }
        listenCoroutine = null;
    }
}
