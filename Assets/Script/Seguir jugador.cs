using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seguirjugador : MonoBehaviour


{

    public GameObject judaor;
       public float sensibilidadRotacion = 200f; // Sensibilidad para controlar la velocidad de rotación
    private float rotacionX = 0f;
    private float rotacionY = 0f;
    // Start is called before the first frame update
    void Start()
    {
         Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()

    {
        float mouseX = Input.GetAxis("Mouse X") * sensibilidadRotacion * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensibilidadRotacion * Time.deltaTime;

        
        rotacionX += mouseX;
        
        rotacionY -= mouseY;
        rotacionY = Mathf.Clamp(rotacionY, -90f, 90f); 

       
        transform.rotation = Quaternion.Euler(rotacionY, rotacionX, 0f);
        transform.position = judaor.transform.position + new Vector3(-102,144,-202);
    }
}
