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
    public class LungingStance : Template
    {
        public static readonly Guid ID = Guid.Parse("225b3c94-2256-408d-8db8-51cd1d736aba");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lunging Stance",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5db3f2a1-c6ab-496c-9abc-e6edc59c3d2a"), Type = TextBlockType.Text, Text = $"Your body coiled to strike, you can lash out at distant enemies." };
            yield return new TextBlock { Id = Guid.Parse("2fec8514-989c-440a-82b3-5c15a3af2ac3"), Type = TextBlockType.Text, Text = $"While you are in this stance, you can use {ToMarkdownLink<Models.Entities.Feat>("Attack of Opportunity", Feats.Instances.AttackOfOpportunity.ID)} against a creature that is outside your reach but within the reach you would have with a {ToMarkdownLink<Models.Entities.Feat>("Lunge", Feats.Instances.Lunge.ID)}. If you do, you increase your range with the {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} by 5 feet." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7910cfc8-7340-4759-b43f-c3b8eeba939b"), Feats.Instances.AttackOfOpportunity.ID);
            builder.HaveSpecificFeat(Guid.Parse("e9c79562-79de-4ecb-8d53-e77bc9b056ea"), Feats.Instances.Lunge.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Fighter.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Stance.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("77f64d04-2c79-49e5-b646-e60cef4069a7"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
