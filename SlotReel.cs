using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotReel : MonoBehaviour {

    [SerializeField]
    private int speed = 3;
    private Transform[] Slots;
    private Transform currentSlot;

	void Start () {
        Slots = new Transform[transform.childCount];
        for (int i = 0; i < this.transform.childCount; i++)
        {
            Slots[i] = transform.GetChild(i);
        }
    }
	
	void Update () {
        foreach(Transform C in Slots)
        {
            // check welk embleem op het midden staat
            C.transform.Translate(Vector2.down * speed * Time.deltaTime);
            if (C.position.y < this.transform.position.y)
            {
                currentSlot = C.transform;
                print(currentSlot.name);
            }
            if(C.position.y < this.transform.position.y -100) //verplaats naar top
            {
                C.transform.position = new Vector2(transform.position.x, transform.position.y + 175);
            }
        }
	}
}
