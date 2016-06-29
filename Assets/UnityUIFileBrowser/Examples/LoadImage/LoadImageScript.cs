using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;

[DisallowMultipleComponent]
public class LoadImageScript : MonoBehaviour
{

    public Image imageField;

    [SerializeField]
    private FileBrowserScript browserScript;

    public void OpenBrowser()
    {
        browserScript.SelectEventName = "LoadImage"; //Same as bellow (image loading method)
        browserScript.OpenFileBrowser(this);
    }

    public void LoadImage(string path) //perform image loading
    {
        Texture2D tex = null;
        byte[] fileData;
        Sprite image = null;

        // if image file found, load it as sprite
        if (File.Exists(path))
        {
            fileData = File.ReadAllBytes(path);
            tex = new Texture2D(2, 2);
            tex.LoadImage(fileData); //..this will auto-resize the texture dimensions.

            image = Sprite.Create(tex, new Rect(0, 0, tex.width, tex.height),
                new Vector2(0.5f, 0.5f));
        }
        imageField.sprite = image;
    }

}
