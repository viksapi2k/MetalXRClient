using UnityEditor;
using UnityEngine;
using System.Linq;

public class ForceSingleSceneBuild
{
    [InitializeOnLoadMethod]
    static void Setup()
    {
        const string scenePath = "Assets/Scenes/PreOC.unity";

        var sceneAsset = AssetDatabase.LoadAssetAtPath<SceneAsset>(scenePath);

        if (sceneAsset == null)
        {
            Debug.LogError("Scene not found: " + scenePath);
            return;
        }

        EditorBuildSettings.scenes = new[]
        {
            new EditorBuildSettingsScene(scenePath, true)
        };

        Debug.Log("Forced build scene: " + scenePath);
    }
}
