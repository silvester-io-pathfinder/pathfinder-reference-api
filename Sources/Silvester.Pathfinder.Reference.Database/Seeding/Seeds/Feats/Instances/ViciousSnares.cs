using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ViciousSnares : Template
    {
        public static readonly Guid ID = Guid.Parse("f3429378-4c6b-4709-a445-89a67f81d332");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Vicious Snares",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("41810664-3a85-413f-ad6a-1dd1f645b98b"), Type = TextBlockType.Text, Text = "You’ve learned how to create traps that cause greater injuries. You deal an additional 1d6 precision damage with damaging snares you craft. This increases to 2d6 additional precision damage if you’re legendary in Crafting." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("7efa4ad3-7d2a-421b-ac74-af4c0b418186"), Proficiencies.Instances.Expert.ID, Skills.Instances.Crafting.ID);
            builder.HaveSpecificFeat(Guid.Parse("eadc041f-d724-402e-9384-8921562f636f"), Feats.Instances.SnareCrafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("17926292-5243-40fe-9d0e-1a167dfb20c9"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
