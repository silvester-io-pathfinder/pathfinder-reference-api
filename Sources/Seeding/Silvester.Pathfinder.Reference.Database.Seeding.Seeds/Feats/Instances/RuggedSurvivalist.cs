using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RuggedSurvivalist : Template
    {
        public static readonly Guid ID = Guid.Parse("dd2e2872-b0e1-4ccf-a2af-2a525faa0a83");

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
            yield return new TextBlock { Id = Guid.Parse("70e5b4e8-f212-48f4-bab6-2f51ae1a56dd"), Type = TextBlockType.Text, Text = $"You've studied survival skills with the School of Swords experts and are comfortable spending long periods of time in the wilderness. You don't get fatigued more quickly due to precipitation during overland travel, though you can otherwise be fatigued as normal. You can go 3 days + your Constitution modifier without water before you take damage from thirst and you can go 5 days + your Constitution modifier without food before you take damage from starvation." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("70cca459-b2aa-49eb-a066-6ab305f03615"), Feats.Instances.SwordmasterDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("1923ee91-7c18-4f81-94da-8bab29872ab4"), Proficiencies.Instances.Master.ID, Skills.Instances.Survival.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Skill.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e5d725ca-ea9c-4ae7-a501-b3f74af1bf1c"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
