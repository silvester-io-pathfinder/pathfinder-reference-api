using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HalcyonSpellcastingAdept : Template
    {
        public static readonly Guid ID = Guid.Parse("9a326d6c-7a3d-44cd-8179-a71ff961dc4d");

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
            yield return new TextBlock { Id = Guid.Parse("8e7787d2-32ef-42cb-8c7a-63a7a401e902"), Type = TextBlockType.Text, Text = "You refine your halcyon magic. You gain two common 4th-level halcyon spells and two 5th-level halcyon spells. You also gain a 4th-level halcyon spell slot and a 5th-level halcyon spell slot. Your proficiency rank in either arcane or primal spell DCs and spell attack rolls advances from trained to expert." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e0e4b45a-8ae4-4a92-a166-4ab6689db12a"), Feats.Instances.HalcyonSpellcastingInitiate.ID);
            builder.AddOr(Guid.Parse("a46673ea-9990-42cb-af58-e151dfc7ec19"), or => 
            {
                or.AddAnd(Guid.Parse("5c81082c-a976-454d-a35f-cb97eebb68f9"), and => 
                {
                    and.HaveSpecificSkillProficiency(Guid.Parse("afb11a5a-0685-4c17-bcba-ff39d3f380c4"), Proficiencies.Instances.Master.ID, Skills.Instances.Arcana.ID);
                    and.HaveSpecificSkillProficiency(Guid.Parse("7f4603da-4d98-4dca-98dc-a812e856423e"), Proficiencies.Instances.Expert.ID, Skills.Instances.Nature.ID);
                });
                or.AddAnd(Guid.Parse("d86cff60-319c-457c-a276-3b7cec1555d6"), and => 
                {
                    and.HaveSpecificSkillProficiency(Guid.Parse("b828f868-4654-4f39-8162-52080b3ec897"), Proficiencies.Instances.Expert.ID, Skills.Instances.Arcana.ID);
                    and.HaveSpecificSkillProficiency(Guid.Parse("1e101c93-d0a3-4cee-9249-875aa07e6144"), Proficiencies.Instances.Master.ID, Skills.Instances.Nature.ID);
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
                Id = Guid.Parse("6a584c24-549e-4492-a6e0-3c90c650c780"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
