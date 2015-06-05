using UnityEngine;
using UnityEditor;

public class AssetBundleTool
{
    [MenuItem("Tool/Build AssetBundles")]
    static void BuildAssetBundles()
    {
        BuildPipeline.BuildAssetBundles("Assets/StreamingAssets");
    }
}
