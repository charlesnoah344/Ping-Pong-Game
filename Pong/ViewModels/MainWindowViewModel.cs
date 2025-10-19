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
    public double size = 64;
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
        //GESTION DES BOUTONS AU CLAVIER POUR DEPLACER LES RACKETS

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

        if (Keyboard.Keys.Contains(Key.Down))
        {

            r_racket.OnDown();

        }

    
        //INVERSION DU SENS DE LA VITESSE EN CAS DE COLLISION AVEC UNE RAQUETTE
        
        if (ball.Location.X >= r_racket.Location.X - 20 && ball.Location.X <= r_racket.Location.X - 5 && ball.Location.Y >= r_racket.Location.Y-45 && ball.Location.Y <= r_racket.Location.Y+60)
        // Racket Droite
        {
            //GESTION DES BOUTONS AU CLAVIER POUR choisir la direction ou envoyer la balle

            if (Keyboard.Keys.Contains(Key.Up))
            {

                ball.ChangeDirection_racket(-45); //déviation vers le haut

            }
            else if (Keyboard.Keys.Contains(Key.Down))
            {

                ball.ChangeDirection_racket(45); //déviation vers le bas

            }
            else
            {
                ball.ChangeVelocity();
            }
            
        }
        else if (ball.Location.X >= l_racket.Location.X + 35 && ball.Location.X <= l_racket.Location.X + 45 && ball.Location.Y >= l_racket.Location.Y - 35 && ball.Location.Y <= l_racket.Location.Y + 55)
        //Racket Gauche
        {

            //GESTION DES BOUTONS AU CLAVIER POUR choisir la direction ou envoyer la balle

            //Racket Gauche
            if (Keyboard.Keys.Contains(Key.A))
            {

                ball.ChangeDirection_racket(45); //déviation vers le haut

            }
            else if (Keyboard.Keys.Contains(Key.Q))
            {

                ball.ChangeDirection_racket(-45); //déviation vers le bas

            }
            else
            {
                ball.ChangeVelocity();
            }
        }
        //gestion des changement de direction sur les murs
        else if (ball.Location.Y <= 0 || ball.Location.Y >= 390 )
        {
            ball.ChangeDirection_wall();
        }
    }
    
}
