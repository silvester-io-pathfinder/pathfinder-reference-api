using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class MaliciousShadow : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Malicious Shadow",
                Level = 3,
                Range = "30 feet.",
                Targets = "1 creature.",
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Witch.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You reshape the target’s shadow into a deadly form, such as strangling hands, a dangerous weapon, harrying runes, or the like, and command it to attack the target. When you Cast the Spell, and each time you Sustain the Spell, the shadow makes a Strike against the target. The shadow moves along with the foe, always remaining within reach. If you Sustain the Spell multiple times in a round, you gain this effect each time. The shadow uses and contributes to your multiple attack penalty." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The shadow’s Strikes are melee spell attacks. Regardless of its shape, the shadow’s Strikes deal damage equal to 1d10 plus your spellcasting ability modifier. You choose the type of damage when you Cast the Spell, choosing from bludgeoning, piercing, or slashing damage. The shadow doesn’t take up space, grant flanking, or have any other attributes a creature would. The shadow can’t make any attacks other than its Strike." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The shadow vanishes if the target moves into an area of complete darkness or enters an area with light from all directions such that the target doesn’t cast a shadow. If another effect is controlling the target’s shadow when you cast malicious shadow, you can attempt to counteract that effect to temporarily take control of the shadow, but the original effect resumes when malicious shadow ends." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse(""),
                Level = "+2",
                Details =
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The Strike damage increases by 1d10." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Hex.ID;
            yield return Traits.Instances.Shadow.ID;
            yield return Traits.Instances.Witch.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 238
            };
        }
    }
}
