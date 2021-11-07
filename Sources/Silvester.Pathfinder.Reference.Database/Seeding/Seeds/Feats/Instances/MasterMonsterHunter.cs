using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MasterMonsterHunter : Template
    {
        public static readonly Guid ID = Guid.Parse("090d2855-7c14-4bed-be02-ba1bbd789385");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Master Monster Hunter",
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
            yield return new TextBlock { Id = Guid.Parse("ae3db686-f058-4512-8886-ba48a87c6295"), Type = TextBlockType.Text, Text = "You have a nearly encyclopedic knowledge of all creatures of the world. You can use Nature to (action: Recall Knowledge) to identify any creature. In addition, you gain the benefits of (feat: Monster Hunter) (and (feat: Monster Warden), if you have it) on a success as well as a critical success." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("bcf6ac89-459b-43c7-baf3-a776b31c0d71"), Proficiencies.Instances.Master.ID, Skills.Instances.Nature.ID);
            builder.HaveSpecificFeat(Guid.Parse("ca1a6932-bad1-47db-b545-cb8a78dcc49a"), Feats.Instances.MonsterHunter.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0274f859-fe0c-4ce1-a753-b52752d9ae54"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
