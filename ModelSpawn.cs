using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using Debug = UnityEngine.Debug;


public class ModelSpawn : MonoBehaviour
{
    public List<GameObject> modelList = new List<GameObject>();
    public GameObject PikachuSpawn;
    public GameObject GameCubeSpawn;
    public GameObject PikachuPrefab;
    public TMP_InputField InputField;

    public TMP_Dropdown Dropdown;
    
    public void OntrackedImagesChanged(ARTrackablesChangedEventArgs<ARTrackedImage> obj)
    {
        //Ajouter un modele 3D sur une image détécté, on check la liste des images qui sont tracké
        foreach (var trackedImage in obj.added)
        {

            if (trackedImage.name.Contains("Pikachu"))
            {
                Instantiate(modelList[0],PikachuSpawn.transform.position, PikachuSpawn.transform.rotation); // on instancie le modele a la position du spawn et avec la rotation du spawn
                
                Instantiate(PikachuPrefab, PikachuSpawn.transform.position, PikachuSpawn.transform.rotation);
            }

        }
    }

    public void OnButtonClicked()
    {
        Debug.Log("J'ai cliqué !!");
            
    }
}
