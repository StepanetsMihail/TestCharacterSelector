using UnityEditor;
using UnityEngine;

public class GlobalDataViewEditor : EditorWindow
{
    [MenuItem("Window/Custom View/GlobalSettings")]
    public static void ShowWindow()
    {
        GlobalDataViewEditor window = GetWindow<GlobalDataViewEditor>();
        window.titleContent = new GUIContent("GlobalData");
        window.Show();
    }

    private void OnGUI()
    {
        EditorGUILayout.IntField("Selected Character ", GlobalData.CharacterPrefabIndex);
    }
}