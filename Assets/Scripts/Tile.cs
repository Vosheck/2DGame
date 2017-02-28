using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile  {

    public Sprite TileSprite;

    private int _x;
    private int _y;

    public int X { get { return _x; } }
    public int Y { get { return _y; } }




    public Tile(int x,int y)
    {
        this._x = x;
        this._y = y;
    }
}
