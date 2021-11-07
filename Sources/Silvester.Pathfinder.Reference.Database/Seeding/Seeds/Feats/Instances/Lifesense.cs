using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Lifesense : Template
    {
        public static readonly Guid ID = Guid.Parse("14492547-a45a-4de2-8cc2-2bdfec863d81");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lifesense",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c6b3c2b6-c6ec-417b-adc7-fe01b70c940f"), Type = TextBlockType.Text, Text = "You have a limited ability to sense life force, like your psychopomp forebears. You gain lifesense as an imprecise sense with a range of 10 feet. This allows you to sense the life force within living creatures and its counterforce that animates the undead, though you can&#39;t distinguish between the two." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("db29c8ab-43f7-452f-af3d-02b7dfb93276"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
