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
    public class UnnervingProwess : Template
    {
        public static readonly Guid ID = Guid.Parse("9176d12a-4654-4b1e-8d1b-abcb7cadc80c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unnerving Prowess",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You critically succeed at a Strike or Disarm with your Aldori dueling sword.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("965a67ac-0037-4893-b8d5-cb0ebb636261"), Type = TextBlockType.Text, Text = $"Your incredible skill with your blade unnerves your foes. You attempt to {ToMarkdownLink<Models.Entities.SkillAction>("Demoralize", SkillActions.Instances.Demoralize.ID)} the target of your {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} or {ToMarkdownLink<Models.Entities.SkillAction>("Disarm", SkillActions.Instances.Disarm.ID)}. This {ToMarkdownLink<Models.Entities.SkillAction>("Demoralize", SkillActions.Instances.Demoralize.ID)} attempt does not have the {ToMarkdownLink<Models.Entities.Trait>("auditory", Traits.Instances.Auditory.ID)} trait, nor do you take a penalty to the check if the target doesn't understand your language." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("73132c8e-784a-459a-bb87-2c9f6db8bd93"), Feats.Instances.AldoriDuelistDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ed315d5d-3281-43da-8c3a-3ea61133f4c8"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
