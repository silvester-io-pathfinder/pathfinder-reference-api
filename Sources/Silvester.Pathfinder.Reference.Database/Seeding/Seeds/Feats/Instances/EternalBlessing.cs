using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EternalBlessing : Template
    {
        public static readonly Guid ID = Guid.Parse("75aed46a-148f-48ed-9602-81dfce3368cd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Eternal Blessing",
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
            yield return new TextBlock { Id = Guid.Parse("cf3d329b-8d00-46d4-9d2e-8782e58d6334"), Type = TextBlockType.Text, Text = "Your good deeds have brought your deity’s grace to you for all of eternity. You’re continuously surrounded by a (spell: bless) spell with a spell level equal to half your level (rounded up). The radius is 15 feet, and you can’t increase it. You can (action: Dismiss) the spell; if you do, it returns automatically after 1 minute." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("3e4be9ac-2c4a-4b90-8b44-8ded1af5f0f9"), or => 
            {
                or.HaveSpecificAlignment(Guid.Parse("706dd5e7-b3f6-4bfb-8866-e57311506dd7"), Alignments.Instances.LawfulGood.ID);
                or.HaveSpecificAlignment(Guid.Parse("bc5aaf0b-36b1-4878-aec7-26ad24175325"), Alignments.Instances.ChaoticGood.ID);
                or.HaveSpecificAlignment(Guid.Parse("8bffe738-1a83-4eef-8196-a018bf7aa267"), Alignments.Instances.NeutralGood.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e321836a-68e8-469c-9ea6-823968f3778c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
