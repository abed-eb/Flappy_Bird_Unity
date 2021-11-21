using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public GameObject pipe_up;
    public GameObject pipe_down;
    [SerializeField] private float _pipe_movemenet_speed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Bird"))
        {
            Debug.Log("inside");
            Time.timeScale = 0;
        }
    }
}
