
using UnityEngine;

public static class PlaneExtensions
{
    /// <summary>
    /// 获取平面与射线的交点
    /// </summary>
    /// <param name="self"></param>
    /// <param name="origin"></param>
    /// <param name="direction"></param>
    /// <returns></returns>
    public static Vector3? Intersections(this Plane self, Vector3 origin, Vector3 direction)
    {
        float denominator = Vector3.Dot(self.normal, direction);

        // 判断方向是否与平面平行
        if (Mathf.Approximately(denominator, 0f))
        {
            return null; // 无交点
        }

        float numerator = Vector3.Dot(self.normal, origin) + self.distance;
        float t = -numerator / denominator;

        return origin + t * direction;
    }

}