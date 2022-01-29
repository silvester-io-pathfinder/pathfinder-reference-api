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
    public class LionBladeDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("607e23b5-f082-47de-afca-ca977cbbc8a9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lion Blade Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have gained two other feats from the Lion Blade archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4c973600-84a8-4074-bcd8-5d5626313871"), Type = TextBlockType.Text, Text = $"~ Access: You are from Taldor." };
            yield return new TextBlock { Id = Guid.Parse("c004b9e7-c907-4628-b568-82153dea20bd"), Type = TextBlockType.Text, Text = $"Your lion blade spy training helps you conceal yourself and your identity. You become trained in your choice of Deception or Stealth and in Espionage Lore; if you were already trained, you become an expert instead. You never take circumstance penalties for attempting to take a disguise of a different ancestry, age, and so on, as long as the disguised form is appropriate for your size." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.Manual(Guid.Parse("7e78117e-c579-4982-8715-19b8cf816261"), "Member of the Lion Blades");
            builder.HaveSpecificSkillProficiency(Guid.Parse("e30898ce-7533-47e4-930f-21e52772f136"), Proficiencies.Instances.Expert.ID, Skills.Instances.Athletics.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("31fb5aba-5d26-4003-bfb1-088c9872e1bf"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
