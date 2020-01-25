using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SenseiGameJam.SettingsPack
{
    public class InputSettings : MonoBehaviour
    {
        public ISetting<KeyCode> jump;

        void Update()
        {
            if(jump != null)
            {
                jump.UpdateSetting();
            }
            else
            {
                Debug.LogError("jump not set");
            }
        }
    }
}