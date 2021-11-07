using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PenetratingProjectile : Template
    {
        public static readonly Guid ID = Guid.Parse("408371d5-bd32-4ddb-9f53-ba4913b2948f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Penetrating Projectile",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("580fb904-e82d-4023-897a-dcbfd1aacfc2"), Type = TextBlockType.Text, Text = "Your projectiles are unhindered by flesh and bone. Make a ranged (action: Strike) against each creature in a 30-foot line. These attacks ignore lesser cover, cover, and greater cover granted by creatures. Roll damage only once and apply it to each creature you hit. Each attack counts toward your multiple attack penalty, but don’t increase your penalty until you have made all your attacks." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("844f90f8-5ca4-4032-bdc3-10ec4991a4f4"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
