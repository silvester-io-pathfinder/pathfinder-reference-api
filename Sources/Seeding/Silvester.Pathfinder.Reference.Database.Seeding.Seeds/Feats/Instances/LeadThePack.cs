using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LeadThePack : Template
    {
        public static readonly Guid ID = Guid.Parse("20e9404f-5ad8-409b-b6b1-3d425c747fec");

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
            yield return new TextBlock { Id = Guid.Parse("0cb284ee-174d-4215-b480-0472b71687b4"), Type = TextBlockType.Text, Text = "You can have up to two animal companions active at once. However, when you do, it's slightly more difficult to (action: Command | Command an Animal) them. If you don't (action: Command | Command an Animal) either of your companions, one of the two (your choice) can still use 1 action on your turn to (action: Stride) or (action: Strike), as per (feat: Mature Beastmaster Companion), but not both. When you (action: Command an Animal), either choose one of the companions to take 2 actions, as normal, or else both companions can take 1 action to (action: Stride) or (action: Strike). Either way, you can't (action: Command an Animal) to make either companion act again until your next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c78f76ff-fd9a-40dc-8ab6-c79388ed9716"), Feats.Instances.MatureBeastmasterCompanion.ID);
            builder.HaveSpecificAnimalCompanionAmount(Guid.Parse("8df85abf-d845-4c88-8c1c-91246fb5b6ab"), Comparator.GreaterThanOrEqualTo, amount: 2);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("756b386e-3e66-4110-a358-0160e58707ab"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}