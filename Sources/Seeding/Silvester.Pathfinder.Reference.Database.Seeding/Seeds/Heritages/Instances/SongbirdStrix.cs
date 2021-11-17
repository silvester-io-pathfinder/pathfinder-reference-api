using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class SongbirdStrix : Template
    {
        public static readonly Guid ID = Guid.Parse("2aa3ff94-155f-47a3-8f99-7afc75102769");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Songbird Strix"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("ccbc8cb5-0f47-4def-ba05-7333681d4f81"), Type = TextBlockType.Text, Text = "You descend from a talented line of strix storytellers. From the highest mountains and purest landscapes where your lungs fill with glorious clean air, you trill, whistle, and croon sweet songs. While natural sounds make you predisposed to sing, voices make you predisposed to mimicry. You receive a +1 circumstance bonus on Deception checks to Impersonate a mimicked voice, where the sound of the voice is the only factor; if you are a master in Deception, you gain a +2 circumstance bonus instead. You also gain a +1 circumstance bonus on Performance checks to sing; if you are a master in Performance, you gain a +2 circumstance bonus instead." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSkillSpecificSkillActionCircumstanceBonus(Guid.Parse("6ea29f5f-9dda-42a5-a084-28a2b547765b"), Skills.Instances.Deception.ID, SkillActions.Instances.Impersonate.ID, bonus: 1, addendum: "Only applies to impersonating a mimicked voice, where the sound of the voice is the only factor.");
            builder.GainSpecificSkillSpecificSkillActionCircumstanceBonus(Guid.Parse("a89de348-5b28-41c5-a202-3c35fee7a728"), Skills.Instances.Deception.ID, SkillActions.Instances.Impersonate.ID, bonus: 1, addendum: "Only applies to impersonating a mimicked voice, where the sound of the voice is the only factor.")
                .AddPrerequisites(Guid.Parse("4f6c789e-48fe-4a99-b5b6-fffe1402ff1e"), prerequisites => 
                {
                    prerequisites.HaveSpecificSkillProficiency(Guid.Parse("1b968373-ee38-4ac7-8143-0bce46fb58d9"), Proficiencies.Instances.Master.ID, Skills.Instances.Deception.ID);
                });

            builder.GainSpecificSkillCircumstanceBonus(Guid.Parse("59848227-b54a-4979-9654-b6792c819297"), Skills.Instances.Performance.ID, bonus: 1, addendum: "Only applies to singing.");
            builder.GainSpecificSkillCircumstanceBonus(Guid.Parse("4fa0b063-fe7f-419a-8cbe-76b72965f506"), Skills.Instances.Performance.ID, bonus: 1, addendum: "Only applies to singing.")
                .AddPrerequisites(Guid.Parse("6030ec6e-d26e-4a6f-b310-08612976c448"), prerequisites =>
                {
                    prerequisites.HaveSpecificSkillProficiency(Guid.Parse("7242c9e3-ff53-4de4-8de5-38a21d7fa295"), Proficiencies.Instances.Master.ID, Skills.Instances.Performance.ID);
                });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4c8fdcbf-581a-418f-bfb5-57bfde75e522"),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 135
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Strix.ID;
        }
    }
}
