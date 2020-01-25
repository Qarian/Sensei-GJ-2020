using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SenseiGameJam.SettingsPack
{
    public class JumpSetting : MonoBehaviour, ISetting<KeyCode>
    {
        KeyCode value;

        public void FixedUpdateSetting()
        {
            throw new System.NotImplementedException();
        }

        public KeyCode GetValue()
        {
            return value;
        }

        public void LateUpdateSetting()
        {
            throw new System.NotImplementedException();
        }

        public void OnSceneLoad()
        {
            throw new System.NotImplementedException();
        }

        public void SetValue(KeyCode value)
        {
            this.value = value;
        }

        public void StartSetting()
        {
            value = KeyCode.None;
        }

        public void UpdateSetting()
        {
            throw new System.NotImplementedException();
        }
    }
}