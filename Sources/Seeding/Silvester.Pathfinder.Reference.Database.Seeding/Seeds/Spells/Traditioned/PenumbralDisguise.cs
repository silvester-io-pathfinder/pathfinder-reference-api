using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{

    public class PenumbralDisguise : Template
    {
        public static readonly Guid ID = Guid.Parse("e72b47a0-a79a-4c97-9027-2fa02ce04f61");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Penumbral Disguise",
                Level = 2,
                Range = "Touch.",
                Targets = "1 willing creature.",
                Duration = "10 minutes.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f5bb3eca-ca29-4e8d-8d40-1ca785ad3374"), Type = TextBlockType.Text, Text = "You wrap the target in shadows, granting them a +1 status bonus to Stealth checks to Hide while in dim light or darkness. In addition, the shadows mask the creature's features. While the creature is in dim light or darkness, other creatures must succeed at a Seek action against the spell's DC to discern details about the target's appearance. For example, without using Seek, other creatures can determine the target's general shape (such as humanoid), but they would need to Seek to determine the target's precise appearance or any other identifying information. Creatures with darkvision can still see the target and their features normally. The target's normal appearance is revealed in bright light." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("f8d075b7-70ca-4b7b-87a9-1cc3131915dc"),
                Level = "4th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("c0231f54-1b6c-4485-b9f9-7efe48fb3754"), Type = TextBlockType.Text, Text = "The status bonus is +2. Creatures with darkvision can no longer discern details about the target while the target is in dim light or darkness without Seeking, though creatures with greater darkvision can still determine these details." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("55903fc9-8057-4cb7-9efd-b66f6ced2f14"),
                Level = "6th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("e82d8f19-652f-4219-80fe-59b282d7ceec"), Type = TextBlockType.Text, Text = "As 4th level, except the status bonus is +3 and creatures without darkvision can't determine even general details about the target while the target is in dim light or darkness unless they successfully Seek the target; these creatures see a vague shadow instead. Even on a successful Seek, they only determine general features, though they can see details on a critical success." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("75d8c73b-81fa-42cb-be83-3226df58c5e5"),
                Level = "6th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("ff80bbc3-d111-4779-8743-100cd6181e52"), Type = TextBlockType.Text, Text = "As 6th level, except the status bonus is +4 and even creatures with greater darkvision must Seek to discern details about the target while the target is in dim light or darkness." }
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Illusion.ID;
            yield return Traits.Instances.Shadow.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("81d9b9ac-1c83-4b5d-8c78-9ec338e10f7e"),
                SourceId = Sources.Instances.Pathfinder172.ID,
                Page = 77
            };
        }
    }
}
