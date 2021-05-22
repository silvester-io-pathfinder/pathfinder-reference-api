using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class LightningStorm : Template
    {
        public static readonly Guid ID = Guid.Parse("85044b94-8c53-4d9f-8be4-64fdb38c9ac1");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Lightning Storm",
                Level = 5,
                Range = "120 feet.",
                Area = "5-foot burst.",
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("41794c01-bc1b-480f-9b54-6b852bdf60d1"), Type = TextBlockType.Text, Text = "You create a black, rumbling storm cloud and call down one lightning bolt. The bolt is a vertical line from the storm cloud to the ground below, dealing 4d12 electricity damage to creatures in the spell’s area (basic Reflex save). The first time you Sustain the Spell each round, you can call another lightning bolt within the area. If you Cast this Spell outdoors, you can create two non-overlapping clouds instead of one, though you can still call down only one bolt per turn." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("6ea8c400-38f4-43e2-b223-a64bf7d5445e"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("aa0799c1-0a3b-48bb-9136-a02016ddab46"), Type = TextBlockType.Text, Text = "The damage of each bolt increases by 1d12." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Electricity.ID;
            yield return Traits.Instances.Evocation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("029601a5-2f71-4770-82a9-9279c6fc8518"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 221
            };
        }
    }
}
