using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShadowdancerDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("3509b446-891e-47b2-a6d3-4b7162a971ab");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shadowdancer Dedication",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the shadowdancer archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8ab6a8cc-6c97-4b47-bee2-200b1874e1ed"), Type = TextBlockType.Text, Text = $"You dedicate yourself to the shadows. Your coloring becomes gray and gloomy, your senses adjust to the darkness, and you can sneak through darkness with ease. You gain greater darkvision. You also gain a +2 circumstance bonus to Stealth checks when you are within dim light or darkness." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("ccd0d9c2-2c15-46ea-b7de-d4e982549352"), Proficiencies.Instances.Master.ID, Skills.Instances.Stealth.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("55d22d98-2358-4911-936c-1b70a603e324"), Proficiencies.Instances.Expert.ID, Skills.Instances.Performance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aaca5c5f-d59b-4509-9022-4d72d15ee177"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
