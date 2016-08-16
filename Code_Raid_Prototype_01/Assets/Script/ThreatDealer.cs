using UnityEngine;
using System.Collections;

public class ThreatDealer : MonoBehaviour {

    private bool isInBattle = false;
    public delegate void ThreatDel(GameObject o);

    public ThreatDel del;
	
	// Update is called once per frame
	void Update () {
	    // -- TODO -- seek opponent
	}
}
