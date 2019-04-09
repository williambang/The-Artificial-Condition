using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using UnityEditor.SceneManagement;

[ExecuteInEditMode]
public class Scene_Managers : MonoBehaviour
{
    public string folder;
    public string[] Scenes; 
    // Start is called before the first frame update
    void Start() {

        if(!Application.isPlaying)
        {
            LoadAllScenes();
        }
        
    } 

    public void LoadAllScenes() {
        foreach(string scn in Scenes) {
            string path = "Assets/00_Scenes/" + folder + "/" + scn + ".unity";
            EditorSceneManager.OpenScene(path, OpenSceneMode.Additive);
        }
    } 

}
