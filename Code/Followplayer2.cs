using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Followplayer2 : MonoBehaviour
{
    public GameObject player;
    public Vector3 Offset = new Vector3(0, 2.1f, 0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + Offset;
    }
}
