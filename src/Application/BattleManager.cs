using System.Runtime.CompilerServices;
using FallenZenith.Domain;
using FallenZenith.Presentation;

namespace FallenZenith.Application;

public class BattleManager
{
    public bool IsPlayerTurn { get; private set; }

    public bool DetermineFirstTurn(Character player, Monster enemy)
    {
        if(player.Speed >= enemy.Speed)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void StartBattle(Character player, Monster enemy)
    {
        IsPlayerTurn = DetermineFirstTurn(player, enemy);
    }
}
