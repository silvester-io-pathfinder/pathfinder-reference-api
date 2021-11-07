using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MysteryConduit : Template
    {
        public static readonly Guid ID = Guid.Parse("bbdc6455-c705-4326-9194-f9bca5243210");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mystery Conduit",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("aa9fb42d-aace-4226-9bdf-e40da3cf1aaf"), Type = TextBlockType.Text, Text = "The power of your mystery enables you to cast more than just revelation spells. When you cast a spell of 5th level or lower that has no duration, instead of spending a spell slot, you can advance the effects of your oracular curse in the same manner as when you cast a revelation spell. A spell cast in this way gains the (trait: cursebound) trait." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9a0389b6-3949-4351-9c03-f65415ff5cd2"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
