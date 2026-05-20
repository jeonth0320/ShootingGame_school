using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class CharctorFire : MonoBehaviour
{
    public GameObject bulletObject; //prefabs
    public GameObject bulletFireObject;
    public soundManager sm;

    //오브젝트 풀 크기
    public int bulletPoolSize = 10;
    //오브젝트 풀장 : 배열 
    public List<GameObject> bulletFireObjectPool;

    public IObjectPool<BulletControl> pools;

    private void Awake()
    {
        pools = new ObjectPool<BulletControl>(
                                                SetBullet,
                                                OnGetBullet,
                                                OnRemoveBullet,
                                                OnDestoryBullet,
                                                maxSize: bulletPoolSize
                                                );
    }

    



    private BulletControl SetBullet()
    {
        BulletControl bullet = Instantiate(bulletObject).GetComponent<BulletControl>();
        bullet.setPoolManagerBullet(pools);
        return bullet;
    }

    private void OnGetBullet(BulletControl bullet)
    {
        bullet.gameObject.SetActive(true);
    }

    private void OnRemoveBullet(BulletControl bullet)
    {
        bullet.gameObject.SetActive(false);
    }

    private void OnDestoryBullet(BulletControl bullet)
    {
        Destroy(bullet.gameObject);
    }
   

    void Update()
    { 
        bool isFire = Input.GetButtonDown("Jump");
        if(isFire)
        {
            BulletControl bullet = pools.Get();
            bullet.transform.position = transform.position;
             
        }
    }
}
