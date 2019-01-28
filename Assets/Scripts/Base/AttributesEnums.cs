using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public enum ShipCatagory
{
    BB,
    CV,
    CA,
    CL,
    DD,
    SS
}

public enum ShipSpeedMode
{
    UNDEFINED,
    LOW,
    HIGH,
    HIGH_PLUS,
    ULTRA_HIGH
}

public enum RangeMode
{
    UNDEFINED,
    SHORT,
    MEDIUM,
    LONG,
    ULTRA_LONG
}

public enum ShipAttackMode
{
    UNDEFINED,
    SINGLE,
    CI_DOUBLE,
    CI_AP,
    AIR_SINGLE,
    AIR_CI,
    ANTI_SUB
}
