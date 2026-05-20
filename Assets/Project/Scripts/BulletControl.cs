using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;


public class BulletControl : MonoBehaviour
{
    //풀링에 대상 bulletControl
    //풀링 관리자 ~ poolManagerBullet;
    private IObjectPool<BulletControl> poolManagerBullet;

    //풀관리자에 풀 대상을 넣기
    public void setPoolManagerBullet(IObjectPool<BulletControl> pools) 
    {
        poolManagerBullet = pools;
    }

    //풀 대상을 삭제 
    public void bulletDestory()
    { 
        poolManagerBullet.Release(this);
    } 

    void Update()
    {
        transform.Translate(Vector3.up * 3 * Time.deltaTime);

        //시간이 지나면 함수명을 호출
        // Invoke("함수명", 시간);
        Invoke("bulletDestory", 5f);
    }
     
    private void OnDisable()
    {
        CancelInvoke();
    }


}
