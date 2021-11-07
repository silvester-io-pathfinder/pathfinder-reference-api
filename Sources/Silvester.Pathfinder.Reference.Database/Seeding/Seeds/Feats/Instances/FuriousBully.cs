using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FuriousBully : Template
    {
        public static readonly Guid ID = Guid.Parse("0908108b-3570-4887-8735-430138f62854");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Furious Bully",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("590b286f-c9a3-44cc-b9b9-67c044d43af9"), Type = TextBlockType.Text, Text = "You bully foes across the battlefield. While raging, you gain a +2 circumstance bonus to Athletics checks for (trait: attack) actions." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("bd3fbfb7-146c-46b4-afda-edbb8f586bcc"), Proficiencies.Instances.Master.ID, Skills.Instances.Athletics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1bb661bb-18f4-4cf7-ab13-c43b7bf59fa6"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
