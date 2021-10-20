namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Instances
{
    public class ModifyAnySavingThrowEffect : Effect
    {
        public RollResult InitialResult { get; set; }
        public RollResult Becomes { get; set; }
    }
}
