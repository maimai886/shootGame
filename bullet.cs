using Godot;
using System;

public partial class bullet : Sprite2D
{
	//設置計時器
	[Export] public Timer DelayTimer;
	public override void _Ready()
	{
		//時間到銷毀
		DelayTimer.Timeout += () =>
		{
			QueueFree();
		};
	}

	public override void _Process(double delta)
	{
		//子彈移動方向
		var p = GlobalPosition;
		p.Y -= 10;
		GlobalPosition = p;
	}
}
