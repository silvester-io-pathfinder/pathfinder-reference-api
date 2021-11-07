using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SignatureSpellExpansion : Template
    {
        public static readonly Guid ID = Guid.Parse("ee5adf43-5968-4046-aa96-40bc854adea5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Signature Spell Expansion",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c0b01772-7adc-4873-8c1b-e7796be8d16a"), Type = TextBlockType.Text, Text = "Your direct mental grasp of your power lets you cast more spells with greater freedom. You gain two additional signature spells, each of which must have a minimum level of 3rd or lower." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6bed8129-41d1-4fd8-850a-a1b2ee2f76db"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
