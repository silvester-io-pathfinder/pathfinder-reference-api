using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CraftersAppraisal : Template
    {
        public static readonly Guid ID = Guid.Parse("c64ba0e2-1f62-4257-ba1b-3ee135391201");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Crafter's Appraisal",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a64886c3-2f41-49ba-80df-1112f66debf3"), Type = TextBlockType.Text, Text = "Your knowledge of items’ construction allows you to discern their magical effects as well. You can use Crafting instead of a skill associated with a magic tradition to (action: Identify Magic) on magic items, though not on any other sorts of magic." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("5f9b2637-62b9-4b94-bcd5-5e137fdb0f5b"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("631fb66f-5dbf-4bdc-8633-03dce78a28e4"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
