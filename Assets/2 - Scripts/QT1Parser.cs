using UnityEngine;
using System.IO;


public class QT1Parser : MonoBehaviour
{    
    public string[] _QT1Data;
    string[] sourceQT1;
    string[] _tempQTD1;
    public string[,] _tempQTD2 = new string[200, 15];

    void Start()
    {

        
        TextAsset _QT1Data0 = (TextAsset)Resources.Load("Datas/StoryMaker - QT1");
        StringReader sr = new StringReader(_QT1Data0.text);

        sourceQT1 = new string[200];
        
        for (int i = 0; i < 200; i++)
        {
            sourceQT1[i] = sr.ReadLine();
            if (sourceQT1[i] == null)
            {
                break;
            }
            //Debug.Log(source1[i]);
        }
        
        Parse();
         

    }

    public void Parse()
    {

        _QT1Data = new string[7];

  
        for (int i = 0; i < sourceQT1.Length; i++)
        {
            if (sourceQT1[i] == null)
            {
                break;
            }

            _QT1Data[i] = sourceQT1[i];

            string source = sourceQT1[i];
            _tempQTD1 = source.Split(',');
            //Debug.Log(_tempQTD1[0]);

            for (int y = 0; y < _tempQTD1.Length; y++)
            {
                _tempQTD2[i, y] = _tempQTD1[y];
            }

        }

    }
}