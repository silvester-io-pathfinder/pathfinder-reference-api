using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Scrying : Template
    {
        public static readonly Guid ID = Guid.Parse("a6a36041-739b-4107-b7fe-a00d7790f455");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Scrying",
                Level = 6,
                CastTime = "10 minutes.",
                Range = "Planetary.",
                IsDismissable = true,
                Duration = "Sustained up to 10 minutes.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c8f0078c-8b19-4296-97ae-b61d090689a8"), Type = TextBlockType.Text, Text = "You magically spy on a creature of your choice. Scrying works like clairvoyance (page 324), except that the image you receive is less precise, insufficient for teleport and similar spells. Instead of creating an eye in a set location within 500 feet, you instead create an eye that manifests just above the target. You can choose a target either by name or by touching one of its possessions or a piece of its body. If you haven’t met the target in person, scrying’s DC is 2 lower, and if you are unaware of the target’s identity (perhaps because you found an unknown creature’s fang at a crime scene), the DC is instead 10 lower." };
            yield return new TextBlock { Id = Guid.Parse("320fedd5-e8a7-458b-8e5d-0807ecf72343"), Type = TextBlockType.Text, Text = "The effect of scrying depends on the target’s Will save." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("f9a064c1-aa84-4a18-8070-bd215138b6b0"),
                CriticalSuccess = "The spell fails and the target is temporarily immune for 1 week. The target also gains a glimpse of you and learns its rough distance and direction from you.",
                Success = "The spell fails and the target is temporarily immune for 1 day.",
                Failure = "The spell succeeds.",
                CriticalFailure = "The spell succeeds, and the eye follows the target if it moves, traveling up to 60 feet per round."
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Divination.ID;
            yield return Traits.Instances.Scrying.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("048aa3b9-150c-437e-b335-1d7c516d2497"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 367
            };
        }
    }
}
