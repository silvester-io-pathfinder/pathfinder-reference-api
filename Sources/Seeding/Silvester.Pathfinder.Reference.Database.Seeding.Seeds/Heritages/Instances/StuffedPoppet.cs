using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class StuffedPoppet : Template
    {
        public static readonly Guid ID = Guid.Parse("d262dbba-19ed-47e3-b6b5-8f67ba924250");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Stuffed Poppet"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("98912d7a-714c-4f94-8df9-01091db65732"), Type = TextBlockType.Text, Text = "You have little inside you other than cotton, sawdust, or dried leaves. You take no damage from falling, regardless of the distance you fall." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ModifyFallDistance(Guid.Parse("c4749474-7f7d-4e9b-978c-a381c017af67"), ModifierType.Multiply, modifier: 0);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("23f0924a-b82d-4bad-ab44-83b343e1e0cd"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 62
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Poppet.ID;
        }
    }
}
