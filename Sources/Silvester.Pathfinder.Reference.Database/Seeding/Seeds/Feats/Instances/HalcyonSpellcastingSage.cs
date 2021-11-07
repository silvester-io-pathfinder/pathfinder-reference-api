using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HalcyonSpellcastingSage : Template
    {
        public static readonly Guid ID = Guid.Parse("d29b70c6-75b3-4b51-8a14-66b11df8738e");

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
            yield return new TextBlock { Id = Guid.Parse("137a08e2-9445-46ac-8a7f-57dcb9d79566"), Type = TextBlockType.Text, Text = "Your command over halcyon magic is nearly unmatched. You gain two common 6th-level and 7th-level halcyon spells. You also gain a 6th-level halcyon spell slot and a 7th-level halcyon spell slot. Your proficiency rank in either arcane or primal spell DCs and spell attack rolls advances from expert to master." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f8935103-d37a-4440-89af-58404d9aa000"), Feats.Instances.HalcyonSpellcastingAdept.ID);
            builder.AddOr(Guid.Parse("9cb80a58-cc54-4997-98fb-11da93e35d04"), or => 
            {
                or.AddAnd(Guid.Parse("0789c272-8b83-4fda-b1de-0212f5c19749"), and => 
                {
                    and.HaveSpecificSkillProficiency(Guid.Parse("00ad286f-225d-4711-90dc-869cd2cd5b4a"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Arcana.ID);
                    and.HaveSpecificSkillProficiency(Guid.Parse("ee71f62c-7499-4c09-9c93-ecf2182ac224"), Proficiencies.Instances.Master.ID, Skills.Instances.Nature.ID);
                });
                or.AddAnd(Guid.Parse("e9abe2db-2c1d-41f5-96e4-c6c0392cd4ab"), and => 
                {
                    and.HaveSpecificSkillProficiency(Guid.Parse("ad3007b1-3d65-4436-a028-b87560db7aea"), Proficiencies.Instances.Master.ID, Skills.Instances.Arcana.ID);
                    and.HaveSpecificSkillProficiency(Guid.Parse("05f100d5-cce3-4109-a2cd-21e2b16656bd"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Nature.ID);
                });
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c359a575-7af9-4e69-8dac-86c6e73d08a6"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
