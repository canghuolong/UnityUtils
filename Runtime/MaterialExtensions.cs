
using UnityEngine;

public static class MaterialExtensions
{
    public static Material Keyword(this Material m, string name, bool val)
    {
        if (val)
        {
            m.EnableKeyword(name);
        }
        else
        {
            m.DisableKeyword(name);
        }

        return m;
    }
}