using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameFramwork
{
    public class Singleton<T> where T : new()
    {
        private static T _instance;

        public static T GetInstance()
        {
            if (_instance == null)
                _instance = new T();
            return _instance;
        }
    }

    public class SingletonMono<T> : MonoBehaviour where T : MonoBehaviour
    {
        private static T _instance;

        public static T GetInstance()
        {
            if (_instance == null)
            {
                GameObject gameObj = new GameObject();
                _instance = gameObj.AddComponent<T>();
                gameObj.name = typeof(T).Name;
                GameObject.DontDestroyOnLoad(gameObj);
            }
            return _instance;
        }
    }
}
