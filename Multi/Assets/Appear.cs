using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Appear : MonoBehaviour
{
    private Mesh mesh;
    
    // Start is called before the first frame update
    void Start()
    {
        Mesh m = GetComponent<MeshFilter>().mesh;
        mesh.bounds = new Bounds(Vector3.zero, Vector3.one * 2000);
    }
}
