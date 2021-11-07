using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MasterAlchemy : Template
    {
        public static readonly Guid ID = Guid.Parse("114bfe0d-d371-4b64-9d8b-81cfe339cf4d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Master Alchemy",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e92b7165-2150-4cac-a510-485ab6207404"), Type = TextBlockType.Text, Text = "Your advanced alchemy level increases to 7. For every level you gain beyond 12th, your advanced alchemy level increases by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6ddea0f0-91a9-433a-a772-9c018a64993c"), Feats.Instances.ExpertAlchemy.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("26b540bf-306c-4cca-95bc-92ca2dd03824"), Proficiencies.Instances.Master.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("168187fb-bb64-4b6d-996d-99d15176d3fc"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
