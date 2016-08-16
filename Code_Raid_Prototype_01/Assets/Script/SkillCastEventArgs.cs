using UnityEngine;

namespace Assets.Script
{
    public class SkillCastEventArgs
    {
        private GameObject source;
        private GameObject target;
        private SkillType type;
        private int value;

        public SkillCastEventArgs(GameObject source, GameObject target, SkillType type, int value)
        {
            this.source = source;
            this.target = target;
            this.type = type;
            this.value = value;
        }

        public GameObject Source
        {
            get { return source; }
        }

        public GameObject Target
        {
            get { return target; }
        }

        public SkillType SkillType
        {
            get { return type; }
        }

        public int HealOrDamageValue
        {
            get { return value; }
        }
    }
}
