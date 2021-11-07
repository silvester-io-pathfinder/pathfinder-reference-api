using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class IronFists : Template
    {
        public static readonly Guid ID = Guid.Parse("b1a7efd6-017e-4348-9d56-d213ac27194f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Iron Fists",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5d69e2bf-ee08-4af4-893b-1caff9109539"), Type = TextBlockType.Text, Text = "Your fists have been forged by battle, your naturally tough skin and dense bone further hardened by conflict. Your fist unarmed attacks no longer have the (trait: nonlethal) trait and gain the (trait: shove) weapon trait." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("da29ff18-f5d6-4825-bd35-3d3d1f6af2ef"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
