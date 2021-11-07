using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SchoolSpellRedirection : Template
    {
        public static readonly Guid ID = Guid.Parse("d5fca088-93bd-4a51-8609-39ebddcd276d");

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
            yield return new TextBlock { Id = Guid.Parse("ee220f5c-11a1-448c-8894-985f535ad0c9"), Type = TextBlockType.Text, Text = "When you (feat: Counterspell) a spell with a school matching your specialization, if you critically succeed at your counteract check, or if you succeed while using a spell of a higher level than the spell you countered, you can redirect the spell you countered. You choose the target, area, and other aspects of the spell and use your own spell DC, spell attack roll, or other statistics as appropriate to determine the effects." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("99c4976f-04cd-4a55-8495-d29b9fa57f6b"), Feats.Instances.Counterspell.ID);
            builder.HaveSpecificFeat(Guid.Parse("74b3ce9d-af45-488e-a89c-31d0c4311480"), Feats.Instances.RunelordDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bd15add8-e769-44a5-a2f3-4f1bdc1469c6"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
