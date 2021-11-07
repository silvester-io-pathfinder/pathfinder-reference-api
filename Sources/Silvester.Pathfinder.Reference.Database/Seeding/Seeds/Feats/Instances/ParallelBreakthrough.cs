using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ParallelBreakthrough : Template
    {
        public static readonly Guid ID = Guid.Parse("72a9f14c-f8d4-4722-9acd-40e104fcc9a9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Parallel Breakthrough",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("80db379d-6c0e-4f00-bf66-32829b11b1e3"), Type = TextBlockType.Text, Text = "You expand your mind beyond your area of psychic specialty. You gain the unique surface psi cantrip for a conscious mind other than your own. You don’t gain any other benefits of that conscious mind, such as additional spells known or the amps for the other surface cantrips." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a1278aaa-2bcc-4e9e-abb7-41b35a0cc636"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
