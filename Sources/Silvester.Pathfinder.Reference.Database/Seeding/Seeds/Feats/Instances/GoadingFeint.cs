using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GoadingFeint : Template
    {
        public static readonly Guid ID = Guid.Parse("2e037cca-a6a2-43ea-ba07-efa3641c2f90");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Goading Feint",
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
            yield return new TextBlock { Id = Guid.Parse("8eae317e-fb51-4cc0-aa6a-15a38a519334"), Type = TextBlockType.Text, Text = "When you trick a foe, you can goad them into overextending their next attack. On a (action: Feint), you can use the following success and critical success effects instead of any other effects you would gain when you (action: Feint); if you do, other abilities that adjust the normal effects of your (action: Feint) no longer apply. You can choose whether to use the Goading Feint benefits or the normal benefits each time you (action: Feint) a given foe." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("cab1850c-2c72-4494-ae3d-dcf6fca2bd78"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("a12538e8-1070-4f82-b79c-552e6ecd04cf"),
                CriticalSuccess = "The target takes a -2 circumstance penalty to all attack rolls against you before the end of its next turn.",
                Success = "The target takes a -2 circumstance penalty to its next attack roll against you before the end of its next turn.",
                
                 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5269678d-ee02-4ef8-953a-9b26d284b153"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
