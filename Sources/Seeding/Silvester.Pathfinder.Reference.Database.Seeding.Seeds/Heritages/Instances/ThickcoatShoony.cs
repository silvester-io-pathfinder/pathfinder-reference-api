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
    public class ThickcoatShoony : Template
    {
        public static readonly Guid ID = Guid.Parse("fac9a959-1682-4766-b0e7-88dc288aacec");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Thickcoat Shoony"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("1989dca0-654d-4770-a9db-61e7736ab935"), Type = TextBlockType.Text, Text = "You are a rare shoony who hails from colder climes. You gain cold resistance equal to half your level (minimum 1), and you treat environmental cold effects as if they were one step less extreme (incredible cold becomes extreme, extreme cold becomes severe, and so on). You don't need to succeed at a flat check to target a concealed creature if that creature is concealed only by snow. Unless you wear protective gear or take shelter, environmental heat effects are one step more extreme for you." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificDamageResistance(Guid.Parse("064a8afb-64f6-4176-a8b3-577a2164749b"), DamageTypes.Instances.Cold.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1);
            builder.ModifyTemperature(Guid.Parse("426d571e-c5f0-451e-b133-dc0d296d6fcf"), Temperature.Cold, ModifierType.Subtract, modifier: 1);
            builder.Manual(Guid.Parse("fe01f14a-f2f2-4c4f-9b1d-c0f6cd07aeca"), "You don't need to succeed at a flat check to target a concealed creature if that creature is concealed only by snow.");
            builder.ModifyTemperature(Guid.Parse("a83400ba-122a-47e0-a932-f61cc2bf03fd"), Temperature.Heat, ModifierType.Add, modifier: 1);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6f783378-39fb-43bc-b0cd-ee943bf58883"),
                SourceId = Sources.Instances.Pathfinder153.ID,
                Page = 71
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Shoony.ID;
        }
    }
}
