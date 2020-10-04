using System.Collections;
using UnityEngine;
using System.IO;
using System;
using System.Runtime.InteropServices;
using AsyncTextureImport;
using System.Threading.Tasks;

public class TextureLoadTest : MonoBehaviour
{
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            StartCoroutine(ImportTexture(Path.Combine(Application.streamingAssetsPath, "ghibli.jpg")));
        }
    }

    private IEnumerator ImportTexture(string texPath)
    {
        TextureImporter importer = new TextureImporter();
        yield return importer.ImportTexture(texPath, FREE_IMAGE_FORMAT.FIF_JPEG);

        Texture2D tex = importer.texture;

        Sprite sprite = Sprite.Create(tex, new Rect(0.0f, 0.0f, tex.width, tex.height), Vector2.zero, 100.0f, 0, SpriteMeshType.FullRect);

        GameObject obj = new GameObject();
        SpriteRenderer sr = obj.AddComponent<SpriteRenderer>();
        sr.sprite = sprite;

        yield return null;
    }
}
