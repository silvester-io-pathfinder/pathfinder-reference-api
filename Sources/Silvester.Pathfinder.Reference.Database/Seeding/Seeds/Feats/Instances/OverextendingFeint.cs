using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OverextendingFeint : Template
    {
        public static readonly Guid ID = Guid.Parse("a0f6e027-78a1-4dcd-9d3b-6bbc8ff6bea6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Overextending Feint",
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
            yield return new TextBlock { Id = Guid.Parse("dfe66f51-4314-42ae-9101-8308e4f3ed51"), Type = TextBlockType.Text, Text = "When you trick a foe, instead of catching them off guard, you goad them into overextending their next attack. On a successful (action: Feint), you can use the following success and critical success effects instead of any other effects that would occur when you (action: Feint). You can choose a different effect each time you (action: Feint) against a given foe." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("ff2ef787-f3e3-4a44-8ded-4610a703dc33"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("e96f4f79-7bfc-4077-8549-fabb7f92b0a4"),
                CriticalSuccess = "The target takes a –2 circumstance penalty to all attack rolls against you before the end of its next turn.",
                Success = "The target takes a –2 circumstance penalty to its next attack roll against you before the end of its next turn.",
                
                 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("07e3174a-f762-4d9a-b1b8-f1b23b6b025c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
