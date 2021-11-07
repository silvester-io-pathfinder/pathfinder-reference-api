using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BoardingAssault : Template
    {
        public static readonly Guid ID = Guid.Parse("4274f206-2c54-41fe-aedb-a878b83beef7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Boarding Assault",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a6d10c1e-29d4-4641-a4e4-5fd0ee64b5a3"), Type = TextBlockType.Text, Text = "Either (action: Stride) twice or attempt an Acrobatics check (DC determined by the GM, but usually DC 20) to swing on a rope up to twice your Speed. If you boarded or disembarked from a boat or similar vehicle during this movement, you can make a melee (action: Strike) that deals one additional weapon damage die." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("45371c0d-99f8-4186-a6d8-30c1e793ab94"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
