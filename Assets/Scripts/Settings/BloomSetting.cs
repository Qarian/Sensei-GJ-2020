using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace SenseiGameJam.SettingsPack
{
    public class BloomSetting : MonoBehaviour, ISetting<float>
    {
        [SerializeField]
        float value = 0;

        [SerializeField]
        private PostProcessProfile profile;

        private void Start()
        {
            profile = Resources.Load("PostProcessing/Post-processing Profile", typeof(PostProcessProfile)) as PostProcessProfile;
        }

        public void FixedUpdateSetting()
        {
            throw new System.NotImplementedException();
        }

        public float GetValue()
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

        public void SetValue(float value)
        {
            this.value = value;
            profile.GetSetting<Bloom>().intensity.value = value;
        }

        public void SetProfile(PostProcessProfile profile)
        {
            this.profile = profile;
        }

        public void StartSetting()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateSetting()
        {
            //throw new System.NotImplementedException();
        }
    }
}