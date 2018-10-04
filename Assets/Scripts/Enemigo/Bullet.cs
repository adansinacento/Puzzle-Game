using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Bullet : MonoBehaviour {

    


    private void OnCollisionEnter(Collision _col)
    {
        if(_col.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("Level_1");
        }
    }
}
