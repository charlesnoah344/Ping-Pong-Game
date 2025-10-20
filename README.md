# 🏓 Pong — Jeu d'exemple en C# avec Avalonia

Un petit projet **Pong** développé en **C#** avec le framework multiplateforme **[Avalonia UI](https://avaloniaui.net/)**.  
Ce dépôt illustre la séparation **interface graphique / logique métier (MVVM)** et sert de base pour l’apprentissage du développement d’applications graphiques modernes avec C#.

---

## ✨ Fonctionnalités principales

- 🎨 Interface graphique en **Avalonia** (XAML)
- 🧠 Logique de jeu claire via des **ViewModels** (`Ball`, `R_racket`, `L_racket`, etc.)
- 🎮 Contrôles clavier fluides pour les deux joueurs
- 🔄 Boucle de jeu simple et réactive
- 💬 Code clair, commenté et conçu pour l’apprentissage

---

## ⚙️ Prérequis

- **.NET SDK 9.0** ou supérieur  
  *(vérifiez avec `dotnet --version`)*
- **Visual Studio**, **Rider**, ou **VS Code**
- *(Optionnel)* : extension **Avalonia for Visual Studio / VS Code** pour un meilleur support XAML

> 💡 Le projet est déjà configuré pour être compilé avec le SDK .NET : les fichiers `.csproj` et `.sln` sont fournis.

**##🧱 Structure du projet**

Pong/
├── Views/                 # Interface graphique (XAML + code-behind)
│   └── MainWindow.axaml(.cs)
│
├── ViewModels/            # Logique du jeu
│   ├── Ball.cs
│   ├── GameBase.cs
│   ├── GameObject.cs
│   ├── L_racket.cs
│   ├── R_racket.cs
│   └── MainWindowViewModel.cs
│
├── Keyboard.cs            # Gestion simplifiée des entrées clavier
├── Program.cs             # Point d’entrée du programme
├── App.axaml(.cs)         # Configuration Avalonia
└── Pong.csproj

**##🎮 Contrôles du jeu**

| Joueur | Action    | Touche                   |
| :----- | :-------- | :----------------------- |
| Gauche | Monter    | **A**                    |  
| Gauche | Descendre | **Q**                    |
| Droite | Monter    | **Flèche Haut**          |
| Droite | Descendre | **Flèche Bas**           |

**🧩 Améliorations possibles**

Voici quelques pistes pour enrichir le jeu :

🧮 Système de score dynamique affiché à l’écran

🧠 IA pour contrôler une raquette automatiquement

🎵 Effets sonores lors des rebonds ou des points

🕹️ Menu principal et écran de pause

🧪 Tests unitaires sur la logique du jeu

🎨 Personnalisation des assets (balle, raquettes, fond)

**👨‍🏫 Crédits**

Projet développé à titre d’exemple dans le cadre d’un cours de Programmation Orientée Objet (ECAM).
Conçu pour illustrer l’architecture MVVM, la gestion d’événements, et la programmation graphique avec Avalonia.

**Auteur**

Charles Noah
