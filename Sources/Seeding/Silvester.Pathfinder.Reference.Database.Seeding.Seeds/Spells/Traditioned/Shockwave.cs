using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Shockwave : Template
    {
        public static readonly Guid ID = Guid.Parse("3a68447f-d18b-42d0-8b43-0113d76c2bab");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Shockwave",
                Level = 1,
                Area = "15-foot cone.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("70b3bcad-d636-4029-8954-0a78b2aa57a6"), Type = TextBlockType.Text, Text = "You create a wave of energy that ripples through the earth. Terrestrial creatures in the affected area must attempt a Reflex save to avoid stumbling as the shockwave shakes the ground." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("e806f8cb-3367-4a47-bac3-e77fcdf3c29a"),
                Level = "+1",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("287346f4-750a-41ac-864b-1005d65a068e"), Type = TextBlockType.Text, Text = "The area increases by 5 feet (to a 20-foot cone at 2nd level, and so on)." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("15a7b07a-d346-43b3-bff0-10d5b2c9123c"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature is flat-footed until the start of its next turn.",
                Failure = "The creature falls prone.",
                CriticalFailure = "As failure, plus the creature takes 1d6 damage."
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
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("804f1fda-0e15-4e96-b300-8d914706257f"), Traits.Instances.Earth.ID);
            builder.Add(Guid.Parse("d2131700-bd58-4a6c-b87a-bb6fbed43a2a"), Traits.Instances.Evocation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3c19e04a-7f11-4d53-ac88-1e615b246fa1"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 110
            };
        }
    }
}
