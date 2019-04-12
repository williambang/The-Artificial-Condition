using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array_Modifier : MonoBehaviour
{

    public GameObject MasterObject;

    [Range(1,40)]
    public int CountX = 1;
    [Range(1,40)]
    public int CountY = 1;
    [Range(1,40)]
    public int CountZ = 1;
    public Vector3 Offset = new Vector3(0.5f, 0.5f, 0.5f);

    void OnValidate()
    {
        Apply();
    }

    private void Apply() {
        if (UnityEditor.EditorApplication.isPlayingOrWillChangePlaymode) {
            return;
        }
        if (MasterObject == null) {
            return;
        }

        //Renderer renderer = MasterObject.GetComponent<Renderer>();

        foreach (Transform t in transform) {
            //Destroy All.
            UnityEditor.EditorApplication.delayCall += () =>
            {
                DestroyImmediate(t.gameObject);
            };
        }

        float lastX = 0;
        float lastY = 0;
        float lastZ = 0;

        for (int h = 0; h < CountZ; h++) {
            for (int i = 0; i < CountY; i++) {
                for (int j = 0; j < CountX; j++) {

                    /*/Vector3 pos = new Vector3(
                        lastX + transform.localPosition.x, 
                        lastY + transform.localPosition.y,
                        lastZ + transform.localPosition.z);*/

                    Vector3 pos = new Vector3(lastX, lastY, lastZ);

                    GameObject go = Instantiate(MasterObject, pos, Quaternion.identity, transform);
                    go.transform.localPosition = pos;

                    go.name = MasterObject.name + "_" + i + "_" + j + "_" + h;

                    lastX += 1 + Offset.x;

                }
                    lastX = transform.localPosition.x;
                    lastY += 1 + Offset.y;
                    
            }
            lastY = transform.localPosition.y;
            lastZ += 1 + Offset.z;
        }
    }
}
