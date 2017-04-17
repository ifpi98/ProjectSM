using UnityEngine;
using System.IO;


public class AT1Parser : MonoBehaviour
{    
    public string[] _AT1Data;
    string[] sourceAT1;
    string[] _tempATD1;
    public string[,] _tempATD2 = new string[200, 15];

    void Start()
    {

        
        TextAsset _AT1Data0 = (TextAsset)Resources.Load("Datas/StoryMaker - AT1");
        StringReader sr = new StringReader(_AT1Data0.text);

        sourceAT1 = new string[200];
        
        for (int i = 0; i < 200; i++)
        {
            sourceAT1[i] = sr.ReadLine();
            if (sourceAT1[i] == null)
            {
                break;
            }
            //Debug.Log(source1[i]);
        }
        
        Parse();
         

    }

    public void Parse()
    {

        _AT1Data = new string[24];

  
        for (int i = 0; i < sourceAT1.Length; i++)
        {
            if (sourceAT1[i] == null)
            {
                break;
            }

            _AT1Data[i] = sourceAT1[i];

            string source = sourceAT1[i];
            _tempATD1 = source.Split(',');
            //Debug.Log(_tempATD1[0]);

            for (int y = 0; y < _tempATD1.Length; y++)
            {
                _tempATD2[i, y] = _tempATD1[y];
            }

        }

    }
}