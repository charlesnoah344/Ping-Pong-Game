using Avalonia;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.ObjectModel;
using System.Security.Cryptography;
using Avalonia.Input;

namespace Pong.ViewModels;

public partial class MainWindowViewModel : GameBase
{
    public int Width { get; } = 800;
    public int Height { get; } = 450;
    private Ball ball;
    private R_racket r_racket;
    private L_racket l_racket;


    // Liste des objets à afficher
    public ObservableCollection<GameObject> GameObjects { get; } = new();

    public MainWindowViewModel()
    {
        //implémentation backend de nos objets
        //Objet balle
        ball = new Ball(new Point(Width / 2 - 32, Height / 2 - 32));
        GameObjects.Add(ball);
        //Objet racket gauche
        l_racket = new L_racket(new Point(50 / 2 - 32, Height / 2 - 32));
        GameObjects.Add(l_racket);
        //Objet racket droite
        r_racket = new R_racket(new Point(Width-50 / 2 - 32, Height / 2 - 32));
        GameObjects.Add(r_racket);
    }


    protected override void Tick()
    {
        ball.Tick();
        //Racket Gauche
        if (Keyboard.Keys.Contains(Key.A))
        {
            
            l_racket.OnUp();
            
        }

        if (Keyboard.Keys.Contains(Key.Q))
        {
            
            l_racket.OnDown();
            
        }
        
        //Racket Droite
        if (Keyboard.Keys.Contains(Key.Up))
        {
        
            r_racket.OnUp();
            
        }

        if(Keyboard.Keys.Contains(Key.Down))
        {
            
            r_racket.OnDown();
            
        }

    

        if (ball.Location.X >= Width - 100) //Droite
        {
            ball.ChangeVelocity();
        }
        if (ball.Location.X <=35) //Gauche
        {
            ball.ChangeVelocity();
        }
    }
    
}
