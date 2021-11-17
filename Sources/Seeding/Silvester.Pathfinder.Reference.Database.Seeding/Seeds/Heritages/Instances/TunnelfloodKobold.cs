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
    public class TunnelfloodKobold : Template
    {
        public static readonly Guid ID = Guid.Parse("767af1a6-a57f-4747-a674-83d89c6748fb");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Tunnelflood Kobold"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("4a3b556b-f25d-45d8-a4c4-cfe36cc10060"), Type = TextBlockType.Text, Text = "You grew up in a warren crisscrossed by underwater passages, whether natural or excavated. You gain a swim Speed of 15 feet." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpeed(Guid.Parse("19d8bb4b-d9f4-4f72-8cf6-3cf6040dbf62"), MovementMethod.Swimming, speed: 15);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0e01c2be-d739-4f00-85e0-3fa740c12bdd"),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 37
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Kobold.ID;
        }
    }
}
