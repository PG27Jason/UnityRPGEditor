using Sirenix.OdinInspector;
using UnityEngine;

namespace UnityRPGEditor
{
    [CreateAssetMenu(menuName = "RPG Editor/New Skill")]
    public class SkillData : ScriptableObject
    {
        [field: SerializeField]
        public string Name { get; private set; }

        [field: SerializeField, TextArea]
        public string Description { get; private set; }

        [field: SerializeField, PreviewField(Height = 100)]
        public Sprite Icon { get; private set; }

        [field: SerializeField]
        public float Cooldown { get; private set; }

        [field: SerializeField]
        public int Cost { get; private set; }

        [field: SerializeField]
        public float CastDuration { get; private set; }

        [field: SerializeField]
        public string ManaCost { get; private set; }

        [field: SerializeField]
        public string Damage { get; private set; }

        [field: SerializeField]
        public DamageType DamageType { get; private set; }
    }
}
