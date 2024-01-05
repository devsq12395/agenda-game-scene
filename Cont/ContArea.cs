using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContArea : MonoBehaviour {

    public static ContArea I;
	public void Awake(){ I = this; }

    public Material road; // Set in Editor

    public void setup (){
        
    }

    public void connect (ObjArea _a1, ObjArea _a2){
        float _width = 0.1f;

        Vector2 _pos1 = _a1.go.transform.position,
                _pos2 = _a2.go.transform.position;

        _a1.connections.Add (_a2.id);
        _a2.connections.Add (_a1.id);

        // Roads
        LineRenderer _lineRend = _a1.go.AddComponent<LineRenderer>();
        _lineRend.material = road;
        _lineRend.startWidth = _width;
        _lineRend.endWidth = _width;
        Vector3[] _linePos = new Vector3[] {
            new Vector3 (_pos1.x, _pos1.y, -1),
            new Vector3 (_pos2.x, _pos2.y, -1)
        };
        _lineRend.positionCount = _linePos.Length;
        _lineRend.SetPositions(_linePos);
    }
}