﻿using System.IO;
using UnityEngine;
using UnityEditor;
using System;

public class OpenFilePanelExample : EditorWindow
{
    [MenuItem("Example/Overwrite Texture")]
    private static void Apply()
    {
        Texture2D texture = Selection.activeObject as Texture2D;
        if (texture == null)
        {
            EditorUtility.DisplayDialog("Select Texture", "You must select a texture first!", "OK");
            return;
        }

        string path = EditorUtility.OpenFilePanel("Overwrite with png", "", "png");
        if (path.Length != 0)
        {
            var fileContent = File.ReadAllBytes(path);
            texture.LoadImage(fileContent);
        }
    }

    [MenuItem("Example/Foo")]
    private static void Foo()
    {
        EditorUtility.DisplayDialog("Output","Pizza","OK");
    }
}
