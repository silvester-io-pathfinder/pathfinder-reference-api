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
    public class Skitter : Template
    {
        public static readonly Guid ID = Guid.Parse("fa38f86b-ad08-4d0a-a555-5aa37762cbf1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Skitter",
                Level = 3,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4fc4abad-5de1-40e5-bcfe-3e515baf696f"), Type = TextBlockType.Text, Text = $"You can scoot swiftly across the ground. You can {ToMarkdownLink<Models.Entities.Action>("Crawl", Actions.Instances.Crawl.ID)} up to half your Speed." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("fe5c8360-01a6-438c-afc9-07836aff3e68"), requiredStatValue: 16, Stats.Instances.Dexterity.ID);
            builder.HaveSpecificFeat(Guid.Parse("8aea2908-f4eb-4c16-81a8-833e240f97b1"), Feats.Instances.Fleet.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("915465c4-aeec-46a8-85e3-0925bc2fcfb2"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
