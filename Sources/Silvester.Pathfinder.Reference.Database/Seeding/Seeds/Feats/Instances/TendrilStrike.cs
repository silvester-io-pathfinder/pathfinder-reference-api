using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TendrilStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("c54fc769-3001-4697-83c6-074601d316b9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tendril Strike",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("71c27130-da73-4a44-a8e8-a1362bdafd80"), Type = TextBlockType.Text, Text = "Stretching to extend its body to its limits, your eidolon attacks a foe that would normally be beyond its reach. Your eidolon makes a melee unarmed (action: Strike), increasing its reach by 5 feet for that (action: Strike). If the unarmed attack has the (trait: disarm), (trait: shove), or (trait: trip) trait, the eidolon can use the corresponding action instead of a (action: Strike)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("92a87a62-f147-40d6-bb18-24f3055e9b21"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
