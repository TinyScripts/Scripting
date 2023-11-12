using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehaviour
{
    //Здоровье NPC
    public int health = 50;
    //Уровень NPC
    public int level = 25;
    //Скорость NPC
    public float speed = 10.5f;

    // Start is called before the first frame update
    void Start()
    {
        health = health + level;
        //Пишет здоровье
        print("Жизни:" + health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
