using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RuggedSurvivalist : Template
    {
        public static readonly Guid ID = Guid.Parse("e374b196-5dd3-4554-a776-dac5d1b331de");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Rugged Survivalist",
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
            yield return new TextBlock { Id = Guid.Parse("9cf53ffc-3f39-418d-ace4-87fe132c89a4"), Type = TextBlockType.Text, Text = "You&#39;ve studied survival skills with the School of Swords experts and are comfortable spending long periods of time in the wilderness. You don&#39;t get fatigued more quickly due to precipitation during overland travel, though you can otherwise be fatigued as normal. You can go 3 days + your Constitution modifier without water before you take damage from thirst and you can go 5 days + your Constitution modifier without food before you take damage from starvation." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("ee8e1599-4764-47ca-99d5-c862bf27748a"), Feats.Instances.SwordmasterDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("603e445e-3300-4c3d-9bdd-ed0439ead882"), Proficiencies.Instances.Master.ID, Skills.Instances.Survival.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a5e2c3d6-5dbb-4884-b343-805c81fcbb24"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
