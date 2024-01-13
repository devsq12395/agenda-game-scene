using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DB_Tasks : MonoBehaviour {

    public static DB_Tasks I;
	public void Awake(){ I = this; }

    public struct TaskData {
        public string name, nameUI, desc;
        public int turns;

        public TaskData (){
            name = "";
            nameUI = "";
            desc = "";
            turns = 1;
        }
    }

    public TaskData get_task_data (string _name){
        TaskData _ret = new TaskData ();

        switch (_name) {
            case "test":
                nameUI = "Test";
                desc = "testing";
                turns = 1;
                break;
        }

        return _ret;
    }

    public void on_task_done (ObjChar _c){
        ObjArea _area = ContArea.I.get_area_from_id (_c.tsk_curAreaID);

        switch (_c.task) {
            case "test":
                
                break;
        }
    }
}
