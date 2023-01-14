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
    }
}