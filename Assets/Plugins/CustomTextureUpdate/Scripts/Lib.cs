using System;
using System.Runtime.InteropServices;

namespace CustomTextureUpdate
{

public static class Lib
{
    const string dllName = "CustomTextureUpdate";

    [DllImport(dllName)]
    public static extern uint CreateLoader();

    [DllImport(dllName)]
    public static extern void DestroyLoader(uint id);

    [DllImport(dllName)]
    public static extern void Load(uint id, IntPtr data, int size);

    [DllImport(dllName)]
    public static extern void LoadRaw(uint id, IntPtr data, int size, int width, int height);

        [DllImport(dllName)]
    public static extern int GetWidth(uint id);

    [DllImport(dllName)]
    public static extern int GetHeight(uint id);

    [DllImport(dllName)]
    public static extern int GetColorType(uint id);

    [DllImport(dllName)]
    public static extern bool HasLoaded(uint id);

    [DllImport(dllName)]
    public static extern IntPtr GetTextureUpdateCallback();
}

}