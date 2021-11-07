using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FuseStance : Template
    {
        public static readonly Guid ID = Guid.Parse("c1741e23-d645-4c38-b9f2-8e7fc735b64b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fuse Stance",
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
            yield return new TextBlock { Id = Guid.Parse("2d4e899e-0a73-4c97-b8c0-37aec7ea2273"), Type = TextBlockType.Text, Text = "You have combined two stances into a single stance all your own. When you take this feat, choose two stances you know and combine them into a single fused stance. Give your new fused stance a unique name. When you enter your fused stance, you gain all the effects of both stances, including the requirements and restrictions." };
            yield return new TextBlock { Id = Guid.Parse("66bf3419-27ee-492e-a4e4-720082e0cb41"), Type = TextBlockType.Text, Text = "You can’t fuse stances with fundamentally incompatible requirements or restrictions (such as (feat: Ironblood Stance) and (feat: Crane Stance), which both require using only one type of (action: Strike))." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStanceAmount(Guid.Parse("e4bfc924-60dd-49c1-bef2-710b5461d142"), Comparator.GreaterThanOrEqualTo, 2);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1a5aa49c-4f67-499a-8d3c-1ba02c595cee"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
