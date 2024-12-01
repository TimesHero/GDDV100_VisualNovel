using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class Cutins : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject viviBg; 
    public GameObject vivi; 
    public bool viviCutin;
    void Start()
    {

    }

    // Update is called once per frame
    public void ViviTrigger(){
        viviCutin=true;
    }
    void Update()
    {
        if (viviCutin==true){
        viviBg.transform.Translate(Vector3.left * 50 * Time.deltaTime);
        if (viviBg.transform.position.x < -100) {
                viviCutin=false;
            }
        }
    }
}
