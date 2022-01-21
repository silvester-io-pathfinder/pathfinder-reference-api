using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class HealCompanion : Template
    {
        public static readonly Guid ID = Guid.Parse("8fddb4d4-0f53-465e-8995-00671c2e9806");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Heal Companion",
                Level = 1,
                Range = "Touch or 30 feet.",
                Targets = "Your animal companion.",
                ActionTypeId = ActionTypes.Instances.OneOrTwoActions.ID,
                ClassId = Classes.Instances.Ranger.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("062e69ff-671b-4c15-9f6b-d11232cc2990"), Type = TextBlockType.Text, Text = "You harness positive energy to heal your animal companion's wounds. You restore 1d10 Hit Points to your animal companion. The number of actions you spend Casting this Spell determines range and other parameters." };
            yield return new TextBlock { Id = Guid.Parse("34002694-962c-4aa6-a3e0-565b6f3ffad8"), Type = TextBlockType.Enumeration, Text = "[one-action] Somatic - The spell has a range of touch." };
            yield return new TextBlock { Id = Guid.Parse("2bc41f04-e8e2-4212-afef-4f1fb3e47645"), Type = TextBlockType.Enumeration, Text = "[two-actions] Verbal - The spell has a range of 30 feet and restores an additional 8 Hit Points to the target." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("06e70b25-ae9e-4968-8520-2cb5e6ceaae9"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("7b5c32be-32b7-418a-b1ec-23254894adea"), Type = TextBlockType.Text, Text = "The amount of healing increases by 1d10, and the additional healing for the 2-action version increases by 8." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield break;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("43d19cb8-88a9-48b3-a7b6-36735ac4c049"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("61728087-55bb-480d-bc2c-cdcff441d263"), Traits.Instances.Healing.ID);
            builder.Add(Guid.Parse("bf6964ad-eb17-4e08-94e8-5c2e9e31c456"), Traits.Instances.Necromancy.ID);
            builder.Add(Guid.Parse("dba1d7ea-f734-4742-a8ab-5497d498e4a5"), Traits.Instances.Positive.ID);
            builder.Add(Guid.Parse("020502b4-c6c5-4868-bd36-c58c40e4c058"), Traits.Instances.Ranger.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cf26af3c-54c2-48e6-b9bd-9b2b475dfe75"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 234
            };
        }
    }
}
