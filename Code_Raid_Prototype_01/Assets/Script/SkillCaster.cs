using UnityEngine;
using System.Collections;
using Assets.Script;

public class SkillCaster : MonoBehaviour {

    private SkillListener listener;

    public SkillListener Listener
    {
        set
        {
            this.listener = value;
        }
        get { return this.listener; }
    }

}
