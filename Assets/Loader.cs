using UnityEngine;
using System.Collections;

public class Loader : MonoBehaviour
{
    string text;

    IEnumerator Start()
    {
        var www = new WWW("file:" + Application.streamingAssetsPath + "/sprite");
        yield return www;

        while (true)
        {
            foreach (var asset in www.assetBundle.LoadAllAssets<Sprite>())
            {
                GetComponent<SpriteRenderer>().sprite = asset;
                text = asset.name;

                yield return new WaitForSeconds(1);
            }
        }
    }

    void OnGUI()
    {
        GUI.Label(new Rect(0, 0, 100, 100), text);
    }
}
