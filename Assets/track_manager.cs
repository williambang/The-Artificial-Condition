using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;
using UnityEngine.Playables;
using System.Linq;
using System; 

[System.Serializable]
 public class setTrack {
     public GameObject ShotTimeline;
     public string setGrp;
 }

[ExecuteInEditMode]
public class track_manager : MonoBehaviour
{

    [MultilineAttribute(2)]
    public string note = "Remember to name the actual activation track what you wrote below, \n default is SET_TRACK";
    public string trackName = "SET_TRACK";
    public string setMngrName = "SET_MANAGER";
    [Space]
    public List<setTrack> SetTracks = new List<setTrack>();

    // Start is called before the first frame update
    void Start()
    {   
        AddSetToTracks();
    }

    void AddSetToTracks() {
        Set_Manager setMngr = GameObject.Find(setMngrName).GetComponent<Set_Manager>();

        foreach(setTrack item in SetTracks) {
            foreach(GameObject SetGrp in setMngr.sets) {
                if(SetGrp.name == item.setGrp) {
                    var director = item.ShotTimeline.GetComponent<PlayableDirector>();
                    if(SetGrp && director) {
                        var track = director.playableAsset.outputs.First(c => c.streamName == trackName);
                        if(track.sourceObject){
                            director.SetGenericBinding (track.sourceObject, SetGrp);
                        }
                        
                    }
                }

            }
        }
    }
 
}
