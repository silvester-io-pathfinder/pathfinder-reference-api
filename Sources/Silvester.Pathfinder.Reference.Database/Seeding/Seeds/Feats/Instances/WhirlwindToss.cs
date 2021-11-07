using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WhirlwindToss : Template
    {
        public static readonly Guid ID = Guid.Parse("dbae8a96-6daa-4c8b-82bb-1d73ebde7bcc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Whirlwind Toss",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b3bac4ff-c200-4215-b21b-f5bbd52e533b"), Type = TextBlockType.Text, Text = "You whirl a foe to smash into all nearby creatures before throwing them far away in imitation of the techniques of your rival, Ran-To. You (feat: Thrash). During this (feat: Thrash), your (feat: Collateral Thrash) feat applies to all foes adjacent to you. You can then throw the grabbed creature 10 feet, where they fall prone." };
            yield return new TextBlock { Id = Guid.Parse("6118a049-be7e-4a56-b68a-ef0149892609"), Type = TextBlockType.Text, Text = "If the foe you choose for (feat: Collateral Thrash) is also adjacent to you, they attempt only one save and take the damage only once." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("fe73dc5d-e678-4e02-a19f-4544ccb4fb3e"), Feats.Instances.CollateralThrash.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2fee9cc4-2a0b-4c1d-903d-6a3119304eb9"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
