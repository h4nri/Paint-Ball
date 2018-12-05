using UnityEngine;

public class GameManager : MonoBehaviour {

    public Rigidbody2D wall;

    private void Start() {
        InvokeRepeating("SpawnObstacle", 0.0f, 2.0f);
    }

    // Does not currently spawn walls as intended (with correct scaling and at correct positions) 
    private void SpawnObstacle()
    {
        float random = Random.value;
        float gap = 5.0f * random;
        print("Gap: " + gap);

        random = Random.value;
        float position = 17.5f * random;

        if (position <= 10.0f)
        {
            position = -position;
        }
        print("Position: " + position);

        // Instantiate top wall
        float bottomLoc = position + gap / 2;
        float yScale;

        if (bottomLoc < 0) {
            yScale = 10.0f + (bottomLoc * -1.0f);
        } else
        {
            yScale = 10.0f - bottomLoc;
        }

        wall.transform.localScale = new Vector2(1.0f, yScale);

        Instantiate(wall, new Vector2(29.0f, yScale/2), Quaternion.identity);
        
        // Instantiate bottom wall
        float topLoc = position + gap / 2;

        if (topLoc < 0)
        {
            yScale = 10.0f + (topLoc * -1.0f);
        }
        else
        {
            yScale = 10.0f - topLoc;
        }

        wall.transform.localScale = new Vector2(1.0f, yScale);

        Instantiate(wall, new Vector2(29.0f, yScale / 2), Quaternion.identity);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Wall"))
        {
            Destroy(collision.gameObject);
        } else
        {
            throw new System.Exception("Unexpected GameObject entered GameManager's Collider 2D.");
        }
    }
}
