using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class LevelGenerator : MonoBehaviour
{
    public GameObject[] CubeLinePrefabs;
    public int MinCubeLines;
    public int MaxCubeLines;
    public float DistanceBetweenCubeLines;
    public Transform FinishLine;
    public Transform GroundRoot;
    //public float ExtraGroundScale;
    public Game Game;

    public GameObject[] FoodLinePrefabs;
    public int MinFoodLines;
    public int MaxFoodLines;
    public float DistanceBetweenFoodLines;

    private void Awake()
    {
        int levelIndex = Game.LevelIndex;
        Random random = new Random(levelIndex);
        int cubeLinesCount = RandomRange(random, MinCubeLines, MaxCubeLines + 1);

        for (int i = 0; i < cubeLinesCount; i++)
        {
            int prefabIndex = RandomRange(random, 0, CubeLinePrefabs.Length);
            GameObject cubeLine = Instantiate(CubeLinePrefabs[prefabIndex], transform);
            cubeLine.transform.localPosition = CalculateCubeLinePosition(i);
        }

        FinishLine.localPosition = CalculateCubeLinePosition(cubeLinesCount);

        //GroundRoot.localScale = new Vector3(1, 1, cubeLinesCount * DistanceBetweenCubeLines + ExtraGroundScale);

        int foodLinesCount = RandomRange(random, MinFoodLines, MaxFoodLines + 1);

        for (int j = 0; j < foodLinesCount; j++)
        {
            int foodPrefabIndex = RandomRange(random, 0, FoodLinePrefabs.Length);
            GameObject foodLine = Instantiate(FoodLinePrefabs[foodPrefabIndex], transform);
            foodLine.transform.localPosition = CalculateFoodLinePosition(j);
        }
    }

    private int RandomRange(Random random, int min, int maxExclusive)
    {
        int number = random.Next();
        int length = maxExclusive - min;
        number %= length;
        return min + number;
    }

    private Vector3 CalculateCubeLinePosition(int cubeLineIndex)
    {
        return new Vector3(0, 0, DistanceBetweenCubeLines * cubeLineIndex);
    }

    private Vector3 CalculateFoodLinePosition(int foodLineIndex)
    {
        return new Vector3(0, 0, DistanceBetweenFoodLines * foodLineIndex);
    }
}
