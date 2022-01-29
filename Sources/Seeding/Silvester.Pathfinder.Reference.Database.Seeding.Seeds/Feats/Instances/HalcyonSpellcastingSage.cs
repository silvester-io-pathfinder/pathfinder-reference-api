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
    public class HalcyonSpellcastingSage : Template
    {
        public static readonly Guid ID = Guid.Parse("92fd6255-e0ac-4f89-a30f-d57502811309");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Halcyon Spellcasting Sage",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a2e07d93-f3b7-48ef-bfd5-579a174581a1"), Type = TextBlockType.Text, Text = $"Your command over halcyon magic is nearly unmatched. You gain two common 6th-level and 7th-level halcyon spells. You also gain a 6th-level halcyon spell slot and a 7th-level halcyon spell slot. Your proficiency rank in either arcane or primal spell DCs and spell attack rolls advances from expert to master." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("be6c537b-e68d-4217-b27a-1ce46ca80f1e"), Feats.Instances.HalcyonSpellcastingAdept.ID);
            builder.AddOr(Guid.Parse("916f2b9d-20c0-42a4-bcc2-55a5c77f922c"), or => 
            {
                or.AddAnd(Guid.Parse("43645800-6bf3-4987-9188-5d9e67e9a21b"), and => 
                {
                    and.HaveSpecificSkillProficiency(Guid.Parse("855d7b76-033c-4ffe-a275-ca501b158774"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Arcana.ID);
                    and.HaveSpecificSkillProficiency(Guid.Parse("1eaff1d0-0a4b-4b01-b1b9-e0b9e05deea9"), Proficiencies.Instances.Master.ID, Skills.Instances.Nature.ID);
                });
                or.AddAnd(Guid.Parse("0683c99e-420b-4ed6-b25e-db5540c092a3"), and => 
                {
                    and.HaveSpecificSkillProficiency(Guid.Parse("5ccb8867-2e79-4e01-9612-af22fb6c44e5"), Proficiencies.Instances.Master.ID, Skills.Instances.Arcana.ID);
                    and.HaveSpecificSkillProficiency(Guid.Parse("704f9622-aad4-4a5f-9717-3fd0cdfcceef"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Nature.ID);
                });
            });
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1367a5e2-c92b-4619-acb7-760551fc02c7"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
