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
    public class WavediverTengu : Template
    {
        public static readonly Guid ID = Guid.Parse("61cc4e47-5b7e-43b1-affe-0489055a712f");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Wavediver Tengu"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("2e72dde0-a678-4cfd-80e5-55c48a782eaf"), Type = TextBlockType.Text, Text = "You're one of the rare tengu who can cut through water like a bird through air, and you often lurk in rivers or oceans where few expect you. You gain a swim Speed of 15 feet." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpeed(Guid.Parse("d99e9b96-c698-4442-9517-7b3365494e9e"), MovementMethod.Swimming, speed: 15);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7ff4df81-8bb7-4288-92db-557ccb1a49da"),
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
