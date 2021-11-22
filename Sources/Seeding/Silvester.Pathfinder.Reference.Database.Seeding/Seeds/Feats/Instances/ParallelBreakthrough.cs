using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ParallelBreakthrough : Template
    {
        public static readonly Guid ID = Guid.Parse("fe496055-3110-480c-a873-d39e5ef6c989");

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
            yield return new TextBlock { Id = Guid.Parse("3508ac8b-9264-4b21-bc4e-46f85b426001"), Type = TextBlockType.Text, Text = "You expand your mind beyond your area of psychic specialty. You gain the unique surface psi cantrip for a conscious mind other than your own. You don't gain any other benefits of that conscious mind, such as additional spells known or the amps for the other surface cantrips." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5aa18555-f542-40cc-9cd8-c688c8448d75"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
