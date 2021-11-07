using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class IntimidatingProwess : Template
    {
        public static readonly Guid ID = Guid.Parse("166a227f-b238-4de5-9f42-e1d3e8675cfc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Intimidating Prowess",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e7915c84-61f9-4e71-8c04-16d66a9bc998"), Type = TextBlockType.Text, Text = "In situations where you can physically menace the target when you (action: Coerce) or (action: Demoralize), you gain a +1 circumstance bonus to your Intimidation check and you ignore the penalty for not sharing a language. If your Strength score is 20 or higher and you are a master in Intimidation, this bonus increases to +2." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("39587db0-c1cd-4db4-8cc9-9c2469d88c4a"), requiredStatValue: 16, Stats.Instances.Strength.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("b206d596-ea1c-4a4a-b77e-ba4e5ee74765"), Proficiencies.Instances.Expert.ID, Skills.Instances.Intimidation.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("18cc2de2-24e4-4dd6-b7bf-4c8a7e194129"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
