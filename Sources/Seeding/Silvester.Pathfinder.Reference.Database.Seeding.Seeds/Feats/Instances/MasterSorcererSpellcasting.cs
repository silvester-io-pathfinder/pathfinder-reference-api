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
    public class MasterSorcererSpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("ea2364c3-3898-42f2-ae66-d707b516566e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Master Sorcerer Spellcasting",
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
            yield return new TextBlock { Id = Guid.Parse("47a66765-606a-4254-9442-fe8b78a0a798"), Type = TextBlockType.Text, Text = $"Your proficiency ranks for your bloodline's spell attack rolls and spell DCs increase to master, and you gain a 7th-level spell slot. You can select a third spell from your repertoire as a signature spell. At 20th level, you gain an 8th-level spell slot." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("bffd093d-2f30-417c-aaa0-b2308d7f27e9"), Feats.Instances.ExpertSorcererSpellcasting.ID);
            builder.AddOr(Guid.Parse("4b46db55-c2f9-47ec-aa1d-29b51e40d4e8"), or => 
            {
                or.HaveSpecificSkillProficiency(Guid.Parse("d37025e1-bd74-410d-b2a7-73daf02e6e7a"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Arcana.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("47ab60a1-80ef-4003-9863-ce47c48564c9"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Nature.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("98df9b42-9cf7-4e91-b636-bc7b6b839543"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Occultism.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("6fcb091e-ced6-4bd9-acb1-a9e7671b61f7"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Religion.ID);
                //TODO: Add prerequisites.
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
                Id = Guid.Parse("2d23804a-e6c1-49b0-b2f2-2f14abdfa832"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
