using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleStatistics : MonoBehaviour {
    public ShipBase[] Player;
    public ShipBase[] Enemy;
    public string SaiunName = "Saiun";
    private int SaiunCount;
    private bool HasSaiun;

    private BattlePhase battlePhase;
    private BattleState battleState;
    private float[] engage_probabities;

    private EngageMode em;
    //public bool[]


	// Use this for initialization
	void Start () {
		battlePhase=BattlePhase.GetInstance();
        battleState = BattleState.GetInstance();

        engage_probabities = new float[4];
        engage_probabities[0] = 0.45f;//parallel
        engage_probabities[1] = 0.30f;//headon
        engage_probabities[2] = 0.15f;//green
        engage_probabities[3] = 0.10f;//red


        
        em = battleState.SetEngageMode(true,engage_probabities);
        //TODO. 获取彩云信息
        hasSaiun(out SaiunCount, out HasSaiun);
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void hasSaiun(out int saiunCount,out bool has)
    {
        //bool has;
        saiunCount = 0;//int saiun = 0;
        foreach(ShipBase sb in Player)
        {
            if (sb.SHIP_Catagory == ShipCatagory.CV)
            {
                saiunCount += sb.CertainEquipCount(SaiunName);
            }
            
        }
        if (saiunCount > 0)
        {
            has = true;
        }
        else
        {
            has = false;
        }
        //return has;

        
    }


    

    //private
}
