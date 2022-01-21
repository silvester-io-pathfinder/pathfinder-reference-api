using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GoadingFeint : Template
    {
        public static readonly Guid ID = Guid.Parse("68dfdfd7-5d2e-4cd0-8ed8-bf8065d324f6");

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
            yield return new TextBlock { Id = Guid.Parse("3632c121-3083-4583-8f34-0849e9148b4c"), Type = TextBlockType.Text, Text = "When you trick a foe, you can goad them into overextending their next attack. On a (action: Feint), you can use the following success and critical success effects instead of any other effects you would gain when you (action: Feint); if you do, other abilities that adjust the normal effects of your (action: Feint) no longer apply. You can choose whether to use the Goading Feint benefits or the normal benefits each time you (action: Feint) a given foe." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("c1d09079-5a66-4ed3-ae35-7405b47ec5b3"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("7ed19e81-27b9-43cd-ae54-6174283c7583"),
                CriticalSuccess = "The target takes a -2 circumstance penalty to all attack rolls against you before the end of its next turn.",
                Success = "The target takes a -2 circumstance penalty to its next attack roll against you before the end of its next turn.",
                
                 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1d77254b-d6e4-46d8-a779-dc1960899b30"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
