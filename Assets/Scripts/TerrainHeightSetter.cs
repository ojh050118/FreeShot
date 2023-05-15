using UnityEngine;

public class TerrainHeightSetter : MonoBehaviour
{
    public Texture2D HeightMap;

    [ContextMenu("SetHeight")]
    public void SetHeight()
    {
        TerrainData terrainData = GetComponent<Terrain>().terrainData;

        int terrainWidth = terrainData.heightmapResolution;
        int terrainHeight = terrainData.heightmapResolution;

        float[,] heightValues = terrainData.GetHeights(0, 0, terrainWidth, terrainHeight);

        for (int terrainY = 0; terrainY < terrainHeight; terrainY++)
        {
            if (terrainY >= HeightMap.height)
                break;

            for (int terrainX = 0; terrainX < terrainWidth; terrainX++)
            {
                if (terrainX >= HeightMap.width)
                    break;

                Color heightColor = HeightMap.GetPixel(terrainY, terrainX);
                heightValues[terrainX, terrainY] = heightColor.r;
            }
        }

        terrainData.SetHeights(0, 0, heightValues);
    }
}