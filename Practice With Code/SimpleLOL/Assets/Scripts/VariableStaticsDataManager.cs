using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class VariableStaticsDataManager : MonoBehaviour
{
    
    //롤에는 무수히 많은 챔피언이 있지만 여기는 별로 없다고 가정한다.
    //데이터를 Json으로 저장하고, 여기서 읽어온다고 가정하자. 
    //메모리에 챔피언의 정보를 저장한다.
    Dictionary<string, List<int>> variable_statics_dictionary;

    private void Start()
    {
        variable_statics_dictionary = new Dictionary<string, List<int>>();
        if (InputData() == 1)
        {
            

        }
    }
    
    private int InputData()
    {
        string path = Application.dataPath + "/Datas/object_datas.json";
        JObject o1 = JObject.Parse(File.ReadAllText(path));
        
        if (File.Exists(path) == true)
        {
            
            return 1;
        }
        else
        {
            return 0;
        }
    }

}
