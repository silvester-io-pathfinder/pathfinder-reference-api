using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class Quench : Template
    {
        public static readonly Guid ID = Guid.Parse("88ce9924-4af8-4bef-9e32-487063854cb6");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Quench",
                Level = 2,
                Range = "120 feet.",
                Area = "20-foot burst.",
                IsDismissable = true,
                Duration = "Sustained.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ffae1f80-35a5-49ef-9e5b-3363e621cc46"), Type = TextBlockType.Text, Text = "You cause the air in the area to become supersaturated with water vapor. Non-magical fires within the area are automatically extinguished. Fire creatures within the area take 4d8 damage (basic Fortitude save). Choose one magical fire, fire spell, or fire item in the area and attempt to counteract it. If you succeed against an item, the item loses its fire properties for 10 minutes (for instance, a +1 flaming longsword would become a +1 longsword). If the target is an artifact or similarly powerful item, you automatically fail to counteract it." };
            yield return new TextBlock { Id = Guid.Parse("7f54bf14-43eb-4582-ace0-2a41a21ea46a"), Type = TextBlockType.Text, Text = "When you Sustain this Spell, you can move the area of vapor anywhere within range, but the only effect when you do so is to automatically extinguish non-magical fires." };
            yield return new TextBlock { Id = Guid.Parse("90ad2eab-c5ed-4c79-b7ae-3c0431a5b955"), Type = TextBlockType.Text, Text = "If you have the Counterspell reaction, you can use quench to counter any spell with the fire trait instead of needing to have the triggering fire spell prepared or in your repertoire." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("a3e82f9e-5678-45fd-90d9-1a82df97c07b"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("afb1d17e-49e9-4a33-8ef8-db09464601fe"), Type = TextBlockType.Text, Text = "Increase the damage to fire creatures by 2d8." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Abjuration.ID;
            yield return Traits.Instances.Water.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9ccdfa2d-1fec-46a5-8a10-6abd5b7042ab"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 223
            };
        }
    }
}
