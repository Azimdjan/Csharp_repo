using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    int totalgreen = 0;
    int totalwhite = 0;
    int totalred = 0;
    public int TotalGreen(int numberOfRocks)
    {
        totalgreen += numberOfRocks;
        return totalgreen; 
    }
    public int TotalWhite(int numberOfRocks)
    {
        totalwhite += numberOfRocks;
        return totalwhite;
    }
    public int TotalRed(int numberOfRocks)
    {
        totalred += numberOfRocks;
        return totalred;
    }
}
