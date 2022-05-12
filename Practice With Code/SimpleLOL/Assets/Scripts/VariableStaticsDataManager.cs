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
    public Dictionary<string, List<object>> variable_statics_dictionary { get; private set; }

    private void Start()
    {
        variable_statics_dictionary = new Dictionary<string, List<object>>();
        if (InputData() == 1)
        {          

        }
    }
    
    private int InputData()
    {
        string path = Application.dataPath + "/Datas/gameobject_datas.json";               
        JArray json_datas = JArray.Parse(File.ReadAllText(path));
        List<object> tmp = new List<object>();

        if (File.Exists(path) == true)
        {
            int cnt = 0;
            string dictionary_key = "";
            foreach(JObject champion_jungle_minion in json_datas)
            {
                tmp.Clear();
                cnt = 0;
                dictionary_key = "";
                foreach(var j in champion_jungle_minion) //JObject에 대해서 값을 어떻게 하면 종속성 없이 저장할까. //json의 순서도 변할 수 있지 않을까.
                {
                    if(cnt != 0)
                    {
                        tmp.Add(j.Value);
                    }
                    else
                    {
                        dictionary_key = (string)j.Value;
                    }
                    cnt++;                    
                }
                variable_statics_dictionary[dictionary_key] = tmp;
            }
            foreach(var i in variable_statics_dictionary)
            {
                //Debug.Log(i.Key);
                //foreach(var j in i.Value)
                //{
                //    Debug.Log(j);
                //}
            }

            return 1;
        }
        else
        {
            return 0;
        }
    }

}
