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
    public class HalcyonSpellcastingAdept : Template
    {
        public static readonly Guid ID = Guid.Parse("5ce98ae4-97ab-4e03-8220-328fe259f875");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Halcyon Spellcasting Adept",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e7c9f12f-77fa-4040-81c5-be6183be6566"), Type = TextBlockType.Text, Text = $"You refine your halcyon magic. You gain two common 4th-level halcyon spells and two 5th-level halcyon spells. You also gain a 4th-level halcyon spell slot and a 5th-level halcyon spell slot. Your proficiency rank in either arcane or primal spell DCs and spell attack rolls advances from trained to expert." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("db5b2cb4-e583-44f3-88d0-9d2eb6776212"), Feats.Instances.HalcyonSpellcastingInitiate.ID);
            builder.AddOr(Guid.Parse("91b9cc49-81ae-4f6b-8cf8-1901b636194a"), or => 
            {
                or.AddAnd(Guid.Parse("2de6fb26-8a44-43f0-8fa5-d64d09f381a5"), and => 
                {
                    and.HaveSpecificSkillProficiency(Guid.Parse("d21f90ca-d43a-4090-9ba0-fb627b22ed21"), Proficiencies.Instances.Master.ID, Skills.Instances.Arcana.ID);
                    and.HaveSpecificSkillProficiency(Guid.Parse("fe4bae79-307d-49a8-b08a-f3a7d43c4ddf"), Proficiencies.Instances.Expert.ID, Skills.Instances.Nature.ID);
                });
                or.AddAnd(Guid.Parse("fbc12b20-c38e-462f-8747-e8abb7cc6bef"), and => 
                {
                    and.HaveSpecificSkillProficiency(Guid.Parse("b87895bd-efda-4321-b8fa-e30f5e294930"), Proficiencies.Instances.Expert.ID, Skills.Instances.Arcana.ID);
                    and.HaveSpecificSkillProficiency(Guid.Parse("0aa42d37-066d-4c6a-ac4a-2318db4a44f8"), Proficiencies.Instances.Master.ID, Skills.Instances.Nature.ID);
                });
            });
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("58f427e5-c0fa-42d5-beeb-12ad314e64a1"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
