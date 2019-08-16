using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float jumpPower;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Jumpはスペースキーまたはジョイスティックのボタンに対応している
        if (Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, jumpPower, 0);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // シーンの移動を管理する。
        // Application.loadSceneは非推奨となりUnityEngine.SceneManagementもモジュールを利用することになった。
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
