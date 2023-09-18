using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class GWorld 
{
    private static readonly GWorld gWorld = new GWorld();
    private static WorldStates world;
   
    static GWorld()
    {
        world = new WorldStates();
    }

    private GWorld() 
    {
    }

    public static GWorld Instance
    {
        get { return Instance; }
    }

    public WorldState GetWorld()
    {
        return world;
    }
}
