using UnityEditor;

public class ForceReserializeAssets
{
    [UnityEditor.MenuItem("Tools/Force Reserialize Assets")]
    public static void Reserialize()
    {
        AssetDatabase.ForceReserializeAssets();
    }
}