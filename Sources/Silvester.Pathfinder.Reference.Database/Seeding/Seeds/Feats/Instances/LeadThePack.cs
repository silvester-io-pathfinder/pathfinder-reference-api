using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LeadThePack : Template
    {
        public static readonly Guid ID = Guid.Parse("e23ce4ea-b382-42af-956f-551c627725e1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lead the Pack",
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
            yield return new TextBlock { Id = Guid.Parse("95df9656-55cb-4dfc-8df1-086cc1eaa8bd"), Type = TextBlockType.Text, Text = "You can have up to two animal companions active at once. However, when you do, it’s slightly more difficult to (action: Command | Command an Animal) them. If you don’t (action: Command | Command an Animal) either of your companions, one of the two (your choice) can still use 1 action on your turn to (action: Stride) or (action: Strike), as per (feat: Mature Beastmaster Companion), but not both. When you (action: Command an Animal), either choose one of the companions to take 2 actions, as normal, or else both companions can take 1 action to (action: Stride) or (action: Strike). Either way, you can’t (action: Command an Animal) to make either companion act again until your next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7242d9f1-4f0a-4d94-96b7-ddf0cbfedd8a"), Feats.Instances.MatureBeastmasterCompanion.ID);
            builder.HaveSpecificAnimalCompanionAmount(Guid.Parse("13245b96-40a3-4686-8961-be9caea6aa62"), Comparators.GreaterThanOrEqualTo, amount: 2);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("50ac56bb-e3a2-401e-b9bc-b40b5dc28435"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
