using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SkilledPartner : Template
    {
        public static readonly Guid ID = Guid.Parse("7f4a1427-e6c1-47f0-8f25-f7d101c44fdd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Skilled Partner",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a44baade-2fe0-4b50-98d8-7facc054a88a"), Type = TextBlockType.Text, Text = "Your eidolon gains a 1st-level skill feat and a 2nd-level or lower skill feat. At 7th level, your eidolon gains an additional skill feat, of 7th level or lower." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("799a1cfe-f842-4ee8-a274-ff3ff927c67e"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
