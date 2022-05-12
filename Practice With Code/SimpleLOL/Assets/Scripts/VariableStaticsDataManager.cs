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
    
    //�ѿ��� ������ ���� è�Ǿ��� ������ ����� ���� ���ٰ� �����Ѵ�.
    //�����͸� Json���� �����ϰ�, ���⼭ �о�´ٰ� ��������. 
    //�޸𸮿� è�Ǿ��� ������ �����Ѵ�.
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
                foreach(var j in champion_jungle_minion) //JObject�� ���ؼ� ���� ��� �ϸ� ���Ӽ� ���� �����ұ�. //json�� ������ ���� �� ���� ������.
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
