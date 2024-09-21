using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DestruirBS : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text_c;
     public int count;
    // Start is called before the first frame update
    void Start()
    {
         count =0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter (Collision other){
        if(other.gameObject.CompareTag("boosty")){
            GameObject obj = other.gameObject;
            Destroy(obj,0);
            count++;
            text_c.text = count.ToString();
        }
    }
}
