using UnityEngine;
using UnityEngine.SceneManagement;

public static class SceneExtensions
{
    /// <summary>
    /// Find Root GameObject Component
    /// </summary>
    /// <param name="self"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T FindRootGameObjectComponent<T>(this Scene self) where T : Component
    {
        GameObject[] gameObjects = self.GetRootGameObjects();
        foreach (var gameObject in gameObjects)
        {
            T component = gameObject.GetComponent<T>();
            if (component != null)
            {
                return component;
            }
        }

        return null;
    }
    
    /// <summary>
    /// Find Root GameObject Component by name
    /// </summary>
    /// <param name="self"></param>
    /// <param name="name"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T FindRootGameObjectComponent<T>(this Scene self, string name) where T : Component
    {
        GameObject[] gameObjects = self.GetRootGameObjects();
        foreach (var gameObject in gameObjects)
        {
            if (gameObject.name != name) continue;
            T component = gameObject.GetComponent<T>();
            if (component != null)
            {
                return component;
            }
        }

        return null;
    }
    
    /// <summary>
    /// 获取场景中的组件
    /// </summary>
    public static T FindComponentInScene<T>(this Scene self,bool includeInactive = false) where T : Component
    {
        var rootObjects = self.GetRootGameObjects();
        foreach (var v in rootObjects)
        {
            var comp = v.GetComponentInChildren<T>(includeInactive);
            if (comp != null)
            {
                return comp;
            }
        }

        return null;
    }



}