using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatFlavor : MonoBehaviour {

    public Texture[] flavors;

    // Use this for initialization
    void Start () {
        int flavor = Random.Range(0, flavors.Length);
        GetComponent<MeshRenderer>().materials[0].mainTexture = flavors[flavor]; 
    }

    // Update is called once per frame
    void Update () {
        
    }
}
