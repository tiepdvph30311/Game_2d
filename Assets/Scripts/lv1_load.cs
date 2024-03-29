using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lv1_load : MonoBehaviour
{
    // Start is called before the first frame update
   public string screname;

    public void Clickgamelv1()
    {
        SceneManager.LoadScene("man1");
    }
}
