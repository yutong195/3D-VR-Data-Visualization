using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Unity.VisualScripting;
using System.IO;
//using System.Numerics;

public class CSVReader:MonoBehaviour
{
    //public GameObject paddle;
    private int iter = 0;
    private int count = -1;
    private List<String> date = new List<String>();
    private List<float> high = new List<float>();
    public GameObject sphere;
    void Start()
    {
        string path = "C:\\Users\\yr55\\Documents\\WeChat Files\\wxid_ebfy5as7lftu22\\FileStorage\\File\\2022-09\\stock.csv";

        string[] lines = System.IO.File.ReadAllLines(path);
        foreach (string line in lines)
        {
            iter += 1;
            string[] columns = line.Split(',');
            //date.Add(columns[0]);
            //high.Add(float.Parse(columns[1]));
            
            //if(iter==1 || count == -1 || count == 0)
            //{
                //continue;
            //}
            //Debug.Log(iter);
            if(iter == 1)
            {
                continue;
            }
            else
            {
                //Vector3 two_point = new Vector3(1, high[count] - high[count - 1], 0);
                //float angle = Vector3.Angle(new Vector3(1,0,0), two_point);
                //float dist = Vector3.Distance(new Vector3(count, high[count-1],0), new Vector3(count+1, high[count],0));

                //GameObject obj = Instantiate(paddle, new Vector3((2*count + 1) / 2, (high[count - 1] + high[count])/2,0),Quaternion.Euler(0,0,angle));
                //obj.transform.localScale = new Vector3(dist,0.1f,1);
                //Debug.Log(iter);
                Instantiate(sphere, new Vector3((iter-1)*20, (float.Parse(columns[1])-480)*2f, 0), Quaternion.identity);
            }

            //count += 1;
        }
    }

    
}