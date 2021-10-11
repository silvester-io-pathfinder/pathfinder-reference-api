namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Instances
{
    public class FreeAbilityBoostEffect : Effect
    {
        public bool IsChosenByGameMaster { get; set; } = false;
        public string? Restrictions { get; set; }
    }
}
