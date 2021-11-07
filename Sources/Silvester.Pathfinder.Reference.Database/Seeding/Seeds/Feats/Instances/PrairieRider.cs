using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PrairieRider : Template
    {
        public static readonly Guid ID = Guid.Parse("ca4d409f-838b-4586-ae16-df650d13d256");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Prairie Rider",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5b381c7a-88cb-4336-892a-20503524f56b"), Type = TextBlockType.Text, Text = "You grew up riding your clan’s shaggy ponies and riding dogs. You become trained in Nature. If you would automatically become trained in Nature (from your background or class, for example), you instead become trained in a skill of your choice. You also get a +1 circumstance bonus to (action: Command an Animal) if the target is a traditional halfling mount, such as a pony or riding dog." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8ec482db-c0ea-4aab-a63a-cf76f5c6c6c8"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
