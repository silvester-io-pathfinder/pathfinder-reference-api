using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Augury : Template
    {
        public static readonly Guid ID = Guid.Parse("cfb3f479-70d2-4275-890f-27920ec70d3d");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Augury",
                Level = 2,
                CastTime = "10 minutes.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("252c9500-8bda-4a59-ab54-fec870f557e9"), Type = Utilities.Text.TextBlockType.Text, Text = "You gain a vague glimpse of the future. During the casting of this spell, ask about the results of a particular course of action." };
            yield return new TextBlock { Id = Guid.Parse("7f34d0c1-10ae-4937-a9fb-aae94c21ff6e"), Type = Utilities.Text.TextBlockType.Text, Text = "The spell can predict results up to 30 minutes into the future and reveals the GM's best guess among the following outcomes:" };
            yield return new TextBlock { Id = Guid.Parse("62aac3fd-dc88-4275-b479-964d0e390ef0"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "Weal: The results will be good." };
            yield return new TextBlock { Id = Guid.Parse("a360bbe1-1f56-4bac-b1b5-a8dab82d5659"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "Woe: The results will be bad." };
            yield return new TextBlock { Id = Guid.Parse("ef5d40a9-0203-48f4-9744-f411c7a97342"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "Weal and Woe: The results will be a mix of good and bad." };
            yield return new TextBlock { Id = Guid.Parse("ba4c847a-4c45-4d7b-adb4-41a03b562606"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "Nothing: There won't be particularly good or bad results." };
            yield return new TextBlock { Id = Guid.Parse("702a5b5e-0fad-48db-b126-02b58069b5f7"), Type = Utilities.Text.TextBlockType.Text, Text = "The GM rolls a secret DC 6 flat check. On a failure, the result is always “nothing.” This makes it impossible to tell whether a “nothing” result is accurate. If anyone asks about the same topic as the first casting of augury during an additional casting, the GM uses the secret roll result from the first casting. If circumstances change, though, it's possible to get a different result." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("94948ef8-a884-46a4-9177-a3586cf589e4"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("7b21c024-c123-4fde-97b8-8248d3f87d6a"), Traits.Instances.Prediction.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("66e638db-9c76-4ba9-b699-e79bf55f5b8b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 318
            };
        }
    }
}
