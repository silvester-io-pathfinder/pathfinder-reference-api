using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PenetratingProjectile : Template
    {
        public static readonly Guid ID = Guid.Parse("e9f5d7de-c949-4239-80c5-86b394e46401");

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
            yield return new TextBlock { Id = Guid.Parse("83b2a416-7b46-47e8-ab45-540aafe32070"), Type = TextBlockType.Text, Text = "Your projectiles are unhindered by flesh and bone. Make a ranged (action: Strike) against each creature in a 30-foot line. These attacks ignore lesser cover, cover, and greater cover granted by creatures. Roll damage only once and apply it to each creature you hit. Each attack counts toward your multiple attack penalty, but don’t increase your penalty until you have made all your attacks." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2827d34f-810d-4106-acd2-54e87121dc62"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
