using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FollowUpStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("a3d9c895-690f-44e5-bc09-800b70bb2cf4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Follow-Up Strike",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("79661e2c-d0cf-4d77-b666-03c9bae2e22a"), Type = TextBlockType.Text, Text = "You have trained to use all parts of your body as a weapon, and when you miss with an attack, you can usually continue the attack with a different body part and still deal damage. Make another (action: Strike) with a melee unarmed attack, using the same multiple attack penalty as for the missed (action: Strike), if any." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f556c145-58e1-450b-9d1e-5713f1512e9d"), Feats.Instances.MartialArtistDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fbc108b5-4100-4653-bd95-570ca1cd9bb7"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
