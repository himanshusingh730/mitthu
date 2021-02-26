using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class structureButton : MonoBehaviour
{
    public Rigidbody parrot;
    public Rigidbody  prefab;
    public GameObject panell;
    // Start is called before the first frame update
    public void onClick()
    {
        Instantiate(prefab, parrot.transform.position+ new Vector3(5,0,5), Quaternion.identity);
        panell.SetActive(false);
        //Debug.Log("clicked");
    }
    public void panelshow()
    {
        panell.SetActive(true);
    }
    public void Endgame()
    {
        //UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
