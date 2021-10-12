using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController : MonoBehaviour
{
    [SerializeField]
    public GameObject[] boxPrefabs;
    public GameObject[] box;





    private void Start()
    {
        SpawnBox();
    }

    private void SpawnBox()
    {
        bool isBoxSpawned = false;
        int totalBox = Random.Range(0, 5);

        while (!isBoxSpawned)
        {
            Vector3 BoxPosition = new Vector3(Random.Range(-4f, 4f), Random.Range(-3.5f, 3.5f), 0);
            box = new GameObject[boxPrefabs.Length];
            if ((BoxPosition - transform.position).magnitude < 3)
            {
                continue;
            }
            else
            {
                for (int i = 1; totalBox < boxPrefabs.Length; totalBox += i)
                {
                    Vector3 _boxPosition = new Vector3(Random.Range(-3.5f, 3.5f), Random.Range(-3.0f, 3.0f), 0);
                    box[totalBox] = Instantiate(boxPrefabs[totalBox], _boxPosition, Quaternion.identity) as GameObject;

                }
                isBoxSpawned = true;
            }
        }
    }
}
