namespace SenseiGameJam.SettingsPack
{
    public interface ISetting<T>
    {
        T GetValue();

        void SetValue(T value);

        void StartSetting();

        void UpdateSetting();

        void FixedUpdateSetting();

        void LateUpdateSetting();

        void OnSceneLoad();
    }
}