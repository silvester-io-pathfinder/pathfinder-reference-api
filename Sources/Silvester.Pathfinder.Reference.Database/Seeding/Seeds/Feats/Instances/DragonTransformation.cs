using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DragonTransformation : Template
    {
        public static readonly Guid ID = Guid.Parse("3c1169d9-48b5-4de5-9419-357b4c2f9508");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dragon Transformation",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("87ca80b4-2fee-4e4c-961a-299516f7fa84"), Type = TextBlockType.Text, Text = "You transform into a ferocious Large dragon, gaining the effects of 6th-level (spell: dragon form) except that you use your own AC and attack modifier; you also apply your extra damage from (feat: Rage). The action to (action: Dismiss) the transformation gains the (trait: rage) trait." };
            yield return new TextBlock { Id = Guid.Parse("e2a6fe09-ee75-47fd-adba-bcaac4be191c"), Type = TextBlockType.Text, Text = "At 18th level, you gain a +20-foot status bonus to your fly Speed, your damage bonus with dragon (action: Strikes | Strike) increases to +12, your breath weapon DC is your class DC, and you gain a +14 status bonus to your breath weapon damage." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInstinct(Guid.Parse("1e31fa7f-13b2-4852-9027-7a76928e481b"), Instincts.Instances.DragonInstinct.ID);
            builder.HaveSpecificFeat(Guid.Parse("625d5b41-e03f-4456-a9a3-9b75a25890ea"), Feats.Instances.DragonsRageWings.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("81bbf12d-0dbe-4db2-859e-4b684ec23ca8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
