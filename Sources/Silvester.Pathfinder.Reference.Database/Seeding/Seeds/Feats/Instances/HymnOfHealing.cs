using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HymnOfHealing : Template
    {
        public static readonly Guid ID = Guid.Parse("4215ab07-40f9-4f29-9a44-54c80f96206c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hymn of Healing",
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
            yield return new TextBlock { Id = Guid.Parse("ef4157d2-8026-4e4a-a488-b7a1a29f59ef"), Type = TextBlockType.Text, Text = "You learn the (spell: hymn of healing) composition spell, which imbues your music with rich melodies that help your allies recover from harm." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8660907d-c3f7-47a7-b6de-651a211f67f8"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
