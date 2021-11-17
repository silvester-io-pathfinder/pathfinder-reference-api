using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DidacticStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("90cadced-bf6f-4b14-9a2e-701bbaaa548a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Didactic Strike",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("26c6cf4e-3cc4-4222-9c6a-d5f92764ff94"), Type = TextBlockType.Text, Text = "When you find a glaring weakness, you can set your allies up to annihilate your foe. When you use (feat: Shared Stratagem), you can designate up to 10 allies instead of just one. The foe is flat-footed against the first attack from each designated ally before your next turn, and each ally&#39;s first attack deals an extra 2d6 precision damage to the target if it hits." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("0ed33151-e6ac-4034-ae9f-1fd067602598"), Feats.Instances.SharedStratagem.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("358eeb41-c5a5-454d-a9df-7721a936f197"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
