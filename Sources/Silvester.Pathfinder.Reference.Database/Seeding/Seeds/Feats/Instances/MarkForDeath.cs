using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MarkForDeath : Template
    {
        public static readonly Guid ID = Guid.Parse("a45247b3-c778-4b6f-8158-c03fe427e759");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mark for Death",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("84a8907f-6b4b-4f77-bbae-e46e48622be4"), Type = TextBlockType.Text, Text = "You designate a single creature as your mark. This lasts until the mark dies or you use Mark for Death again." };
            yield return new TextBlock { Id = Guid.Parse("2d1275ff-323f-45ce-a7c9-974baf256f64"), Type = TextBlockType.Text, Text = "You gain a +2 circumstance bonus to Perception checks to (action: Seek) your mark and on Deception checks to (action: Feint) against your mark. Your (trait: agile) and (trait: finesse) weapons and unarmed attacks gain the (trait: backstabber) and (trait: deadly d6) weapon traits when you’re attacking your mark. If the weapon or unarmed attack already has the (trait: deadly) trait, increase the size of the deadly damage die by one step instead of giving it deadly d6." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2fcc0e55-ddcf-46a3-b914-a7a6320fdf23"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
