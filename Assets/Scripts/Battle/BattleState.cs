using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleState {
    private static BattleState instance;
    public EngageMode engageMode;
    public BattleFormation battleFormation;
    //private float[] engage_probabities;

    private BattleState()
    {
        engageMode = EngageMode.PARALLEL;
        battleFormation = BattleFormation.LINE_AHEAD;

        //解耦合，具体实现在Mono中做
        //engage_probabities= new float[4];
        //engage_probabities[0] = 0.45f;
        //engage_probabities[1] = 0.30f;
        //engage_probabities[2] = 0.15f;
        //engage_probabities[3] = 0.10f;
    }

    public static BattleState GetInstance()
    {
        if (instance == null)
        {
            instance = new BattleState();
        }

        return instance;
    }

    public EngageMode SetEngageMode(bool hasSaiun,float[] probabilities)
    {
        EngageMode em;
        float p;
        p = Random.Range(0, 1);
        //System.Random rd = new System.Random();
        if (p <= probabilities[0])
        {
            em = EngageMode.PARALLEL;
        }
        else
        {
            if (p <= (probabilities[0] + probabilities[1]))
            {
                em = EngageMode.HEAD_ON;
            }
            else
            {
                if(p<=(probabilities[0]+ probabilities[1]+ probabilities[2]))
                {
                    em = EngageMode.T_GREEN;
                }
                else
                {
                    if (hasSaiun)
                    {
                        em = EngageMode.HEAD_ON;
                    }
                    else
                    {
                        em = EngageMode.T_RED;
                    }
                }
            }
        }
        
        return em;
    }


    //public BattleFormation SetBattleFormation()
    //{
    //    BattleFormation bf=BattleFormation.LINE_AHEAD;



    //    return bf;
    //}
	// Use this for initialization
	
}
