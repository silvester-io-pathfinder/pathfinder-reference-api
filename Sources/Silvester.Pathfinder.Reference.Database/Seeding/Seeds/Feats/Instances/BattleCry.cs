using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BattleCry : Template
    {
        public static readonly Guid ID = Guid.Parse("3f5816ec-12f2-4f44-8aa8-cb60f87880dd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Battle Cry",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("524088cb-a970-4bd3-a4d1-47410b1b2f30"), Type = TextBlockType.Text, Text = "When you roll initiative, you can yell a mighty battle cry and (action: Demoralize) an observed foe as a free action. If you’re legendary in Intimidation, you can use a reaction to (action: Demoralize) your foe when you critically succeed at an attack roll." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("6a930da4-dcbd-41e9-9579-985cac691aa5"), Proficiencies.Instances.Master.ID, Skills.Instances.Intimidation.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("baa35d7d-0cb3-4f90-9e74-910f23cfdb9c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
