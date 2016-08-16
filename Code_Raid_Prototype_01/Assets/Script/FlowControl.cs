using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class FlowControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    public void LoadScene()
    {
        SceneManager.LoadScene("tCombat01");
    }
}
