using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helper
{
    // Start is called before the first frame update
    public static GameMonitor GetGameMonitor()
    {
        GameMonitor gameMonitor = GameObject.FindGameObjectWithTag("game_monitor")
            .GetComponent<GameMonitor>();
        return gameMonitor;
    }
    public static Vector2 getVector2DByDegree(float degree)
    {
        float radian = degree * Mathf.Deg2Rad;
        float sinD = Mathf.Sin(radian);
        float cosD = Mathf.Cos(radian);
        // print(sinD + "   " + cosD);
        float x = sinD;
        float y = cosD;
        return new Vector2(x, y);
    }
}
