using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CatFact {
    public string fact;
    public int length;

    public static CatFact CreateFromJSON(string jsonString) {
        return JsonUtility.FromJson<CatFact>(jsonString);
    }
}