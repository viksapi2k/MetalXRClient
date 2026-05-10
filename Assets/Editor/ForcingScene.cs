using UnityEditor;
using UnityEngine;

[InitializeOnLoad]
public class ForceSceneLateFix
{
    static ForceSceneLateFix()
    {
        EditorApplication.delayCall += Setup;
    }

    static void Setup()
    {
        const string scenePath = "Assets/Scenes/PreOC.unity";

        var scene = new EditorBuildSettingsScene(scenePath, true);

        EditorBuildSettings.scenes = new[] { scene };

        Debug.Log("Forced BUILD scene: " + scenePath);
    }
}
