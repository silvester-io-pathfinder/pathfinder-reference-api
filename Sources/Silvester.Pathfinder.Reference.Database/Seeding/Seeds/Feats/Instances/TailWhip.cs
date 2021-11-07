using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TailWhip : Template
    {
        public static readonly Guid ID = Guid.Parse("038044c4-4fdf-4487-aaae-f8131c38a139");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tail Whip",
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
            yield return new TextBlock { Id = Guid.Parse("0d538ae0-e938-4445-b937-7cff8a5821db"), Type = TextBlockType.Text, Text = "By birth or through training, your tail is strong enough to make for a powerful melee weapon. You gain a tail unarmed attack that deals 1d6 bludgeoning damage and has the sweep trait." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("603bb299-63da-46fe-a877-ab6d335301f1"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
