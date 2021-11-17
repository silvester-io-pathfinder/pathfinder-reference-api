using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DragonTransformation : Template
    {
        public static readonly Guid ID = Guid.Parse("8adb6d75-c0ed-4045-af81-7dd13bbbc873");

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
            yield return new TextBlock { Id = Guid.Parse("d9820ce1-8f4b-44be-9741-2ac823b52b32"), Type = TextBlockType.Text, Text = "You transform into a ferocious Large dragon, gaining the effects of 6th-level (spell: dragon form) except that you use your own AC and attack modifier; you also apply your extra damage from (feat: Rage). The action to (action: Dismiss) the transformation gains the (trait: rage) trait." };
            yield return new TextBlock { Id = Guid.Parse("a9e306e1-235a-4f2f-ab1e-facbc0138c40"), Type = TextBlockType.Text, Text = "At 18th level, you gain a +20-foot status bonus to your fly Speed, your damage bonus with dragon (action: Strikes | Strike) increases to +12, your breath weapon DC is your class DC, and you gain a +14 status bonus to your breath weapon damage." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInstinct(Guid.Parse("bc0fbe9d-412f-4467-930a-3bf312bf7a5a"), Instincts.Instances.DragonInstinct.ID);
            builder.HaveSpecificFeat(Guid.Parse("94f76a29-94df-4699-adc2-08a0bbaa44fa"), Feats.Instances.DragonsRageWings.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3d77a31d-395f-4bf2-a830-63796701b0e6"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
