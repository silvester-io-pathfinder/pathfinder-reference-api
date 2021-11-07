using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SchoolSpellRedirection : Template
    {
        public static readonly Guid ID = Guid.Parse("f4d26e3e-591c-4a17-b10b-5ad8a5a6dbaa");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "School Spell Redirection",
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
            yield return new TextBlock { Id = Guid.Parse("bbce26a1-f0e9-449d-afa3-ba05123bdfd1"), Type = TextBlockType.Text, Text = "When you (feat: Counterspell) a spell with a school matching your specialization, if you critically succeed at your counteract check, or if you succeed while using a spell of a higher level than the spell you countered, you can redirect the spell you countered. You choose the target, area, and other aspects of the spell and use your own spell DC, spell attack roll, or other statistics as appropriate to determine the effects." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("8251bf54-d359-4070-bcd9-5f4b19e8969f"), Feats.Instances.Counterspell.ID);
            builder.HaveSpecificFeat(Guid.Parse("41d3dcf7-a3a4-4f50-a0f3-e83ab9984419"), Feats.Instances.RunelordDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("055ddcaa-53a6-4e0f-99dc-27a8fef9f9b7"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
