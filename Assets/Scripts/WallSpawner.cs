using UnityEngine;

public class WallSpawner : MonoBehaviour {

    public GameObject wall;
    public GameObject ball;

    private void Start() {
        InvokeRepeating("SpawnWall", 0.0f, 2.0f);
    }

    
    // Spawns walls based on randomized gap widths and positions
    private void SpawnWall()
    {
        float random = Random.value;
        float gapWidth = 7.5f * random;
        print("Gap Width: " + gapWidth);

        if (gapWidth < 4.0f)
        {
            gapWidth = 4.0f;
            print("Modified Gap Width: " + gapWidth);
        }

        random = Random.value;
        float gapPosition = (15.0f * random) - 7.5f;
        print("Gap Position: " + gapPosition);

        // Instantiate top wall
        float bottomY = gapPosition + (gapWidth / 2.0f); // Y-coord. of the bottom of the top wall 
        float scaleY = 10.0f - bottomY;
        float posY = 10.0f - (scaleY / 2.0f);

        wall.transform.localScale = new Vector2(1.0f, scaleY);
        Instantiate(wall, new Vector2(ball.transform.position.x + 29.0f, posY), Quaternion.identity);

        // Instantiate bottom wall
        float topY = gapPosition - (gapWidth / 2.0f); // Y-coord. of the top of the bottom wall 
        scaleY = 10.0f + topY;
        posY = (scaleY / 2.0f) - 10.0f;

        wall.transform.localScale = new Vector2(1.0f, scaleY);
        Instantiate(wall, new Vector2(ball.transform.position.x + 29.0f, posY), Quaternion.identity);
    }
}
