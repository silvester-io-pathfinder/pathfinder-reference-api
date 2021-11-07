using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ThunderGodsFan : Template
    {
        public static readonly Guid ID = Guid.Parse("aeee21ec-c451-426e-b160-febafd664d19");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Thunder God's Fan",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0660da44-f6d7-4d9e-8131-843397baa425"), Type = TextBlockType.Text, Text = "A wave of your fan unleashes the fury of the storm. You can (action: Activate | Activate an Item) your (item: tengu feather fan) one additional time per day. Add the 5th-level (spell: lightning bolt) spell to the spells contained within your fan." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("04a421d8-6e8a-4896-b1b1-37a9522a6063"), Feats.Instances.WindGodsFan.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d9addc38-a888-42c2-825c-183886c0fc9e"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
