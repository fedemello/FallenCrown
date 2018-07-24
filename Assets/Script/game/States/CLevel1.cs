﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CLevel1 : CGameState
{
    public const int IN_PROGRESS = 0;
    public const int FINISHED = 1;

    private CTileMap mMap;

    override public void init()
    {
        base.init();
        mMap = new CTileMap();
        CGame.inst().setMap(mMap);
        setState(CLevel1.IN_PROGRESS);
        Debug.Log("cree CLevel1");
    }
    public override void update()
    {
        base.update();
        mMap.update();
    }
    public override void render()
    {
        base.render();
        mMap.render();
    }
    public override void destroy()
    {
        base.destroy();

        mMap.destroy();
        mMap = null;
    }
}
