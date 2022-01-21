using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TendrilStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("47873304-9917-4570-88a4-f1d9603351c0");

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
            yield return new TextBlock { Id = Guid.Parse("d0e0bef1-c3d3-42cb-b4de-25be88d43e50"), Type = TextBlockType.Text, Text = "Stretching to extend its body to its limits, your eidolon attacks a foe that would normally be beyond its reach. Your eidolon makes a melee unarmed (action: Strike), increasing its reach by 5 feet for that (action: Strike). If the unarmed attack has the (trait: disarm), (trait: shove), or (trait: trip) trait, the eidolon can use the corresponding action instead of a (action: Strike)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("770cc166-e6f1-41c6-b793-5a241caee266"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
