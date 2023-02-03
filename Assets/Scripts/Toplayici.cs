using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toplayici : MonoBehaviour
{
    GameObject anaKup;
    public int yukseklik = 0;
    public float can = 1;
    
    void Start()
    {
        anaKup = GameObject.Find("Cube");
    }

    // Update is called once per frame
    void Update()
    {
        anaKup.transform.position = new Vector3(transform.position.x, yukseklik + 1, transform.position.z);
        this.transform.localPosition = new Vector3(0, -yukseklik, 0);
        if (can <= 0)
        {
            Time.timeScale = 0;
        }
        
    }
    public void yukseklikAzalt()
    {
        yukseklik--;
        
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "topla" && other.gameObject.GetComponent<ToplanabilirKüp>().GetToplandiMi() == false)
        {
            yukseklik += 1;
            
            other.gameObject.GetComponent<ToplanabilirKüp>().ToplandiYap();
            other.gameObject.GetComponent<ToplanabilirKüp>().IndexAyarla(yukseklik);
            other.gameObject.transform.parent = anaKup.transform;
        }
        if(other.gameObject.tag == "engel" && yukseklik ==0)
        {
            can--;
        }
        
    }
}
