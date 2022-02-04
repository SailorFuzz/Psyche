using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MyBox;

public class RingTrigger : MonoBehaviour
{
    [ReadOnly]
    public RadioCollision manager;    
    [ReadOnly]
    public  int ringID = 0;
    [ReadOnly]
    public bool inRing;

    public void Start()
    {
        manager = this.transform.parent.gameObject.GetComponent<RadioCollision>();
        inRing = false;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            manager.CurrentRing(ringID);
            inRing = true;
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            manager.CurrentRing(ringID - 1);
            inRing = false;
        }
    }

}
