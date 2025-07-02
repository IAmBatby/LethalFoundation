using DunGen.Graph;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace LethalFoundation
{
    public static class Utilities
    {
        public static T TrySeekObject<T>(ref T reference, T possibleSource = null) where T : UnityEngine.Object
        {
            reference = reference != null ? reference : possibleSource != null ? possibleSource : UnityEngine.Object.FindFirstObjectByType<T>();
            return (reference);
        }

        public static T TrySeekResource<T>(ref T reference, T possibleSource = null) where T : UnityEngine.Object
        {
            reference = reference != null ? reference : possibleSource != null ? possibleSource : null;
            if (reference == null)
            {
                T[] resources = Resources.FindObjectsOfTypeAll<T>();
                if (resources != null && resources.Length > 0)
                    reference = resources[0];
            }
            return (reference);
        }

        public static T[] Add<T>(T[] array, T value)
        {
            return (array.AddItem(value).ToArray());
        }
    }
}
