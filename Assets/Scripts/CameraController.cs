using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // public GameObject player;
    

    // void Update()
    // {
    //     // transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10f);
    //     Vector3 dir = transform.right * Input.GetAxis("Horizontal");
    //     transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speed * Time.deltaTime);
    // }
    public GameObject player; // тут объект игрока
    private Vector3 offset; 
    void Start () 
    {        
        offset = transform.position - player.transform.position;
    }

    void LateUpdate () 
    {        
        transform.position = player.transform.position + offset;
    }
}
