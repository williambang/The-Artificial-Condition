using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class Shake_Script : MonoBehaviour
{
    public float magnitude;
    public float maxOffset = 200f;
    public float minOffset = 200f;
    public Light lht;

    public float originalIntensity = 1000f;

    // Update is called once per frame
    
    void Start() {
        originalIntensity = lht.intensity;
    }
    
    void Update()
    {
        if(lht) {
                
                lht.intensity = Random.Range(originalIntensity - minOffset, originalIntensity + maxOffset );
        }
        else {
            lht = GetComponent<Light>();
        }

        Vector3 originalPos = transform.localPosition;
        float x = originalPos.x + Random.Range(-1f, 1f) * magnitude;
        float y = originalPos.y + Random.Range(-1f, 1f) * magnitude;
        float z = originalPos.z + Random.Range(-1f, 1f) * magnitude;

        transform.localPosition = new Vector3(x, y, z);
    }
}
