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
    public class ScoutsCharge : Template
    {
        public static readonly Guid ID = Guid.Parse("be03bca7-f3b4-4a22-903f-32f76db83bae");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Scout's Charge",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("025e5039-5f6d-4b64-893f-94167eab6d92"), Type = TextBlockType.Text, Text = $"You meander around unpredictably, and then ambush your opponents without warning. Choose one enemy. {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)}, {ToMarkdownLink<Models.Entities.SkillAction>("Feint", SkillActions.Instances.Feint.ID)} against that opponent, and then make a {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against that foe. For your {ToMarkdownLink<Models.Entities.SkillAction>("Feint", SkillActions.Instances.Feint.ID)}, you can attempt a Stealth check instead of the Deception check that's usually required, because you use the terrain around you to catch your foe off-guard." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("fc30612a-828b-486b-9cfb-40a1c6ee11b9"), Feats.Instances.ScoutDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("0e43f429-625f-41d3-a8c6-5da39dec5c7e"), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse("a999bc8e-51f1-4133-80ce-23e0e4efa14c"), Traits.Instances.Flourish.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("02d01dd4-290e-44a2-8f0b-c0152aba2665"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
