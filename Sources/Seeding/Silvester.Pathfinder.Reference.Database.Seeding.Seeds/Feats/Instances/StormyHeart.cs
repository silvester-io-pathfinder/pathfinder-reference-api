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
    public class StormyHeart : Template
    {
        public static readonly Guid ID = Guid.Parse("22e0afde-bb02-4dd4-a48e-dc750da08ae9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Stormy Heart",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8b1c4319-f3d5-47a2-beb0-2448f6fb1a3c"), Type = TextBlockType.Text, Text = $"The elemental power in your blood is a raging storm. You can {ToMarkdownLink<Models.Entities.Feat>("Invoke the Elements", Feats.Instances.InvokeTheElements.ID)} with a frequency of once per 10 minutes, rather than once per day." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2731955f-0066-4dd7-aa19-f93aa8add43e"), Feats.Instances.InvokeTheElements.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("99ad638e-5169-4616-b712-84d10f438853"), Traits.Instances.Changeling.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ec67d75c-be90-47a6-b54a-d1440681577e"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
