using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CRISTAL : MonoBehaviour
{
    bool OK;
    bool HIT;
    public int count;
    public int no;

    public int USE_LINE_NUM;
    const int MAX_LINE = 3;
    int Line_count;

    public bool[] Clare = new bool[MAX_LINE];

    // Start is called before the first frame update
    void Start()
    {
        HIT = false;
        OK = false;
        count = 0;
        no = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        
        Line_count = 0;

        if (Clare[USE_LINE_NUM -1] == true)
        {
            count++;

            if (count == 180)
            {
                Debug.Log("clear");
                //GoToClear.Go();
            }

            /*
            no++;
            if (no == 5)
            {
                no = 0;
                count = 0;
                HIT = false;
            }
            */
        }
        else
        {
            //no++;
            //if (no == 5)
            //{
                //no = 0;
                count = 0;
                //HIT = false;
            //}
        }
        
        for(int i=0;i<MAX_LINE;i++)
        {
            Clare[i] = false;
        }
        
    }


    public void HitCristal()
    {
        //Clare[Line_count] = true;

        /*
        if(!HIT)
        {
            HIT = true;
        }
        */

        //Line_count++;

        //no = 0;
    }

    public void SetHit()
    {
        Clare[Line_count] = true;

        /*
        if(!HIT)
        {
            HIT = true;
        }
        */

        Line_count++;

        no = 0;
    }
}
