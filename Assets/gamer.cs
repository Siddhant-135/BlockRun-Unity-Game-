using UnityEngine;

public class infiniteGameplay : MonoBehaviour
{
    public Transform player;
    public Transform ground;
    public GameObject obstacle;

    private float obstHalfWidth = 5f;
    private float Xspacing = 30f;
    private float startX;
    private int lastSegment = 0;
    int[] lanes = {-3, -1, 1, 3};

    void Start()
    {
        startX = player.position.x;

        for (int i = 3; i <= 5; i++)
        {
            SpawnObstaclesAt(startX + i * Xspacing);
        }
    }

    void Update()
    {
        float distance = player.position.x - startX;
        int segment = Mathf.FloorToInt(distance / Xspacing);

        while (segment > lastSegment)
        {
            lastSegment++;
            SpawnStuff(lastSegment);
        }
    }

    void SpawnStuff(int segment)
    {
        SpawnObstaclesAt(startX + segment * Xspacing + Xspacing * 6);
        ground.position += new Vector3(Xspacing, 0, 0);
    }

    void SpawnObstaclesAt(float spawnX)
    {
        int lane = Random.Range(0, lanes.Length);
        int lane2 = Random.Range(0, lanes.Length);
        while (lane == lane2)
        {
            lane2 = Random.Range(0, lanes.Length);
        }
        Vector3 pos = new Vector3(spawnX, 2, lanes[lane] * obstHalfWidth);
        Vector3 pos2 = new Vector3(spawnX, 2, lanes[lane2] * obstHalfWidth);
        Instantiate(obstacle, pos, Quaternion.identity);
        Instantiate(obstacle, pos2, Quaternion.identity);
    }
}
