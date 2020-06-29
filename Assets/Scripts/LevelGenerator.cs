using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class LevelGenerator : MonoBehaviour
{
    // Start is called before the first frame update

    public int LevelWidth = 15;
    public int LevelHeight = 15;
    public GameObject Player;
    public GameObject Wall;
    public NavMeshSurface surface;

    private bool _isPlayerSpawned = false;

    void Start()
    {
        //TODO: reference ground via GETComponent<>
        //TODO: Grab size of level, and pass in sizes to width/Height
        GenerateNewLevel();
        BakeNavMesh();
    }

    private void BakeNavMesh()
    {
        surface.BuildNavMesh();
    }

    private void GenerateWalls(int x, int z)
    {
        Vector3 position = new Vector3(x - LevelWidth / 2f, 1f, z - LevelHeight / 2f);
        Instantiate(Wall, position, Quaternion.identity, transform);
    }

    private void PlacePlayer(int x, int z)
    {
        Vector3 position = new Vector3(x - LevelWidth / 2f, 1.25f, z - LevelHeight / 2f);
        Instantiate(Player, position, Quaternion.identity);
        _isPlayerSpawned = true;
    }

    private void GenerateNewLevel()
    {
        //Loop through the grid of the board, double for loop
        for(int x = 0; x <= LevelWidth; x += 2)
        {
            for(int z = 0; z <= LevelHeight; z += 2)
            {
                if(Random.value > .7f)
                {
                    GenerateWalls(x, z);
                }
                else if(!_isPlayerSpawned)
                {
                    PlacePlayer(x, z);
                }
            }
        }
        

    }
}
