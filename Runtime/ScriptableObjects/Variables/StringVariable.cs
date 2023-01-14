using UnityEngine;

namespace Watona.Variables
{
    [CreateAssetMenu(menuName = "Variable/String")]
    public class StringVariable : Variable<string>
    {
        public void AddValue(string value)
        {
            Value += value;
        }
        public void AddValue(StringVariable variable)
        {
            Value += variable.Value;
        }
    }
}