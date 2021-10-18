namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Instances
{
    public class ModifyWeaponDamageEffect : Effect
    {
        public int Modifier { get; set; }
        public ModifierType ModifierType { get; set; }
    }
}
