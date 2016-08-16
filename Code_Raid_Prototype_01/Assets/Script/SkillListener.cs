using System.Collections.Generic;
using UnityEngine;

namespace Assets.Script
{
    public class SkillListener
    {
        private List<GameObject> observerList = new List<GameObject>();

        public SkillListener()
        {
        }

        public void Alert(SkillCastEventArgs args)
        {
            // -- TODO -- Alert observers using the argument
        }

        public void Attach(GameObject observer)
        {
            observerList.Add(observer);
        }
    }
}
