using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class UnrelentingObservation : Template
    {
        public static readonly Guid ID = Guid.Parse("9571af05-9123-4ee5-a0bc-a76d56da3e71");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Unrelenting Observation",
                Level = 8,
                Range = "100 feet.",
                Area = "20-foot burst.",
                Duration = "Varies",
                Targets = "1 creature or object tracked and up to 5 other willing creatures.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9571af05-9123-4ee5-a0bc-a76d56da3e71"), Type = TextBlockType.Text, Text = "This spell grants perfect sight based on scrying, allowing several willing targets to track the exact movements or position of one creature or object. Choose one target creature or object in the area to be tracked. It becomes the sensor for the spell. Up to five willing creatures of your choice in the area can see a ghostly image of this creature or object when it’s out of their sight. They can perceive the creature or object perfectly, allowing them to ignore the concealed or invisible condition, though physical barriers still provide cover." };
            yield return new TextBlock { Id = Guid.Parse("9571af05-9123-4ee5-a0bc-a76d56da3e71"), Type = TextBlockType.Text, Text = "The tracking creatures can see the tracked creature or object through all barriers other than lead or running water, which block their vision. Distance doesn’t matter, though the creature or object might move so far away it becomes too small to perceive. The tracking creatures don’t see any of the environment around the target, though they do see any gear a creature is wearing or holding, and they can tell if it removes objects from its person." };
            yield return new TextBlock { Id = Guid.Parse("9571af05-9123-4ee5-a0bc-a76d56da3e71"), Type = TextBlockType.Text, Text = "If the target to be tracked is willing, the duration is 1 hour. If you try to track an unwilling creature, the target must attempt a Will save." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("9571af05-9123-4ee5-a0bc-a76d56da3e71"),
                CriticalSuccess = "The creature or object is unaffected.",
                Success = "As described, and the duration is 1 minute.",
                Failure = "As described, and the duration is 1 hour.",
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Divination.ID;
            yield return Traits.Instances.Scrying.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9571af05-9123-4ee5-a0bc-a76d56da3e71"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 379
            };
        }
    }
}
