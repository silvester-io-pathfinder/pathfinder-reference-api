using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MountainsStoutness : Template
    {
        public static readonly Guid ID = Guid.Parse("8fbc875f-1ab2-458b-89d1-d7bd21db4fc6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mountain's Stoutness",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2e350670-8737-4fd8-80b5-decd237af17d"), Type = TextBlockType.Text, Text = $"Your hardiness lets you withstand more punishment than most before going down. Increase your maximum Hit Points by your level. When you have the dying condition, the DC of your recovery checks is equal to 9 + your dying value (instead of 10 + your dying value)." };
            yield return new TextBlock { Id = Guid.Parse("e04266f9-f637-4c80-8f1e-81c74e329e18"), Type = TextBlockType.Text, Text = $"If you also have the {ToMarkdownLink<Models.Entities.Feat>("Toughness", Feats.Instances.Toughness.ID)} feat, the Hit Points gained from it and this feat are cumulative, and the DC of your recovery checks is equal to 6 + your dying value." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("c0921b2e-fcfc-45fb-bbbf-8d061b994e26"), Traits.Instances.Dwarf.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4513ebdf-c4ab-4a31-a140-c81cfe71f99c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
