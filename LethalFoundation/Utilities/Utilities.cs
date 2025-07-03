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
        public static T TrySeekComponent<T>(ref T target, T possibleSource = null) where T : Component
        {
            target = TrySeekWithPossibleSource(ref target, possibleSource);
            return (target != null ? target : SeekComponent(ref target));
        }

        public static T TrySeekComponent<T>(ref T target, string possibleSourceTag) where T : Component
        {
            target = TrySeekWithPossibleSource(ref target, possibleSourceTag);
            return (target != null ? target : SeekComponent(ref target));
        }

        public static GameObject TrySeekGameObject(ref GameObject target, string possibleSourceTag)
        {
            if (target == null)
                target = GameObject.FindGameObjectWithTag(possibleSourceTag);
            return (target);
        }

        public static T TrySeekScriptableObject<T>(ref T target, T possibleSource = null) where T : ScriptableObject
        {
            target = TrySeekWithPossibleSource(ref target, possibleSource);
            return (target != null ? target : SeekScriptableObject(ref target));
        }

        private static T SeekScriptableObject<T>(ref T target) where T : ScriptableObject
        {
            T[] resources = Resources.FindObjectsOfTypeAll<T>();
            if (resources != null && resources.Length > 0)
                target = resources[0];
            return (target);
        }

        private static T SeekComponent<T>(ref T target) where T : Component
        {
            T result = UnityEngine.Object.FindFirstObjectByType<T>();
            if (result != null)
                target = result;
            return (target);
        }


        public static T TrySeekWithPossibleSource<T>(ref T target, T possibleSource = null) where T : UnityEngine.Object
        {
            if (target == null && possibleSource != null)
                target = possibleSource;
            return (target);
        }

        public static T TrySeekWithPossibleSource<T>(ref T target, string objectTag) where T : UnityEngine.Object
        {
            if (string.IsNullOrEmpty(objectTag)) return (target);
            return (TrySeekWithPossibleSource(ref target, GameObject.FindGameObjectWithTag(objectTag)?.GetComponent<T>()));
        }

        public static void Insert<T>(ref T[] array, T newItem)
        {
            if (array == null) array = [];
            array = array.AddItem(newItem).ToArray();
        }

        public static T[] Add<T>(T[] array, T value)
        {
            return (array.AddItem(value).ToArray());
        }

        public static List<T> GetEnemiesOfType<T>() where T : EnemyAI
        {
            List<T> list = new List<T>();
            foreach (EnemyAI enemy in Refs.SpawnedEnemies)
                if (enemy is T casted)
                    list.Add(casted);
            return (list);
        }
    }
}
