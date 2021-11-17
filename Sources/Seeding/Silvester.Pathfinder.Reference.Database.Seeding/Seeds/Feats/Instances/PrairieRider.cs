using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PrairieRider : Template
    {
        public static readonly Guid ID = Guid.Parse("c16ba51a-c327-42dc-98ce-43378566b8a2");

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
            yield return new TextBlock { Id = Guid.Parse("e712ebc3-e118-44c5-86fd-efc85c913f3b"), Type = TextBlockType.Text, Text = "You grew up riding your clan’s shaggy ponies and riding dogs. You become trained in Nature. If you would automatically become trained in Nature (from your background or class, for example), you instead become trained in a skill of your choice. You also get a +1 circumstance bonus to (action: Command an Animal) if the target is a traditional halfling mount, such as a pony or riding dog." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e1d94900-55a5-4503-9146-c1747bdabcd6"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
