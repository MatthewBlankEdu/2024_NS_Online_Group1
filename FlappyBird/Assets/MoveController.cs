using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    public float Speed;

    public float DespawnPointX;
    public float SpawnPointX;

    public float MinY;
    public float MaxY;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(transform.position.x, Random.Range(MinY, MaxY), transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x + Speed * Time.deltaTime, transform.position.y, transform.position.z);

        if(transform.position.x < DespawnPointX)
        {
            transform.position = new Vector3(SpawnPointX, Random.Range(MinY, MaxY), transform.position.z);
        }
    }
}
