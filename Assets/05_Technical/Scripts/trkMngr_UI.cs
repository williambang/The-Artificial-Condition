using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(track_manager))]
public class trkMngr_UI : Editor
{
    // Start is called before the first frame update

    public override void OnInspectorGUI(){

        base.OnInspectorGUI();
        
        track_manager trkMngr = (track_manager)target;

        if(GUILayout.Button("Assign Sets")) {
            trkMngr.AddSetToTracks();
        }
    }

}

