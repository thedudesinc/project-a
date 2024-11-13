using Godot;
using System;

public partial class Game : Node3D
{
	[Export]
	public bool UseTestLevel = true;

	public PackedScene testLevel;

	private Timer timer;
	private ColorRect loadScreen;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		timer = GetNode<Timer>("Timer");
		loadScreen = GetNode<ColorRect>("ColorRect");
		testLevel = ResourceLoader.Load<PackedScene>("res://levels/debug/test_level.tscn");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{

	}

	public void _on_timer_timeout()
	{
		if (UseTestLevel)
		{
			GetTree().ChangeSceneToPacked(testLevel);
		}
	}
}
