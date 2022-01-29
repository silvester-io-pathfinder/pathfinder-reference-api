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
    public class SpiritualSense : Template
    {
        public static readonly Guid ID = Guid.Parse("43b060d5-38d9-43ae-97da-6d828eaee940");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Spiritual Sense",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("01db6380-e830-4c29-917a-7541212cd343"), Type = TextBlockType.Text, Text = $"You have a vague connection to the Ethereal Plane that enables you to notice spirits. While you're exploring but not {ToMarkdownLink<Models.Entities.Activity>("Searching", Activities.Instances.Search.ID)}, the GM rolls a secret check for you to find haunts that usually require {ToMarkdownLink<Models.Entities.Activity>("Searching", Activities.Instances.Search.ID)}, as well as spirits, creatures on the Ethereal Plane, and beings made entirely of spiritual essence such as celestials, fiends, and monitors." };
            yield return new TextBlock { Id = Guid.Parse("1f520b73-1430-4bf7-a6c2-c897333f263d"), Type = TextBlockType.Text, Text = $"You can also potentially notice ethereal creatures and spirits inside solid objects, provided they are within 30 feet of you. This applies while {ToMarkdownLink<Models.Entities.Activity>("Searching", Activities.Instances.Search.ID)}, while {ToMarkdownLink<Models.Entities.Action>("Seeking", Actions.Instances.Seek.ID)}, and on the automatic secret check you gain while exploring even if you aren't {ToMarkdownLink<Models.Entities.Activity>("Searching", Activities.Instances.Search.ID)}. You can still notice spirits only on a successful check, and you can't see them if they're more than 5 feet inside an object." };
            yield return new TextBlock { Id = Guid.Parse("e06b7482-ee65-4df7-97a8-62e7617fb90b"), Type = TextBlockType.Text, Text = $"When you notice a creature with your Spiritual Sense, you also learn its location, making it hidden to you if it had been undetected." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("6320a35c-297c-4dfe-83a3-5ec5b8578c0a"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("d6c7ab37-8e5d-4075-81c8-421f1391c68d"), Traits.Instances.Divine.ID);
            builder.Add(Guid.Parse("6e3aff26-264a-4757-ba25-e32ad8980bfa"), Traits.Instances.Oracle.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e13edd4f-ddc5-4f93-aa4b-fd2c123da70f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
