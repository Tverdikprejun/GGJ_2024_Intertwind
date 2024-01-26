using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CableManager : MonoBehaviour
{
    [SerializeField]
    private Cable[] cables;


    private bool GetCablesIntersection(float p0_x, float p0_y, float p1_x, float p1_y,
    float p2_x, float p2_y, float p3_x, float p3_y)
    {
        float s1_x, s1_y, s2_x, s2_y;
        s1_x = p1_x - p0_x; s1_y = p1_y - p0_y;
        s2_x = p3_x - p2_x; s2_y = p3_y - p2_y;

        float s, t;
        s = (-s1_y * (p0_x - p2_x) + s1_x * (p0_y - p2_y)) / (-s2_x * s1_y + s1_x * s2_y);
        t = (s2_x * (p0_y - p2_y) - s2_y * (p0_x - p2_x)) / (-s2_x * s1_y + s1_x * s2_y);

        if (s >= 0 && s <= 1 && t >= 0 && t <= 1)
        {
            // Collision detected
            return true;
        }

        return false; // No collision
    }

    private void Update()
    {
        foreach (Cable cable in cables)
        {
            cable.isShorted = false;
        }
            foreach (Cable cable in cables)
        {
            foreach (Cable cable2 in cables)
            {
               if(GetCablesIntersection(cable.GetStartX(),cable.GetStartY(),cable.GetEndX(),cable.GetEndY(),
                   cable2.GetStartX(), cable2.GetStartY(), cable2.GetEndX(), cable2.GetEndY()))
                {
                    cable.isShorted = true;
                    cable2.isShorted = true;
                }
                
            }
        }
    }
}
