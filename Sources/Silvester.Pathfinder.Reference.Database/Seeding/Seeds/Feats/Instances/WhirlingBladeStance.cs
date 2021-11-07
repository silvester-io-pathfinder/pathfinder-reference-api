using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WhirlingBladeStance : Template
    {
        public static readonly Guid ID = Guid.Parse("c44f901c-b56e-4935-89e9-c09461156610");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Whirling Blade Stance",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ecef7bf6-2641-4b31-884d-c9a9bc4d89db"), Type = TextBlockType.Text, Text = "You enter a mindful stance that creates a deep connection between you and your monk weapons, allowing you to manipulate them with your ki even at a distance. All melee monk weapons you wield with the (trait: finesse) trait gain the (trait: thrown 10 feet) trait (unless they already have the (trait: thrown) trait with a greater range)." };
            yield return new TextBlock { Id = Guid.Parse("b4058c16-44e1-40e7-82eb-79ce497d23df"), Type = TextBlockType.Text, Text = "Once you’ve made a thrown (action: Strike) with such a weapon, you can use the precision of your throw to make additional strikes with it, even from a distance. Start from the space of the previous (action: Strike)’s target to determine the range increment and whether the new target has cover. At the end of your turn, the thrown weapon flies directly back to you in a straight line. If a solid barrier blocks its path, it falls to the ground after hitting the barrier." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("610f02af-49db-4293-b6e4-ddb0c64aca23"), Feats.Instances.MonasticWeaponry.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a5b054a3-affb-4074-aa83-15c525ef3314"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
