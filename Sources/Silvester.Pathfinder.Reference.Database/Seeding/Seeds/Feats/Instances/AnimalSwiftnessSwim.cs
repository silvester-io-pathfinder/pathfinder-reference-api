using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AnimalSwiftnessSwim : Template
    {
        public static readonly Guid ID = Guid.Parse("e59a2e17-4fd5-41df-b602-db52879118b7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Animal Swiftness - Swim",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("abbdd34c-b3e3-4545-8302-0db466f0c585"), Type = TextBlockType.Text, Text = "You gain a swim Speed equal to your land Speed." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d6bb6499-0283-4ba2-95fd-5f4ab917d9ca"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
