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
    public class DogtoothTengu : Template
    {
        public static readonly Guid ID = Guid.Parse("9375a5a5-9495-48b9-b5ae-889df7ac4221");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Dogtooth Tengu"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("ce2dfe43-0895-4854-972b-b4526c9654ef"), Type = TextBlockType.Text, Text = "In addition to a beak, your mouth also features a number of vicious, pointed teeth. Some legends claim your powerful jaws can even bite through steel. While you aren't that strong yet, your fangs can still leave terrible wounds. Your beak unarmed attack gains the deadly d8 trait." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.Manual(Guid.Parse("39ac89f7-d310-4dbe-900c-0c4386f3f4ae"), "Your beak unarmed attack gains the deadly d8 trait.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ea6c11de-3bde-4a0f-871a-b1addcee661f"),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 57
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Tengu.ID;
        }
    }
}
