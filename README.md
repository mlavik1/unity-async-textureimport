# Unity Async Texture Importer

This is a faster alternative to Texture2D.LoadImate, which can only be used on the main thread - and which will block the thread until it's done.

# How to use
See TextureImporter.cs:
Create a coroutine, and from there do this:
TextureImporter importer = new TextureImporter();
yield return importer.ImportTexture(texPath, FREE_IMAGE_FORMAT.FIF_JPEG);
Texture2D tex = importer.texture;
