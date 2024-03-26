using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

public class SceneSwitcherWindow : EditorWindow
{
    private Vector2 scrollPosition = Vector2.zero;

    [MenuItem("Window/Custom View/Scene Switcher")]
    public static void ShowWindow()
    {
        GetWindow<SceneSwitcherWindow>("Scene Switcher");
    }

    private void OnGUI()
    {
        GUILayout.Label("Switch to Scene:", EditorStyles.boldLabel);

        string[] scenePaths = EditorBuildSettingsScene.GetActiveSceneList(EditorBuildSettings.scenes);

        float totalHeight = scenePaths.Length * EditorGUIUtility.singleLineHeight;

        float windowHeight = position.height;
        bool needsScrollView = totalHeight > windowHeight;

        if (needsScrollView)
        {
            scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition, GUILayout.Height(windowHeight));
        }

        float columnWidth = position.width / 2f;

        for (int i = 0; i < scenePaths.Length; i += 2)
        {
            EditorGUILayout.BeginHorizontal();

            if (GUILayout.Button(GetSceneName(scenePaths[i]), EditorStyles.miniButton, GUILayout.Width(columnWidth)))
            {
                SwitchToScene(scenePaths[i]);
            }

            if (i + 1 < scenePaths.Length)
            {
                if (GUILayout.Button(GetSceneName(scenePaths[i + 1]), EditorStyles.miniButton, GUILayout.Width(columnWidth)))
                {
                    SwitchToScene(scenePaths[i + 1]);
                }
            }

            EditorGUILayout.EndHorizontal();
        }

        if (needsScrollView)
        {
            EditorGUILayout.EndScrollView();
        }
    }

    private void SwitchToScene(string scenePath)
    {
        if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
        {
            EditorSceneManager.OpenScene(scenePath);
        }
    }

    private string GetSceneName(string scenePath)
    {
        return System.IO.Path.GetFileNameWithoutExtension(scenePath);
    }
}

