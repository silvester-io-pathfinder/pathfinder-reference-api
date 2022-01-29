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
    public class Skyseeker : Template
    {
        public static readonly Guid ID = Guid.Parse("e02ca66f-da97-4303-8a7c-9d6ad14ddc44");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Skyseeker",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("86b809c0-f162-42b6-9517-21f2e941ca14"), Type = TextBlockType.Text, Text = $"You {ToMarkdownLink<Models.Entities.Action>("Leap", Actions.Instances.Leap.ID)} toward an opponent. At any point in the {ToMarkdownLink<Models.Entities.Action>("Leap", Actions.Instances.Leap.ID)}, you can make a single {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against a creature within your reach." };
            yield return new TextBlock { Id = Guid.Parse("ebe56f81-ef94-4f99-83e3-fb08b04ac81a"), Type = TextBlockType.Text, Text = $"At 12th level, if you hit with this {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}, instead of finishing your {ToMarkdownLink<Models.Entities.Action>("Leap", Actions.Instances.Leap.ID)}, you can immediately attempt a second {ToMarkdownLink<Models.Entities.Action>("Leap", Actions.Instances.Leap.ID)} from the space where you struck the target of your {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}. You can make a single {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against a target within your reach during this second {ToMarkdownLink<Models.Entities.Action>("Leap", Actions.Instances.Leap.ID)} as well." };
            yield return new TextBlock { Id = Guid.Parse("227a83a8-b919-41e3-bb88-d9970292250b"), Type = TextBlockType.Text, Text = $"At 16th level, you can attempt a third {ToMarkdownLink<Models.Entities.Action>("Leap", Actions.Instances.Leap.ID)} if your second {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} hits, and you can attack a target at any point during this third {ToMarkdownLink<Models.Entities.Action>("Leap", Actions.Instances.Leap.ID)}." };
            yield return new TextBlock { Id = Guid.Parse("e4327c67-2bbe-4e2c-9c46-d1c6b9508ad3"), Type = TextBlockType.Text, Text = $"All {ToMarkdownLink<Models.Entities.Action>("Leaps", Actions.Instances.Leap.ID)} made during this activity gain a +10-foot status bonus to the total height or distance of your leap, and no two {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} can target the same creature." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("d2b968ef-d4ad-44e7-9688-180b5ede8111"), Feats.Instances.SkyAndHeavenStance.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c4030a05-174a-48e3-9ee8-2942f70a152b"),
                SourceId = Sources.Instances.AgentsOfEdgewatch.ID,
                Page = -1
            };
        }
    }
}
