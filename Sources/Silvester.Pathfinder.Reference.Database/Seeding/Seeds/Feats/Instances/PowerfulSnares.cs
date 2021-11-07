using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PowerfulSnares : Template
    {
        public static readonly Guid ID = Guid.Parse("bdddb0d6-d75f-4e0c-a9f2-e8202ff80ec7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Powerful Snares",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b1f23754-b4df-4ead-9ab7-ee660cc7f574"), Type = TextBlockType.Text, Text = "Your snares are particularly difficult for enemies to avoid. When you set a snare, the saving throw DC for that snare is equal to its normal DC or your class DC, whichever is higher." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("8c8ae3ab-f069-4fe9-8b0c-96b2c6baf660"), Proficiencies.Instances.Master.ID, Skills.Instances.Crafting.ID);
            builder.HaveSpecificFeat(Guid.Parse("03a56111-7f0c-458c-bd40-94adb801b8da"), Feats.Instances.SnarecrafterDedictation.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5de26956-fd59-4b46-9297-a49c253e2069"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
