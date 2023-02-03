using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float ileriGitmeHizi;
    [SerializeField] private float speed;
    [SerializeField] private float limitZ;

    void Start()
    {
        
    }

    
    void Update()
    {
       
        float yatayEksen = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        var position = transform.position;
        position.z += yatayEksen;
        position.z = Mathf.Clamp(position.z, -limitZ, limitZ);
        transform.position = position;
        this.transform.Translate(yatayEksen, 0, ileriGitmeHizi * Time.deltaTime);
        
    }
}
