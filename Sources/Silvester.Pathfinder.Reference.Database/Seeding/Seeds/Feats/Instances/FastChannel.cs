using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FastChannel : Template
    {
        public static readonly Guid ID = Guid.Parse("4595f140-b5c4-485d-bc39-3e0d41668363");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fast Channel",
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
            yield return new TextBlock { Id = Guid.Parse("2af168ec-dcf6-4b29-922a-4f39bfe56081"), Type = TextBlockType.Text, Text = "Divine power is always at your fingertips, swiftly responding to your call. When you cast (spell: harm) or (spell: heal) by spending 2 actions, you can get the effects of the 3-action version instead of the 2-action version." };
            yield return new TextBlock { Id = Guid.Parse("b8d774b4-a98e-4315-9bd4-61094da0e1dd"), Type = TextBlockType.Text, Text = "You can do this with (spell: harm) if you have harmful font or (spell: heal) if you have healing font (or both if you have (feat: Versatile Font))." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("39c7cedf-df8e-4a4d-a682-0b543dd9763e"), or => 
            {
                or.HaveSpecificDivineFont(Guid.Parse("7d7ca29b-072b-48c5-8665-e0bacdc0bd5a"), DivineFonts.Instances.Heal.ID);
                or.HaveSpecificDivineFont(Guid.Parse("a621304b-1989-495a-95eb-ea8474319aef"), DivineFonts.Instances.Harm.ID);
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
                Id = Guid.Parse("bec4f06a-dc15-43ca-8f89-0b30de421425"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
