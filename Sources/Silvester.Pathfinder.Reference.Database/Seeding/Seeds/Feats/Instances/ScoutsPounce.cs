using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ScoutsPounce : Template
    {
        public static readonly Guid ID = Guid.Parse("dd0047e5-091b-41e6-8119-107634161fe1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Scout's Pounce",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0d1d764a-3f04-4ffa-8208-9c7376bd52fa"), Type = TextBlockType.Text, Text = "You leap from the shadows to strike your foes. (action: Stride) up to your Speed, then (action: Strike) twice. If you were hidden or unnoticed by the target of these (action: Strikes | Strike), your foe is flat-footed against both attacks. Your multiple attack penalty applies normally for both attacks." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("59890416-5e18-480c-a348-2b110d43aae6"), Feats.Instances.ScoutDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("68b22158-32b6-4a25-b773-72bacabd78ca"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
