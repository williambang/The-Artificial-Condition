using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(SnapshotCamera))]
public class Button : Editor {

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        SnapshotCamera camera = (SnapshotCamera)target;
        
        if (GUILayout.Button("Take Screenshot"))
        {
            Debug.Log("taking Snapshot");
            camera.CallTakeSnapshot();
        }
    }

}
