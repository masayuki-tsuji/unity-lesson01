using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // 壁のオブジェクト
    public GameObject wallPrefab;

    // 壁を生成する間隔
    public float interval;

    // Y座標のランダム範囲
    private float range = 3.0f;
    
    // コルーチンを実装
    // 複数のフレームを跨る処理を行う時はIEnumeratorへ返す
    // 
    IEnumerator Start()
    {
        while (true)
        {
            // Y座標を範囲内(-3.0f 〜 3.0f)でランダムに設定する。
            transform.position = new Vector3(transform.position.x, Random.Range(-range, range), transform.position.z);

            // 壁のインスタンスを生成する。
            // 座標や角度などは親オブジェクトに依存する。
            Instantiate(wallPrefab, transform.position, transform.rotation);

            // 間隔を空ける。
            yield return new WaitForSeconds(interval);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
