using UnityEditor;

///I hope it will work

public class ForceAndroidArch
{
    [InitializeOnLoadMethod]
    static void Setup()
    {
        PlayerSettings.Android.targetArchitectures =
            AndroidArchitecture.ARM64;
    }
}
