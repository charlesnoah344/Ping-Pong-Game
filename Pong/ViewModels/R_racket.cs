using Avalonia;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Pong.ViewModels;

public partial class R_racket : GameObject {
    [ObservableProperty]
    private Point velocity = new Point(0, 6);
    //mes rackets bougent selon l'axe y
    public R_racket(Point location) : base(location) {

    }

    public void Tick()
    {
        Location = Location + Velocity;
    }

    public void OnUp()
    {
        double newY = Location.Y - Velocity.Y;
        if (newY < 0) newY = 0;
        Location = new Point(Location.X, newY);
    }
    public void OnDown()
    {
        //Déplacer vers le bas mais ne pas dépasser le bas du canvas
        double maxY = 450 - 80; // 450 = hauteur du canvas, 80 = hauteur de la raquette
        double newY = Location.Y + Velocity.Y;
        if (newY > maxY) newY = maxY;
        Location = new Point(Location.X, newY);
    }
    
}