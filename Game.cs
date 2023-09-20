using Godot;
using System;

public partial class Game : Node
{
	//敵人
	[Export] public PackedScene EnemyPrefab;
	//場景
	[Export] public Node2D WorldRoot;
	//計時器
	[Export] public Timer SpawnTimer;

	public override void _Ready()
	{
		GD.Print("Game Start!!!");
		//誕生敵人
		SpawnTimer.Timeout += () =>
		{
			SpawnEnemy();
		};
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	private void SpawnEnemy()
	{
		//誕生處理
		var pos = new Vector2(GD.RandRange(0, GetWindow().Size.X), -50);
		var e = EnemyPrefab.Instantiate() as Enemy;
		WorldRoot.AddChild(e);
		e.GlobalPosition = pos;
	}
}
