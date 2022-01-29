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
    public class ConstructShell : Template
    {
        public static readonly Guid ID = Guid.Parse("1efae1fc-4155-491f-a4e7-07213bac924c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Construct Shell",
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
            yield return new TextBlock { Id = Guid.Parse("da38f9ae-b9c6-4d1b-8939-29df044f75c0"), Type = TextBlockType.Text, Text = $"You've adjusted your construct innovation so that when you ride it, special plates, hollows, or similar form partial barriers around you to add additional protection. You have lesser cover from all attacks when mounted on your construct innovation, not just from attacks where the construct would be in the way. Additionally, if your construct uses an emanation while you're riding on it, such as {ToMarkdownLink<Models.Entities.ClassFeature>("Explode", ClassFeatures.Inventors.Explode.ID)}, you can choose not to be affected by the emanation." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInnovation(Guid.Parse("97a7dd73-8d55-481d-a2a6-27f852a0e60d"), Innovations.Instances.Construct.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("de73cbbc-0638-4b7c-bd11-2a7719bbf4c7"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
