using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DidacticStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("6ab44574-4286-41c3-840c-02f876d52014");

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
            yield return new TextBlock { Id = Guid.Parse("b3f55782-13db-4abd-b9a2-ff4395e669e8"), Type = TextBlockType.Text, Text = "When you find a glaring weakness, you can set your allies up to annihilate your foe. When you use (feat: Shared Stratagem), you can designate up to 10 allies instead of just one. The foe is flat-footed against the first attack from each designated ally before your next turn, and each ally&#39;s first attack deals an extra 2d6 precision damage to the target if it hits." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6f548b91-52f1-46a0-8cf8-b232b905be14"), Feats.Instances.SharedStratagem.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5426c522-cb41-4bf0-8b69-537d4baf0803"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
