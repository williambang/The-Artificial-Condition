using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class Cloud_Script : MonoBehaviour
{
    public int stackSize = 10;
    public Mesh mesh;
    public Material material;
    public float cloudHeight = 1f;
    public float offset = 0;

    private Matrix4x4 matrix;

    public void Update() {

        material.SetFloat("cloudHeight", cloudHeight);
        material.SetFloat("midValue", transform.position.y);

        offset = cloudHeight / stackSize * 0.5f;
        Vector3 startPosition = transform.position + (Vector3.up * offset * stackSize * 0.5f);
        for (int i = 0; i < stackSize; i++) {
            
            Vector3 rotation = new Vector3(90f, transform.rotation.y, transform.rotation.z);
            matrix = Matrix4x4.TRS(startPosition - (Vector3.up * offset * i), Quaternion.Euler(rotation), transform.localScale);
            Graphics.DrawMesh(mesh, matrix, material, 0);

        }
    }
    /*
    public int horizontalStackSize = 20;
    public float cloudHeight;
    public Mesh quadMesh;
    public Material cloudMaterial;
    float offset;
    // Update is called once per frame
    void Update()
    {


        
    }*/
}
 