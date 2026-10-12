using FallenZenith.Domain;
using FallenZenith.Presentation;
using FallenZenith.Application;
using System.Runtime.CompilerServices;

var player = new Character(
    100, 100,  // HP, MaxHP
    30, 30,    // MP, MaxMP
    10,        // Physical Attack
    15,        // Strength
    5,         // Magical Attack
    5,         // Intelligence
    10,        // Defense
    5,         // MagicDefense
    12,        // Speed
    5,         // CriticalChance
    1,         // Level
    1,         // Experience
    new List<Skill>()
);

var enemy = new Monster(
    "Goblin",
    40, 40,    // HP, MaxHP
    10, 10,    // MP, MaxMP
    15,          // Physical Attack
    8,         // Strength
    1,         // Magical Attack
    2,         // Intelligence
    4,         // Defense
    2,         // MagicDefense
    18,         // Speed
    3,         // CriticalChance
    1,         // Level
    new List<Skill>()
);

var console = new ConsoleUI();
var battleManager = new BattleManager();
//console.ShowMainMenu();
battleManager.StartBattle(player, enemy);
//console.ShowBar("HP", player.HP, player.MaxHP);
//console.ShowBar("MP", player.MP, player.MaxMP);

int playerDamage = battleManager.ExecuteBasicAttack(player,enemy);
int enemyDamage = battleManager.ExecuteBasicAttack(enemy, player);
console.ShowAttackResult("Player", "Monster", playerDamage);
console.ShowAttackResult("Monster", "Player", enemyDamage);

