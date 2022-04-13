using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileEdge : MonoBehaviour
{
   public Mesh[] tileEdgeMeshs; 
  public void ReplaceMesh()
    {
        if (tileEdgeMeshs.Length < 2) return;
        Mesh currentMesh = tileEdgeMeshs[Random.Range(0, tileEdgeMeshs.Length)];
        GetComponent<MeshFilter>().mesh = currentMesh;
        Debug.Log("Replaced");
    }
    public void RandomAllTile()
    {
        TileEdge[] allTileEdge = FindObjectsOfType<TileEdge>();
        foreach (TileEdge tile in allTileEdge)
            tile.ReplaceMesh();
        Debug.Log("Replaced all tile");
    }
}
