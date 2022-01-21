using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Rogues
{
    public class MasterStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("54a330a5-a560-429b-beee-cf849cd03773");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 19,
                Name = "Master Strike", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("fd5aab5a-2d1d-406c-b437-8c29c7e9a847"), Type = TextBlockType.Text, Text = "You can incapacitate an unwary foe with a single strike. Your proficiency rank for your rogue class DC increases to master. You gain the Master Strike free action." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificClassDcProficiency(Guid.Parse("eaf9d6f4-d53d-4a49-baf8-b09a2d8da333"), Proficiencies.Instances.Master.ID);
            builder.GainSpecificFeat(Guid.Parse("9e2e008d-c750-45d7-88ca-df0e887b3b81"), Feats.Instances.MasterStrike.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9b3dd294-3420-4835-9c9b-0c28df983ee3"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 182
            };
        }
    }
}
