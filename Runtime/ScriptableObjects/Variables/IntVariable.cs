using UnityEngine;

namespace Watona.Variables
{
    [CreateAssetMenu(menuName = "Variable/Int")]
    public class IntVariable : Variable<int>
    {
        public void ApplyChange(int amount)
        {
            Value += amount;
        }
        public void ApplyChange(IntVariable amount)
        {
            Value += amount.Value;
        }

        public void ApplyChangeWithoutNotify(int amount)
        {
            this.value += amount;
        }
        public void ApplyChangeWithoutNotify(IntVariable amount)
        {
            this.value += amount.Value;
        }
    }
}