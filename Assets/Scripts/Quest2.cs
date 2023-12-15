using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest2 : MonoBehaviour
{
   
    public int questNumber = 0;
    public int[] items;
    public GameObject[] clouds;
    
    public Transform player;

    public Rigidbody2D rb;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        rb = GetComponent<Rigidbody2D>();
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<PickUp>() == null)
        Debug.Log(other.gameObject.tag);
        if (!other.CompareTag("qcloud") && questNumber < items.Length )
        {
            Debug.Log(questNumber);
            if (!other.CompareTag("Player") && other.gameObject.GetComponent<PickUp>().id == items[questNumber])
            {
                questNumber++;
                Destroy(other.gameObject);
                CheckQuest();
        
            }
        }
    }

    public void CheckQuest()
    {
        // for(int i = 0; i < clouds.Length; i++)
        // {
        //     if(i == questNumber)
        //     {
        //         clouds[i].SetActive(true);
        //         clouds[i].GetComponent<Animator>().SetTrigger("isTriggered");
        //         break;
        //     }

        //     else
        //     {
        //         clouds[i].SetActive(false);
        //     }
        // }

        if (questNumber == 3)
        {
            // barrier.SetActive(false);
            // key.SetActive(true);
            transform.position = new Vector3(transform.position.x + 425, transform.position.y + 0, transform.position.z + 0);
            player.transform.position = new Vector3(player.position.x + 420, player.position.y + 0, player.position.z + 0);
            rb.constraints = RigidbodyConstraints2D.None;
            rb.bodyType = RigidbodyType2D.Dynamic;
            
        }
    }

}
