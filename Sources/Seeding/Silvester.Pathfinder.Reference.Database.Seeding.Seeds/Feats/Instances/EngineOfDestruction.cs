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
    public class EngineOfDestruction : Template
    {
        public static readonly Guid ID = Guid.Parse("9a550721-4f42-4d4b-a197-b627fb1cf56e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Engine of Destruction",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("07c5c32a-d433-475c-840f-f00b5c9d050f"), Type = TextBlockType.Text, Text = $"Your construct unleashes a broad swath of devastation by separating its limbs, deploying hidden armaments, or using a similar technique to wreak havoc. You Command your innovation. Instead of its normal actions, it {ToMarkdownLink<Models.Entities.Action>("Strides", Actions.Instances.Stride.ID)} once, then makes a {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against each foe within 30 feet of it with a +2 circumstance bonus to its attack rolls. The multiple attack penalty doesn't increase until after the construct makes all the attacks." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInnovation(Guid.Parse("367d459e-abe8-4e98-8727-dcbc99f0555b"), Innovations.Instances.Construct.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("fc3f624e-ae06-4687-9ab5-5c18964cd450"), Traits.Instances.Inventor.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9b96c896-e345-4024-9ee7-b896c4b5bf4e"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
