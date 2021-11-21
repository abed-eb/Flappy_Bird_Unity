using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class GameHandler : MonoBehaviour
{

    public GameObject background;
    public GameObject land;
    [SerializeField] private float _pipe_movemenet_speed = 0.3f;

    public GameObject pipe_up;

    public GameObject pipe_down;
    public bool isDestoryed = false;
    // Start is called before the first frame update
    void Start()
    {
        background = GameObject.Find("BackGround");
        land = GameObject.Find("Land");
        pipe_up = GameObject.Find("pipe_up");
        pipe_down = GameObject.Find("pipe_down");

    }

    // Update is called once per frame
    void Update()
    {
        pipe_up.transform.position += new Vector3(-1, 0, 0) * _pipe_movemenet_speed;
        pipe_down.transform.position += new Vector3(-1, 0, 0) * _pipe_movemenet_speed;

        if (pipe_down.transform.position.x < -89 || pipe_up.transform.position.x < -89 )
        {
            // pipe_up.transform.localScale = new Vector3(transform.position.x, 50.2f, 0);
            pipe_down.transform.position = new Vector3(89,50.2f , 0);
            pipe_up.transform.position = new Vector3(89, -13.9f, 0);
        }
    }


}
