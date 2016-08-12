using UnityEngine;
using System.Collections;

public class FlowControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    public void LoadScene()
    {
        Application.LoadLevel("tCombat01");
    }
}
