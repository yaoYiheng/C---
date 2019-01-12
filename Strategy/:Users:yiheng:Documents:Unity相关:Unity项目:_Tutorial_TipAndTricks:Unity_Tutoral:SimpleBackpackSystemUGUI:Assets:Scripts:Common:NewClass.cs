using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : Item
{
    public int ManaPoint { get; private set; }
    public int HealthPoint { get; private set; }
    public Drag(int id, string icon, string name, string des, int sell, int buy, int mp, int hp)
        : base(id, icon, name, des, sell, buy)
    {
        base.Type = ItemType.d
        this.ManaPoint = mp;
        this.HealthPoint = hp;
    }