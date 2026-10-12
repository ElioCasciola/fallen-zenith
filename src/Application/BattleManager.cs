using System.Runtime.CompilerServices;
using FallenZenith.Domain;
using FallenZenith.Presentation;

namespace FallenZenith.Application;

public class BattleManager
{
    public bool IsPlayerTurn { get; private set; }

    /*
     * Determines turn order based on Speed.
     * The player moves first when Speed values are equal.
     */
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

    //Determines Who Moves First
    public void StartBattle(Character player, Monster enemy)
    {
        IsPlayerTurn = DetermineFirstTurn(player, enemy);
    }
    //Determines Physical Damage = [Attack * (Strength * 0.05)] - Target Defense
    public int CalculatePhysicalDamage(int attack, int strength, int defense)
    {
        double damage = attack*(1 + strength * 0.05) - defense;
        if (damage < 1)
        {
            damage = 1;
        }
        return(int) damage;
    }

    //Executes Player Normal Attack - Reduces Target Hp By That Ammount
    public int ExecuteBasicAttack(Character player, Monster enemy)
    {
        int damage = CalculatePhysicalDamage(player.PhysicalAttack, player.Strength, enemy.Defense);
        enemy.TakeDamage(damage);
        return damage;
    }
    //Executes Monster Normal Attack - Reduces Target Hp By That Ammount
    public int ExecuteBasicAttack(Monster enemy, Character player)
    {
        int damage = CalculatePhysicalDamage(enemy.PhysicalAttack, enemy.Strength, player.Defense);
        player.TakeDamage(damage);
        return damage;
    }
}
