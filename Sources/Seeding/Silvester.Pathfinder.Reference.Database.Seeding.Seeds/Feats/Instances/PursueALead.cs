using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PursueALead : Template
    {
        public static readonly Guid ID = Guid.Parse("0cd90c8d-e12c-49a2-853e-79157d51b155");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Pursue a Lead",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per 10 minutes"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ba1f0f92-43f3-4ade-b6cf-e4c9300732ad"), Type = TextBlockType.Text, Text = $"You spend 1 minute examining the details of one potential clue, designating the subject related to that clue as the target of your active investigation. This subject is typically a single creature, item, or small location (such as a room or corridor), but the GM might allow a different scope for your investigation. You don't need to know the identity, purpose, or nature of the subject, but you do need to be aware of its existence. For instance, finding a footprint is enough to investigate the creature that left it, and seeing a hasty sketch of an item or location can be enough to start your investigation of that subject." };
            yield return new TextBlock { Id = Guid.Parse("b2665bf7-1b08-4c86-a5f9-863ceaede4d5"), Type = TextBlockType.Text, Text = $"Whenever you attempt a Perception or skill check to investigate a designated subject, you gain a +1 circumstance bonus to the check. The exact checks this applies to depend on the actions you use to investigate and are determined by the GM, but checks to investigate are typically Perception checks or skill checks that use Intelligence, Wisdom, or Charisma." };
            yield return new TextBlock { Id = Guid.Parse("9caea5f2-b095-4bb4-b03c-0ad4e9ca1cde"), Type = TextBlockType.Text, Text = $"You can maintain two active investigations at a time. If you Pursue another Lead after that, the subject must be different from any of your current investigations (or rather, they must be different as far as you know), and you give up on a current subject of your choice. Once you've given up pursuit of a subject, you can't Pursue that Lead again until after the next time you make your daily preparations." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("62ee3a26-e412-4f12-9ff5-ca363ee0e758"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
