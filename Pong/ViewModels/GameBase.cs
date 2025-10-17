using System;
using System.Data;
using Avalonia.Threading;

namespace Pong.ViewModels;

// Impose d'implémenter la méthode Tick() et s'occupe de l'appeler 60 fois par seconde.
// Cela sert de "boucle" principale pour notre application graphique.
public abstract class GameBase: ViewModelBase
{
    public const int TicksPerSecond = 60;
    private readonly DispatcherTimer _timer = new() { Interval = new TimeSpan(0, 0, 0, 0, 1000 / TicksPerSecond) };

    protected GameBase()
    {
        _timer.Tick += delegate { DoTick(); };
    }

    public long CurrentTick { get; private set; }


    private void DoTick()
    {
        Tick();
        Update();
        CurrentTick++;
    }

    protected abstract void Tick();
    protected abstract void Update();

    // Appelé dans App.axaml.cs
    public void Start()
    {
        _timer.IsEnabled = true;
    }

    public void Stop()
    {
        _timer.IsEnabled = false;
    }
}