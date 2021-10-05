using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class IceStorm : Template
    {
        public static readonly Guid ID = Guid.Parse("856ea565-22c6-4106-b69a-57471fd7c315");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Ice Storm",
                Level = 4,
                Range = "120 feet.",
                Area = "5-foot burst.",
                Duration = "1 minute.",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("670a6062-1614-4924-a8ed-a52b0a1b425c"), Type = TextBlockType.Text, Text = "You create a gray storm cloud that pelts creatures with an icy deluge. When you Cast the Spell, a burst of magical hail deals 2d8 bludgeoning damage and 2d8 cold damage to each creature in the area below the cloud (basic Reflex save). Snow and sleet continue to rain down in the area for the remainder of the spell’s duration, making the area difficult terrain, causing creatures in the storm to be concealed, and making creatures outside the storm concealed from those inside the storm. Any creature that ends its turn in the storm takes 4 cold damage. If you Cast this Spell outdoors, you can create two non-overlapping clouds instead of one." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("a8b47787-7b5e-4ff8-84be-7f35f00a3469"), 
                Level = "+2",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("10ec79f9-195a-458d-8266-504326b1ccec"), Type = TextBlockType.Text, Text = "The initial bludgeoning damage and cold damage increase by 1d8 each, and the cold damage creatures take at the end of their turns increases by 2." }
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
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Cold.ID;
            yield return Traits.Instances.Evocation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ef33473b-8a23-42c7-bbfa-2d247102ab72"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 220
            };
        }
    }
}
