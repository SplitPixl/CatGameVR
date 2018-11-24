using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatMaker : MonoBehaviour {

    public GameObject catFab;
    public Transform startPos;

    // Use this for initialization
    void Start () {
        
    }
    
    // Update is called once per frame
    void Update () {
        
    }

    public void SpawnNew () {
        GameObject newCat = Instantiate(catFab);

        newCat.transform.position = startPos.transform.position;
        newCat.GetComponent<Rigidbody>().velocity = new Vector3(0, 10, -2.5f);
    }
}
