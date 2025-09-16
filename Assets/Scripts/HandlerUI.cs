using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
using TMPro;

public class HandlerUI : MonoBehaviour
{
    [SerializeField]

    GameObject objetoPanel;
    [SerializeField]

    GameObject objetoPanel2;
    [SerializeField]

    GameObject objetoPanel3;
  

   
   void Start()
    {
 
        objetoPanel.SetActive(false);
        objetoPanel2.SetActive(false);
        objetoPanel3.SetActive(false);
        
    }
    
    
    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex==0 && objetoPanel.activeSelf){
            Debug.Log("Update activo: en escena 0 y el panel está visible");
    
        }
    }
    
    public void activaPanel(bool isVisible){
        objetoPanel.SetActive(isVisible);
        objetoPanel2.SetActive(isVisible);
        objetoPanel3.SetActive(isVisible);
       
   

    }
}