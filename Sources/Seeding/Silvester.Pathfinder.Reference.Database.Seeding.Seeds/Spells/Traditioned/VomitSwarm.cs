using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class VomitSwarm : Template
    {
        public static readonly Guid ID = Guid.Parse("7b5a076e-72a8-46e6-9263-83ff5a861433");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Vomit Swarm",
                Level = 2,
                Area = "30-foot cone.",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ea50d52f-0149-43b9-a551-d495594b9097"), Type = TextBlockType.Text, Text = "You belch forth a swarm of magical vermin. You evoke and shape the creatures from your own imagination, allowing you to change the appearance of the creatures (typically a mix of centipedes, roaches, wasps, and worms), but this doesn't change the effect of the spell. The vermin swarm over anyone in the area, their bites and stings dealing 2d8 piercing damage (basic Reflex save). A creature that fails its saving throw also becomes sickened 1. Once the spell ends, the swarm disappears." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("fb269ad8-1f4f-4490-995f-cdd0344617a3"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("e2a4238b-911e-4afa-9449-70c62e230ad2"), Type = TextBlockType.Text, Text = "Increase the damage by 1d8." }
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
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Primal.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("437b21e7-c627-49df-8915-ccb3aba4fe1b"), Traits.Instances.Evocation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("26b951e3-b2a9-4e7b-93af-c1cba0dc0139"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 227
            };
        }
    }
}
