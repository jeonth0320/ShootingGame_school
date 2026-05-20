using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class CutLineWall : MonoBehaviour
{ 

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
            return;

        if(other.gameObject.name.Contains("Bullet"))
        {
            GameObject monsterObj = GameObject.Find("MonsterManager");
            MonsterManger monsterManger = monsterObj.GetComponent<MonsterManger>();
            monsterManger.monsterObjectPool.Add(other.gameObject);
            
        }



        other.gameObject.SetActive(false); 
    }
}
