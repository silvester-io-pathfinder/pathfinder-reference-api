using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OngoingStrategy : Template
    {
        public static readonly Guid ID = Guid.Parse("fbd8c6cb-416a-4948-8bd2-87beb218e0f5");

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
            yield return new TextBlock { Id = Guid.Parse("0ddcf3b6-f3be-4097-b53e-a52fec476e9a"), Type = TextBlockType.Text, Text = "You&#39;re constantly studying small aspects of everyone&#39;s movements, even if you don&#39;t have a stratagem in place ahead of time. On any (action: Strike) for which you didn&#39;t (feat: Devise a Stratagem), you still deal precision damage equal to your number of strategic strike damage dice so long as the weapon or unarmed attack you used is one that would have let you use your Intelligence modifier had you (feat: Devised a Stratagem | Devise a Stratagem)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClassFeature(Guid.Parse("f652ed9e-0d2b-4d74-8eac-430c2934fbd5"), ClassFeatures.Investigators.StrategicStrike.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b8727c64-1d14-4ba9-9fe3-41fd0f33d8f3"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
