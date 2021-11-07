using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GorillaPound : Template
    {
        public static readonly Guid ID = Guid.Parse("31b081ca-75ca-4c7d-a0a9-44b649a22de4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Gorilla Pound",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "If you have this feat, while you are in Gorilla Stance, you gain a climb Speed of 15 feet.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c9c1d649-6d56-4802-9fc3-45505f9eb054"), Type = TextBlockType.Text, Text = "You pound your chest before slamming into your foes. Attempt an Intimidation check to (action: Demoralize), then make one gorilla slam (action: Strike) against the same target. If your (action: Strike) hits, you gain a circumstance bonus to the damage roll equal to triple the value of the target’s frightened condition." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("2f5adeeb-791a-4fc3-bb27-071a4fcfc784"), Proficiencies.Instances.Expert.ID, Skills.Instances.Intimidation.ID);
            builder.HaveSpecificFeat(Guid.Parse("fc054a42-d5c3-4588-aecb-47060f42a963"), Feats.Instances.GorillaStance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a252ffac-06bb-4c29-b760-d579209f3e84"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
