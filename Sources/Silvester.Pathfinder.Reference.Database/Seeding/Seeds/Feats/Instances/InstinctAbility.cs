using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InstinctAbility : Template
    {
        public static readonly Guid ID = Guid.Parse("52b9391f-09fa-4458-a33c-03a9a442905d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Instinct Ability",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("353296ab-b765-45b6-9f41-bf06d5b7a025"), Type = TextBlockType.Text, Text = "You gain the instinct ability for the instinct you chose for (feat: Barbarian Dedication)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("00fe9b23-594b-467d-b886-469919230452"), Feats.Instances.BarbarianDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("75b55760-58a7-43db-8ca5-dfc6c26e1a72"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
