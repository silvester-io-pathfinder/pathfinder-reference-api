using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ScorchingDisarm : Template
    {
        public static readonly Guid ID = Guid.Parse("0303e002-df3e-409d-b4e9-5be0a150d8bd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Scorching Disarm",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("23c525a7-6b93-459c-b149-2742c50ded7c"), Type = TextBlockType.Text, Text = "You make a weapon unbearable to hold. Attempt an Athletics check to (action: Disarm) a target creature. You don’t need to have a hand free to make this (action: Disarm) attempt. If the (action: Disarm) attempt succeeds, the target takes 4d6 fire damage unless it drops the weapon, and on a critical success, it takes 4d6 fire damage and drops the weapon. If you’re legendary in Athletics, this increases to 8d6 fire damage." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("507e4984-a353-4ce2-ac10-f36c05901e2e"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
