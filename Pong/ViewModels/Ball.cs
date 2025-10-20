using Avalonia;
using CommunityToolkit.Mvvm.ComponentModel;
namespace Pong.ViewModels;
using System;

public partial class Ball : GameObject {
    [ObservableProperty]
    private Point velocity = new Point(3.0, 3.0); //trajectoire initiale à 45 dégré de norme 9

    public Ball(Point location) : base(location) {

    }

    public void Tick()
    {
        Location = Location + Velocity;
    }
    public void ChangeVelocity()
    {
        Velocity = new Point(-Velocity.X, Velocity.Y);
    }
    public void ChangeDirection_wall()
    {
        Velocity = new Point(Velocity.X, -Velocity.Y);
    }

}