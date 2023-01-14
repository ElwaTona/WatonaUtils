using System;

namespace Watona.Variables
{
    [Serializable]
    public class VariableReference<T>
    {
        public bool UseConstant = true;
        public T ConstantValue;
        public Variable<T> Variable;

        public VariableReference(){}

        public VariableReference(T value)
        {
            UseConstant = true;
            ConstantValue = value;
        }

        public T Value => UseConstant ? ConstantValue : Variable.Value;

        public static implicit operator T(VariableReference<T> reference) => reference.Value;
    }
}