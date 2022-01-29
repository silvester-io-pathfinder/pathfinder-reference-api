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
    public class DefyDeath : Template
    {
        public static readonly Guid ID = Guid.Parse("70118e61-f9b4-480a-9210-af51086af8c5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Defy Death",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6747a396-d15f-406f-af35-970c56338c95"), Type = TextBlockType.Text, Text = $"You're exceptionally difficult to kill. The DC of your recovery checks is equal to 9 + your dying value, or 8 + your dying value if you have the {ToMarkdownLink<Models.Entities.Feat>("Toughness", Feats.Instances.Toughness.ID)} general feat. In addition, whenever someone returns you to life using magic that would normally leave you debilitated for a week (such as {ToMarkdownLink<Models.Entities.Spell>("raise dead", Spells.Instances.RaiseDead.ID)} or the resurrect ritual), you don't suffer that condition." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1240fdbf-42b7-44ca-898c-33b8be66e850"), Feats.Instances.OrcFerocity.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("addbf176-b066-47e6-ad51-6c90186fb14d"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
