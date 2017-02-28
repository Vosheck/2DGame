using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldInitializer : MonoBehaviour {

    Tile[,] tiles;

    public Sprite GroundSprite;

    int worldWidth=50;
    int worldHeight = 50;

    void OnEnable()
    {
        CreateWorld();

    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void CreateWorld()
    {
        tiles = new Tile[worldWidth, worldHeight];

        for (int x = 0; x < worldWidth; x++)
        {
            for (int y = 0; y < worldHeight; y++)
            {
                tiles[x, y] = new Tile(x, y);

                GameObject tile_gameObject = new GameObject();
                Tile tile_data = GetTileAt(x, y);
                tile_gameObject.transform.position = new Vector3(tile_data.X,tile_data.Y);
                tile_gameObject.transform.SetParent(this.transform);

                tile_gameObject.name = "Tile_" + x + "_" + y;

                SpriteRenderer tile_spriteRenderer= tile_gameObject.AddComponent<SpriteRenderer>();
                tile_spriteRenderer.sprite = GroundSprite;
            }
        }
    }

    public Tile GetTileAt(int x, int y)
    {
        if (x>worldWidth || x<0 || y >worldHeight || y<0)
        {
            Debug.LogError("Tile_" + x + "_" + y + " is out of bounds.");
        }
        return tiles[ x, y];
    }

}
