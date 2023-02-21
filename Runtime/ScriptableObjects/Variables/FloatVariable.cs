using UnityEngine;

namespace Watona.Variables
{
    [CreateAssetMenu(menuName = "Variable/Float")]
    public class FloatVariable : Variable<float>
    {
        public void ApplyChange(float amount)
        {
            Value += amount;
        }
        public void ApplyChange(FloatVariable amount)
        {
            Value += amount.Value;
        }

        public void ApplyChangeWithoutNotify(float amount)
        {
            this.value += amount;
        }
        public void ApplyChangeWithoutNotify(FloatVariable amount)
        {
            this.value += amount.Value;
        }
    }
}