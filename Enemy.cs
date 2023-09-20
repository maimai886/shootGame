using Godot;
using System;

public partial class Enemy : Sprite2D
{
	//碰撞範圍
	[Export] public Area2D HitArea;
	public override void _Ready()
	{
		//觸碰銷毀
		HitArea.AreaEntered += (otherArea) =>
		{
			QueueFree();
		};
	}

	public override void _Process(double delta)
	{
		//敵人移動方向
		var p = GlobalPosition;
		p.Y += 4;
		GlobalPosition = p;
	}
}
