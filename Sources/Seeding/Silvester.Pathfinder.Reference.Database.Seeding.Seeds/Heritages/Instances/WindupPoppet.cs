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
    public class WindupPoppet : Template
    {
        public static readonly Guid ID = Guid.Parse("8c639a47-c40d-4cd1-94c9-a65612f24019");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Windup Poppet"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("4a3567fd-882e-48e0-a86f-3d75ee7daf26"), Type = TextBlockType.Text, Text = "You're made primarily of soft metals, such as tin or silver, and your life force dwells within an exceptional array of clockworks deep in your body. Provided you wind metal tabs on your body a few times each day, you don't need food or water to survive. You must still breathe to ventilate your internal mechanisms and sleep to give your mechanisms rest, just like other poppets." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.Manual(Guid.Parse("c854fdb2-1b0b-4348-be61-2af9d51281f0"), "Provided you wind metal tabs on your body a few times each day, you don't need food or water to survive.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bf5313a0-d2cc-4a13-9028-53280343dadd"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 63
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Poppet.ID;
        }
    }
}
