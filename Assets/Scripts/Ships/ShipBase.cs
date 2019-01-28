using System.Collections;
using System.Collections.Generic;
using UnityEngine;







public class ShipBase : MonoBehaviour {
    //params

    //名称
    public string SHIPName;
    //假名
    public string KANA;
    //船种
    public ShipCatagory SHIP_Catagory;
    //等级
    [Range(1, 100)]
    public uint LEVEL;
    //血量
    [Range(0, 100)]
    public uint MAX_HEALTH;
    //当前血量
    [Range(0, 100)]
    public uint HEALTH;
    //装甲
    [Range(1, 200)]
    public uint ARMOR;
    //回避
    [Range(1, 100)]
    public uint EVAC;
    //搭载
    [Range(0, 500)]
    public uint CARRY;
    //速力
    public ShipSpeedMode SPEED;
    //射程
    public RangeMode RANGE;
    //火力
    public uint FIREPOWER;
    //雷装
    public uint TORPEDO;
    //对空
    public uint ANTI_AIR;
    //对潜
    public uint ANTI_SUB;
    //索敌
    public uint LOS;
    //运
    public uint LUCK;
    //经验
    public uint exp;
    //装备栏
    public List<EquipmentBase> SLOTS;
    //
    //阈值后火力
    //public uint final_attack_power;
    //public uint attackpower;
    
    //TODO.1 get finalpower calculation
    /*
    private uint DayTimeAttackPower(uint fp, uint tpd, ShipAttackMode attackMode,uint los)
    {
        uint final_power=0;
        switch (attackMode)
        {
            case ShipAttackMode.SINGLE:
                final_power = 1;
                break;
            case ShipAttackMode.CI_DOUBLE:
                final_power = 2;
                break;
            case ShipAttackMode.CI_AP:
                final_power = 3;
                break;
            case ShipAttackMode.AIR_SINGLE:
                final_power = 4;
                break;
            case ShipAttackMode.AIR_CI:
                final_power = 5;
                break;
            case ShipAttackMode.ANTI_SUB:
                final_power = 6;
                break;
        }
        return final_power;
    }
    */


    private ShipAttackMode DecideAttackMode()
    {
        ShipAttackMode _shipAttackmode=ShipAttackMode.UNDEFINED;

        //TODO attackmode


        return _shipAttackmode;
    }

    

    private RangeMode DecideShipAttackRangeMode()
    {
        RangeMode _range = RangeMode.UNDEFINED;
        
        //TODO range
        

        return _range;
    }

    public int CertainEquipCount(string equip_name)
    {
        int count = 0;
        foreach(EquipmentBase equip in SLOTS)
        {
            if (equip.name == equip_name)
            {
                count++;
            }
            
        }

        return count;
    }

}
