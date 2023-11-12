using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehaviour
{
    //�������� NPC
    public int health = 50;
    //������� NPC
    public int level = 25;
    //�������� NPC
    public float speed = 10.5f;

    // Start is called before the first frame update
    void Start()
    {
        health = health + level;
        //����� ��������
        print("�����:" + health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
