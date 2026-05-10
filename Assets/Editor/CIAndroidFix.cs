using UnityEditor;

public class CIAndroidFix
{
    [InitializeOnLoadMethod]
    static void ForceAndroidSettings()
    {
        PlayerSettings.Android.targetArchitectures = AndroidArchitecture.ARM64;

        PlayerSettings.SetScriptingBackend(
            BuildTargetGroup.Android,
            ScriptingImplementation.IL2CPP
        );
    }
}
