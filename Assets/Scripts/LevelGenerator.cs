using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject[] CubeLinePrefabs;
    public int MinCubeLines;
    public int MaxCubeLines;
    public float DistanceBetweenCubeLines;
    public Transform FinishLine;
    public Transform GroundRoot;
    public float ExtraGroundScale;

    private void Awake()
    {
        int cubeLinesCount = Random.Range(MinCubeLines, MaxCubeLines + 1);

        for (int i = 0; i < cubeLinesCount; i++)
        {
            int prefabIndex = Random.Range(0, CubeLinePrefabs.Length);
            GameObject cubeLine = Instantiate(CubeLinePrefabs[prefabIndex], transform);
            cubeLine.transform.localPosition = CalculateCubeLinePosition(i);
        }

        FinishLine.localPosition = CalculateCubeLinePosition(cubeLinesCount);

        GroundRoot.localScale = new Vector3(1, 1, cubeLinesCount * DistanceBetweenCubeLines + ExtraGroundScale);
    }

    private Vector3 CalculateCubeLinePosition(int cubeLineIndex)
    {
        return new Vector3(0, 0, DistanceBetweenCubeLines * cubeLineIndex);
    }
}
