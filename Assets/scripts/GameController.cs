using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
   

    public void restart()
    {
        SceneManager.LoadScene("test");
        Pathmaker.tilesnum = 0;
    }

    void Update()
    {
       /*Vector3 sum = Vector3.zero;
       
       foreach(Transform trans in tiles)
       {
            sum += trans.transform.position;
       }

        Vector3 pos = sum / tiles.Count;

        //this.transform.position = new Vector3(pos.x, this.transform.position.y, pos.z);
        */
       
    }
}
