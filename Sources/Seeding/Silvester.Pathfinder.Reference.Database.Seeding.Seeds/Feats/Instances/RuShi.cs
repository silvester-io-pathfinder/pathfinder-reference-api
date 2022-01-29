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
    public class RuShi : Template
    {
        public static readonly Guid ID = Guid.Parse("089ad686-549b-4e59-8e2d-83b3455e876a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ru-Shi",
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
            yield return new TextBlock { Id = Guid.Parse("2c729da6-f117-4b4f-913b-b91868adf060"), Type = TextBlockType.Text, Text = $"You were born to a jiang-shi, one of the so-called hopping vampires found most often in Tian-Xia. Your parent had a supernatural obsession with counting small objects, which manifests in you as a preternatural gift for linguistics and mathematics. You are trained in Society and gain the {ToMarkdownLink<Models.Entities.Feat>("Eye for Numbers", Feats.Instances.EyeForNumbers.ID)} skill feat. If you would automatically become trained in Society (from your background or class, for example), you instead become trained in a skill of your choice." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Dhampir.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Lineage.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6765c2da-9d8c-4fe1-bb30-a21175eeaa28"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
