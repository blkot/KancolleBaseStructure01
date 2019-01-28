using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public struct SupplyStruct
{
    public uint Oil;
    public uint Ammo;
    public uint Steel;
    public uint Alum;
}
public class ResourcesSupply {

    private static ResourcesSupply instance;
    private ResourcesSupply()
    {
        resSup = new SupplyStruct();
        resSup.Oil = 100000;
        resSup.Ammo = 100000;
        resSup.Steel = 100000;
        resSup.Alum = 100000;

    }

    public static ResourcesSupply GetResourcesSupply()
    {

        if (instance == null)
        {
            instance = new ResourcesSupply();
        }
        return instance;
    }

    private SupplyStruct resSup;
    public SupplyStruct ResSup
    {
        get { return resSup; }
        set { resSup = value; }
    }

    

    
	
}
