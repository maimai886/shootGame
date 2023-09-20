using Godot;
using System;

public partial class Jack : Node2D
{
	[Export] public PackedScene BulletPrefab;
	public override void _Ready()
	{
	}

	public override void _Process(double delta)
	{
		//人物控制
		var inputVec = new Vector2(
			Input.GetAxis("ui_left", "ui_right"),
			Input.GetAxis("ui_up", "ui_down")
		);
		//人物移動速度
		GlobalPosition += inputVec * 10;

		//空白鍵發射
		if (Input.IsActionJustPressed("ui_accept"))
		{
			shoot();
		}
	}
	private void shoot()
	{
		//發射處理
		var b = BulletPrefab.Instantiate() as Node2D;
		GetParent().AddChild(b);
		b.GlobalPosition = GlobalPosition;
	}
}
