using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class CatFactText : MonoBehaviour {

    public Text factText;
    CatFact currentFact = null;

    // Use this for initialization
    void Start() {
        StartCoroutine(GetFact());
    }

    // Update is called once per frame
    void Update() {
        if (currentFact != null && factText.text != currentFact.fact) {
            factText.text = currentFact.fact;
        }
    }

    IEnumerator GetFact() {
        UnityWebRequest factReq = UnityWebRequest.Get("https://catfact.ninja/fact");
        yield return factReq.SendWebRequest();

        if (factReq.isNetworkError || factReq.isHttpError) {
            Debug.LogWarning(factReq.error);
        } else {
            string jsonFact = factReq.downloadHandler.text;
            currentFact = CatFact.CreateFromJSON(jsonFact);
        }
    }
}
