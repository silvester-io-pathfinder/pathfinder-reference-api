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
    public class SandstriderLizardfolk : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Sandstrider Lizardfolk"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your thick scales help you retain water and combat the sun's glare. You gain fire resistance equal to half your level (minimum 1). Environmental heat effects are one step less extreme for you, and you can go 10 times as long as normal before you are affected by starvation or thirst. However, unless you wear protective gear or take shelter, environmental cold effects are one step more extreme for you." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificDamageResistance(Guid.Parse(""), DamageTypes.Instances.Fire.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1);
            builder.ModifyTemperature(Guid.Parse(""), Temperature.Heat, ModifierType.Subtract, modifier: 1);
            builder.Manual(Guid.Parse(""), "You can go 10 times as long as normal before you are affected by starvation or thirst");
            builder.ModifyTemperature(Guid.Parse(""), Temperature.Cold, ModifierType.Add, modifier: 1);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CharacterGuide.ID,
                Page = 57
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Lizardfolk.ID;
        }
    }
}
