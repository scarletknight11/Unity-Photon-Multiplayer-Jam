using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptableObjectSingleton<T> : ScriptableObject where T: ScriptableObject {

    private static T _instance = null;

    public static T instance
    {
        get
        {
            if (_instance == null)
            {
                T[] results = Resources.FindObjectsOfTypeAll<T>();
                if(results.Length == 0)
                {
                    Debug.LogError("SingletonScriptabb -> Instance -> results length in 0 for type " + typeof(T).ToString() + ".");
                    return null;
                }

                if (results.Length > 1)
                {
                    Debug.LogError("SingletonScriptabb -> Instance -> results length greater then 1 for type " + typeof(T).ToString() + ".");
                    return null;
                }
            }
            return _instance;
        }
    }
     
}
