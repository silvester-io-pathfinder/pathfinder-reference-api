using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OngoingStrategy : Template
    {
        public static readonly Guid ID = Guid.Parse("0f3b2e73-4d2f-4710-b04d-90cd548a6f8d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ongoing Strategy",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("59cc211b-14bc-42f1-a3db-5adaadcdfa6d"), Type = TextBlockType.Text, Text = "You&#39;re constantly studying small aspects of everyone&#39;s movements, even if you don&#39;t have a stratagem in place ahead of time. On any (action: Strike) for which you didn&#39;t (feat: Devise a Stratagem), you still deal precision damage equal to your number of strategic strike damage dice so long as the weapon or unarmed attack you used is one that would have let you use your Intelligence modifier had you (feat: Devised a Stratagem | Devise a Stratagem)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClassFeature(Guid.Parse("e5e210c0-06ab-44af-ac15-0c2ff28ea15e"), ClassFeatures.Investigators.StrategicStrike.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d2a9b64a-ec30-448b-8f67-fa99a875dcf7"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
