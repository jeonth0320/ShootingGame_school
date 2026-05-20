using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public Vector3 direct = Vector3.down;
    public float spd = 5.0f;

    public GameObject prefabsExplosion;

    private void OnCollisionEnter(Collision collision)
    { 
        ScoreManager.Instance.NowScore++;
          
        GameObject explosion = Instantiate(prefabsExplosion);
        explosion.transform.position = transform.position;
         
        collision.gameObject.SetActive(false);

        MonsterDropper dropper = GetComponent<MonsterDropper>();
        dropper.Drop();


        gameObject.SetActive(false);
        GameObject monsterObj = GameObject.Find("MonsterManager");
        MonsterManger monsterManger = monsterObj.GetComponent<MonsterManger>();
        monsterManger.monsterObjectPool.Add(gameObject);
     
    }


    private void Update()
    { 
        transform.position += direct * spd * Time.deltaTime;
    }

}
