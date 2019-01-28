using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentBase : MonoBehaviour {

    public string EQUIP_NAME;

    public string EQUIP_KANA;
    [Range(0, 100)]
    public uint FIREPOWER;
    [Range(0, 100)]
    public uint TORPEDO;
    [Range(0, 100)]
    public uint BOMB;
    [Range(0, 100)]
    public uint ANTI_AIR;
    [Range(0, 100)]
    public uint ANTI_SUB;
    [Range(0, 100)]
    public uint ACCURACY;
    [Range(0, 100)]
    public uint ARMOR;
    [Range(0, 100)]
    public uint EVAC;
    [Range(0, 100)]
    public uint LOS;
    //[Range(0, 100)]
    public RangeMode equipRange = RangeMode.UNDEFINED;



    ///define the attack range of current ship;
    ///v0.1
    ///TODO.coping for all equip and traversing all slots 
    /*
    
    public RangeMode FinalRangeTest(RangeMode shiprange, RangeMode equiprange)
    {
        RangeMode range = RangeMode.UNDEFINED;
        shiprange = RangeMode.LONG;
        equiprange = RangeMode.ULTRA_LONG;
        range = (shiprange.CompareTo(equiprange) >= 0) ? shiprange : equiprange;
        

        return range;

    }
    */

    // Use this for initialization

}




public enum EquipmentCategory
{
    CarrierBased_Fighter,
    CarrierBased_Attacker,
    CarrierBased_Bomber,
    CarrierBased_Recon,
    LandBased_Fighter,
    LandBased_Attacker,
    LandBased_Recon,
    MinorCaliber_GunMount,
    MediumCaliber_GunMount,
    LargeCaliber_GunMount,
    SecondaryGunMount,
    TorpedoMount,
    Radar,
    Sonar,//水听 声呐
    DepthCharge_Projector,
    DepthCharge,//暴雷
    AP_Shell,
    MachineGun,
    Turbine_Boiler_Bulge,
    SearchLight,
    SeaPlane_Recon,
    FloatPlane_Fighter,
    Zuiun,
    Flying_Boats,
    Other_Equips
}
