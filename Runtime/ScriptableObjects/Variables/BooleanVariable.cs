// ----------------------------------------------------------------------------
// Unite 2017 - Game Architecture with Scriptable Objects
// 
// Author: Ryan Hipple
// Date:   10/04/17
// ----------------------------------------------------------------------------

using UnityEngine;

namespace Watona.Variables
{
    [CreateAssetMenu(menuName = "Variable/Boolean")]
    public class BooleanVariable : Variable<bool> 
    {
        public void Flip()
        {
            Value = !Value;
        }
    }
}