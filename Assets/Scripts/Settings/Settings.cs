﻿using System.Collections;
using System.Collections.Generic;
using SenseiGameJam.DependencyInjection;
using UnityEngine;

namespace SenseiGameJam.SettingsPack
{
    public class Settings : MonoBehaviour, IDependency
    {
        public int intputRes = 0;
        public int catsNumber = 650;
        public bool gravity = true;

        public ISetting<bool> autoSettings;
        public ISetting<float> bloom;
        public ISetting<Resolution> resolution;
        public ISetting<int> cats;
        public InputSettings input;
        public ISetting<bool> specialSettings;
        public Progress progress = new Progress();
        public static Settings settings;

        void Awake()
        {
            if(settings== null)
            {
                settings = new Settings();
            }
        }
        
        // Start is called before the first frame update
        void Start()
        {
            Debug.Log("Settings REGISTERED");
            DI.RegisterSingleton(typeof(Settings),this);
            DontDestroyOnLoad(this.gameObject);
            settings = this;
        }

        // Update is called once per frame
        void Update()
        {
            if (bloom != null)
            {
                bloom.UpdateSetting();
            }
            else
            {
                Debug.LogError("bloom not set");
            }
            if(resolution != null)
            {
                resolution.UpdateSetting();
            }
            else
            {
                Debug.LogError("resolution not set");
            }
            if(cats != null)
            {
                cats.UpdateSetting();
            }
            else
            {
                Debug.LogError("cats not set");
            }
            if(specialSettings != null)
            {
                specialSettings.UpdateSetting();
            }
            else
            {
                Debug.LogError("specialSettings not set");
            }
        }
    }
}