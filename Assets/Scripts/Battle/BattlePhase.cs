using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
public struct BattlePhaseBool
{
    public static bool Formation_bool = true;
    public static bool LOS_bool = true;
    public bool JetStrike_bool;
    public bool LandBase_bool;
    public bool AirCombatStage1_bool;
    public bool AirCombatStage2_bool;
    public bool SupportFleet_bool;
    public bool Pre_AntiSub_bool;
    public bool Pre_TorpedoAttack_bool;
    public static bool EngageMode_bool = true;
    public static bool BattleRound_bool = true;
    public bool ExtendedRound_bool;



}
*/


public class BattlePhase {

    private Dictionary<string, bool> battlephase;

    public static bool Formation_bool = true;
    public static bool LOS_bool = true;
    public bool JetStrike_bool;
    public bool LandBase_bool;
    public bool AirCombatStage1_bool;
    public bool AirCombatStage2_bool;
    public bool SupportFleet_bool;
    public bool Pre_AntiSub_bool;
    public bool Pre_TorpedoAttack_bool;
    public static bool EngageMode_bool = true;
    public static bool BattleRound_bool = true;
    public bool ExtendedRound_bool;

    private bool[] battlephaseboollist;

    private static BattlePhase instance;

    private BattlePhase()
    {
        battlephase = new Dictionary<string, bool>();
        battlephaseboollist = new bool[12];
        battlephaseboollist[0] = Formation_bool;
        battlephaseboollist[1] = LOS_bool;
        battlephaseboollist[2] = JetStrike_bool;
        battlephaseboollist[3] = LandBase_bool;
        battlephaseboollist[4] = AirCombatStage1_bool;
        battlephaseboollist[5] = AirCombatStage2_bool;
        battlephaseboollist[6] = SupportFleet_bool;
        battlephaseboollist[7] = Pre_AntiSub_bool;
        battlephaseboollist[8] = Pre_TorpedoAttack_bool;
        battlephaseboollist[9] = EngageMode_bool;
        battlephaseboollist[10] = BattleRound_bool;
        battlephaseboollist[11] = ExtendedRound_bool;

    }

    public static BattlePhase GetInstance()
    {
        if (instance == null)
        {
            instance = new BattlePhase();
        }
        return instance;
    }

    private void InitialBattlePhase()
    {
        //battlephase.Add("Formation_bool", Formation_bool);
        //battlephase.Add("LOS_bool", LOS_bool);
        //battlephase.Add("JetStrike_bool", JetStrike_bool);
        //battlephase.Add("LandBase_bool", LandBase_bool);
        //battlephase.Add("AirCombatStage1_bool", AirCombatStage1_bool);
        //battlephase.Add("AirCombatStage2_bool", AirCombatStage2_bool);
        //battlephase.Add("SupportFleet_bool", SupportFleet_bool);
        //battlephase.Add("Pre_AntiSub_bool", Pre_AntiSub_bool);
        //battlephase.Add("Pre_TorpedoAttack_bool", Pre_TorpedoAttack_bool);
        //battlephase.Add("EngageMode_bool", EngageMode_bool);
        //battlephase.Add("BattleRound_bool", BattleRound_bool);
        //battlephase.Add("ExtendedRound_bool", ExtendedRound_bool);


        //battlephase["ExtendedRound_bool"]
    }

    
	
}
