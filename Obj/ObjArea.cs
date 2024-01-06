using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjArea : MonoBehaviour {  

    public GameObject go;

    public string name;
    public Dictionary <string, List<string>> options;

    public int id;
    public RectTransform rect;
    public List<int> connections;

    public Dictionary <string, string> relation;

    void Start (){
        relation = new Dictionary <string, string> ();
    }

    
}