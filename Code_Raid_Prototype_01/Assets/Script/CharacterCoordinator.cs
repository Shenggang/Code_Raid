using UnityEngine;
using System.Collections.Generic;
using Assets.Script;

public class CharacterCoordinator : MonoBehaviour {
    private List<GameObject> characters = new List<GameObject>();
    private List<GameObject> enemies = new List<GameObject>();
    private SkillListener listener = new SkillListener();

    void Start () {
        List<GameObject> temp = new List<GameObject>();
        GetComponents<GameObject>(temp);
        instantiate(temp);
	}
	
    private void instantiate(List<GameObject> temp)
    {
        foreach (GameObject o in temp)
        {
            distinguishObjectByTag(o);
        }

        foreach (GameObject o in enemies)
        {
            o.AddComponent<ThreatDealer>();
            ThreatDealer d = o.GetComponent<ThreatDealer>();
            d.del = PutEnemyOnAlert;
        }

        foreach (GameObject o in characters)
        {
            o.AddComponent<SkillCaster>();
            SkillCaster s = o.GetComponent<SkillCaster>();
            s.Listener = this.listener;
        }

    }

    private void distinguishObjectByTag(GameObject o)
    {
        if (o.tag == "Character")
        {
            characters.Add(o);
        }
        if (o.tag == "Enemy")
        {
            enemies.Add(o);
        }
    }

    private void PutEnemyOnAlert(GameObject sender)
    {
        listener.Attach(sender);
    }
}
