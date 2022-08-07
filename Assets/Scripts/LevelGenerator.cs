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
    public float ExtraGroundScale;
    public Game Game;

    public GameObject[] FoodLinePrefabs;
    public int MinFoodLines;
    public int MaxFoodLines;
    public float DistanceBetweenFoodLines;

    public GameObject[] WallsLinePrefabs;
    public int MinWallsLines;
    public int MaxWallsLines;
    public float DistanceBetweenWallsLines;

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

        GroundRoot.localScale = new Vector3(1, 1, cubeLinesCount * DistanceBetweenCubeLines + ExtraGroundScale);

        int foodLinesCount = RandomRange(random, MinFoodLines, MaxFoodLines + 1);

        for (int j = 0; j < foodLinesCount; j++)
        {
            int foodPrefabIndex = RandomRange(random, 0, FoodLinePrefabs.Length);
            GameObject foodLine = Instantiate(FoodLinePrefabs[foodPrefabIndex], transform);
            foodLine.transform.localPosition = CalculateFoodLinePosition(j);
        }

        int wallsLinesCount = RandomRange(random, MinWallsLines, MaxWallsLines + 1);

        for (int k = 0; k < wallsLinesCount; k++)
        {
            int wallsPrefabIndex = RandomRange(random, 0, WallsLinePrefabs.Length);
            GameObject wallsLine = Instantiate(WallsLinePrefabs[wallsPrefabIndex], transform);
            wallsLine.transform.localPosition = CalculateWallsLinePosition(k);
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

    private Vector3 CalculateWallsLinePosition(int wallsLineIndex)
    {
        return new Vector3(0, 0, DistanceBetweenFoodLines * wallsLineIndex);
    }
}
