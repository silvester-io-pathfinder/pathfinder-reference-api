using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RelentlessDisarm : Template
    {
        public static readonly Guid ID = Guid.Parse("ff48ef2b-f47f-49f1-a459-1c457a62df28");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Relentless Disarm",
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
            yield return new TextBlock { Id = Guid.Parse("a6cb9b18-1b42-45ba-9715-422a2ca2de20"), Type = TextBlockType.Text, Text = "When you succeed, but don’t critically succeed, at a check to (action: Disarm) a creature, your circumstance bonus to further checks to (action: Disarm) that creature is +4 instead of +2. Other creatures gain only the normal bonus." };
            yield return new TextBlock { Id = Guid.Parse("6b34bbce-5618-47fb-9b32-d686f86cfbaa"), Type = TextBlockType.Text, Text = "When you critically succeed at a (action: Disarm) check, you can immediately (action: Demoralize) your target as a reaction." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c90f325d-3926-4b12-b964-725d1b5e1c67"), Feats.Instances.ZephyrGuardDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("99bc32a0-1e07-475e-8cd2-8ad9e1e29177"), Proficiencies.Instances.Trained.ID, Skills.Instances.Athletics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1a36cd3c-bcf9-4e4e-a380-fe1103f8d1cb"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
