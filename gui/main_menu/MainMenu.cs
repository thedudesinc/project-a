using Godot;
using System;

public partial class MainMenu : Control
{
	private PackedScene gameScene;


	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		gameScene = ResourceLoader.Load<PackedScene>("res://levels/game.tscn");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void _on_play_button_pressed()
	{
		GetTree().ChangeSceneToPacked(gameScene);
	}

	public void _on_quit_button_pressed()
	{
		GetTree().Quit();
	}
}
