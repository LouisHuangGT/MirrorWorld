using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {
    public GameObject Door;
    bool picked = false;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && picked == false)
        {
            picked = true;
            Debug.Log("HERE");
            Door.GetComponent<Door>().keyNumber+=1;
            Destroy(this.transform.parent.gameObject);
        }
    }
}
