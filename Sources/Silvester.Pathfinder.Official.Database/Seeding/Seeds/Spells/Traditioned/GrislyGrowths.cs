using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class GrislyGrowths : Template
    {
        public static readonly Guid ID = Guid.Parse("f029e544-0b60-4ea9-9278-279be637acb1");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Grisly Growths",
                Level = 5,
                Range = "60 feet.",
                Targets = "1 corporeal creature.",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e42c2058-a63c-4882-8130-a75a6b3b827c"), Type = TextBlockType.Text, Text = "This gruesome spell causes the target to grow excess limbs and organs, whether it be fingers multiplying until hands resemble bushes, eyes popping open in bizarre places, legs sprouting from the side of the body, or some other result. The target takes 10d6 piercing damage (basic Fortitude save) as the new features erupt. This spell has no effect on a target with a mutable anatomy or no limbs, such as an ooze or a protean. The growths rot rapidly and fall away after 1 round." };
            yield return new TextBlock { Id = Guid.Parse("4e966edd-acbd-46ab-b5f7-8ba038a751d1"), Type = TextBlockType.Text, Text = "In addition, unless the initial target critically succeeds, creatures within 30 feet of the target, including the target, must attempt Will saves, after which they are temporarily immune to this secondary effect of grisly growths for 1 hour. This additional effect is a mental and visual effect." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("da3aec22-fe4a-4b03-a4fb-96b1dd2babc0"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("52247ca9-4528-479c-82f2-e9b9b2c23059"), Type = TextBlockType.Text, Text = "The damage increases by 2d6." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("13777386-f4f9-44ef-8a48-d8afe3361718"),
                Success = "The creature is unaffected.",
                Failure = "The creature is sickened 1.",
                CriticalFailure = "The character is sickened 2."
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

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("36aa3579-6e72-426c-a470-c34fc2a4add7"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 220
            };
        }
    }
}
