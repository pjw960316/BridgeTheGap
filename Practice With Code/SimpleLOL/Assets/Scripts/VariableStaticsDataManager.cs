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
