using Avalonia;
using CommunityToolkit.Mvvm.ComponentModel;
namespace Pong.ViewModels;
using System;

public partial class Ball : GameObject {
    [ObservableProperty]
    private Point velocity = new Point(3.0, 3.0); //trajectoire initiale à 45 dégré

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
    public void ChangeDirection_racket(double deltaAngleDegrees = 45)
    {
        // Convertir l'angle en radians
        double deltaAngleRadians = Math.PI * deltaAngleDegrees / 180.0;

        double cosA = Math.Cos(deltaAngleRadians);
        double sinA = Math.Sin(deltaAngleRadians);

        // Appliquer la rotation du vecteur vitesse
        double newX = Velocity.X * cosA - Velocity.Y * sinA;
        double newY = Velocity.X * sinA + Velocity.Y * cosA;

        Velocity = new Point(-newX, newY);
    }
public void ChangeDirection_wall()
    {
        Velocity = new Point(Velocity.X, -Velocity.Y);
    }

}