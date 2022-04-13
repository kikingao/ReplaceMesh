using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor( typeof(TileEdge))]
public class RandomCiffEdgeEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        TileEdge tileEdge = (TileEdge)target;

        if (GUILayout.Button("Random replace"))

            tileEdge.ReplaceMesh();

        if (GUILayout.Button("Random replace all tile"))

            tileEdge.RandomAllTile();
    }
}
