using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ThunderGodsFan : Template
    {
        public static readonly Guid ID = Guid.Parse("b0e3e92e-2bb8-4149-925b-bc4a63186356");

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
            yield return new TextBlock { Id = Guid.Parse("9a3336fe-dfb2-4ebb-bbe7-c386efa38198"), Type = TextBlockType.Text, Text = "A wave of your fan unleashes the fury of the storm. You can (action: Activate | Activate an Item) your (item: tengu feather fan) one additional time per day. Add the 5th-level (spell: lightning bolt) spell to the spells contained within your fan." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2abb8991-f3fe-42dd-a7a9-dec6ec3ad74a"), Feats.Instances.WindGodsFan.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4eab6734-6b7e-4e5b-b79c-289d9898a688"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
