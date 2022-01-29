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
    public class ExtendArmamentAlignment : Template
    {
        public static readonly Guid ID = Guid.Parse("15d740e2-fcff-48f9-8f0b-5a7179322068");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Extend Armament Alignment",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("94b2a4c4-21fc-4b3d-a68f-61f975b7456c"), Type = TextBlockType.Text, Text = $"The alignment you impose on a weapon lasts much longer. The duration of {ToMarkdownLink<Models.Entities.Feat>("Align Armament", Feats.Instances.AlignArmament.ID)} increases to 1 minute." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("bb9d68ba-aea0-48ef-9764-45708027d08d"), Feats.Instances.AlignArmament.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Cleric.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2c2b481a-ffaf-4f39-b106-61304bc9a4cc"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
