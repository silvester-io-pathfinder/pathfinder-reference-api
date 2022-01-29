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
    public class Cackle : Template
    {
        public static readonly Guid ID = Guid.Parse("dbbb6643-90c5-4f68-bb42-59586ea91197");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cackle",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2cfbc418-45a0-441c-b92f-7ac1103ed1bc"), Type = TextBlockType.Text, Text = $"You can extend one of your spells with a quick burst of laughter. You learn the {ToMarkdownLink<Models.Entities.Spell>("cackle", Spells.Instances.Cackle.ID)} hex. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Witch.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4228c7b3-9efd-45d6-95b9-66bf5ddc4a47"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
