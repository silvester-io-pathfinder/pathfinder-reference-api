namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Instances
{
    public class GainSpecificSpellSlotEffect : Effect
    {
        public int Amount { get; set; }
        public int Level { get; set; }
        public bool IsSpendingPreventable { get; set; }
    }
}
