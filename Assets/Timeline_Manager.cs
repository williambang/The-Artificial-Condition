using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using System.Collections;
using UnityEngine.Timeline;


[System.Serializable]
public class Shot_Item {
    public GameObject Set;
    public PlayableDirector Shot;
}

[ExecuteInEditMode]
public class Timeline_Manager : MonoBehaviour
{
    public Shot_Item[] shots;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(shots[0].Shot.playableAsset.outputs);
    }

}
 