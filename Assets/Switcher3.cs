using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switcher3 : MonoBehaviour
{
    MeshRenderer CurrMaterial;
    [SerializeField] Material newMaterial;
    [SerializeField] GameObject Lighters;
    Material OldMaterial;


    void Start()
    {
        CurrMaterial = GameObject.FindWithTag("Screen").GetComponent<MeshRenderer>();
        OldMaterial = CurrMaterial.material;
        Lighters.SetActive(false);
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            CurrMaterial.material = newMaterial;
            Lighters.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other) {
     if (other.CompareTag("Player")) {
         CurrMaterial.material = OldMaterial; 
         Lighters.SetActive(false);

     }   
    }
}
