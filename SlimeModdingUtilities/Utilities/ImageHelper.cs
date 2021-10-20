using System.IO;
using System.Linq;
using System.Reflection;
using UnityEngine;

namespace SMU.Utilities
{
    static class ImageHelper
    {
        public static Texture2D LoadTextureRaw(byte[] bytes)
        {
            if (bytes.Count() > 0)
            {
                Texture2D Tex2D = new Texture2D(2, 2);
                if (Tex2D.LoadImage(bytes))
                    return Tex2D;
            }
            return null;
        }

        public static Texture2D LoadTextureFromFile(string path)
        {
            if (File.Exists(path)) return LoadTextureRaw(File.ReadAllBytes(path));

            return null;
        }

        public static Texture2D LoadTextureFromResources(string resourcePath)
        {
            return LoadTextureRaw(GetResource(Assembly.GetCallingAssembly(), resourcePath));
        }

        public static Sprite LoadSpriteRaw(byte[] image, float pixelsPerUnit = 100.0f)
        {
            return LoadSpriteFromTexture(LoadTextureRaw(image), pixelsPerUnit);
        }

        public static Sprite LoadSpriteFromTexture(Texture2D texture, float pixelsPerUnit = 100.0f)
        {
            if (texture) return Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0, 0), pixelsPerUnit);
            return null;
        }

        public static Sprite LoadSpriteFromFile(string path, float pixelsPerUnit = 100.0f)
        {
            return LoadSpriteFromTexture(LoadTextureFromFile(path), pixelsPerUnit);
        }

        public static Sprite LoadSpriteFromResources(string resourcePath, float pixelsPerUnit = 100.0f)
        {
            return LoadSpriteRaw(GetResource(Assembly.GetCallingAssembly(), resourcePath), pixelsPerUnit);
        }

        public static byte[] GetResource(Assembly asm, string resourcePath)
        {
            Stream stream = asm.GetManifestResourceStream(resourcePath);
            byte[] data = new byte[stream.Length];
            stream.Read(data, 0, (int)stream.Length);
            return data;
        }
    }
}
