using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Message : Template
    {
        public static readonly Guid ID = Guid.Parse("d1e5c7ca-1ebb-4168-ba75-4a8f1951a63b");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Message",
                Level = 1,
                Range = "120 feet.",
                Duration = "1 round.",
                Targets = "1 creature.",
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e8e6ca9e-564b-4320-bb83-8cfa32076ffb"), Type = TextBlockType.Text, Text = "You mouth words quietly, but instead of coming out of your mouth, they’re transferred directly to the ears of the target. While others can’t hear your words any better than if you normally mouthed them, the target can hear your words as if they were standing next to you. The target can give a brief response as a reaction, or as a free action on their next turn if they wish, but they must be able to see you and be within range to do so. If they respond, their response is delivered directly to your ear, just like the original message." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("bf5af306-92a2-4732-bb41-0978ab3a5542"), 
                Level = "3rd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("afe59c36-1ec9-49e9-ae0d-ee1d533991d6"), Type = TextBlockType.Text, Text = "The spell’s range increases to 500 feet." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Auditory.ID;
            yield return Traits.Instances.Cantrip.ID;
            yield return Traits.Instances.Illusion.ID;
            yield return Traits.Instances.Linguistic.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("99a2b237-1ea4-4cf9-b973-57f2d80ff29b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 351
            };
        }
    }
}
