using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Scene_Managers))]
public class scnMngr_UI : Editor
{
    // Start is called before the first frame update

    public override void OnInspectorGUI(){

        base.OnInspectorGUI();
        
        Scene_Managers scnMng = (Scene_Managers)target;

        if(GUILayout.Button("Load Scenes")) {
            scnMng.LoadAllScenes();
        }
    }

}

