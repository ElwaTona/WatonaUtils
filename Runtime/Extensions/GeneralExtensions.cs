using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Watona.Utils
{
    public static class GeneralExtensions
    {
        public static float AsPercentOfFixedDeltaTime(this float thisFloat) => Time.fixedDeltaTime / thisFloat;

        /// <summary>
        /// Returns the current vector with a new Y
        /// </summary>
        public static Vector3 WithNewY(this Vector3 vector, float newY) => new Vector3(vector.x, newY, vector.z);

        /// <summary>
        /// Returns the current vector with a new X
        /// </summary>
        public static Vector2 WithNewX(this Vector2 vector, float newX) => new Vector2(newX, vector.y);
        
        ///<summary> Returns the array including the new item </summary>
        public static T[] With<T>(this T[] array, T item)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = item;
            return array;
        }
        ///<summary> Returns the array without the new item </summary>
        public static T[] Without<T>(this T[] array, T item)
        {
            for (int i = Array.IndexOf(array, item); i < array.Length - 1; i++)
                {
                    // moving elements downwards, to fill the gap at [index]
                    array[i] = array[i + 1];
                }
            // finally, let's decrement Array's size by one
            Array.Resize(ref array, array.Length - 1);
            return array;
        }
    }
}