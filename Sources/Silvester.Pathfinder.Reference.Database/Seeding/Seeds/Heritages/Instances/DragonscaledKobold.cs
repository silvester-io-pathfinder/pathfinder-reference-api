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
    public class DragonscaledKobold : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Dragonscaled Kobold"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your scales are especially colorful, possessing some of the same resistance a dragon possesses. You gain resistance equal to half your level (minimum 1) to the damage type associated with your draconic exemplar. Double this resistance against dragons’ Breath Weapons." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificDamageResistance(Guid.Parse(""), DamageTypes.Instances.Acid.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1, addendum: "Double this resistance against dragon's Breath weapons.")
                .AddPrerequisites(Guid.Parse(""), prerequisites => 
                {
                    prerequisites.AddOr(Guid.Parse(""), or => 
                    {
                        or.HaveSpecificDraconicExemplar(Guid.Parse(""), DraconicExemplars.Instances.Black.ID);
                        or.HaveSpecificDraconicExemplar(Guid.Parse(""), DraconicExemplars.Instances.Copper.ID);
                    });
                });

            builder.GainSpecificDamageResistance(Guid.Parse(""), DamageTypes.Instances.Electricity.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1, addendum: "Double this resistance against dragon's Breath weapons.")
                .AddPrerequisites(Guid.Parse(""), prerequisites =>
                {
                    prerequisites.AddOr(Guid.Parse(""), or =>
                    {
                        or.HaveSpecificDraconicExemplar(Guid.Parse(""), DraconicExemplars.Instances.Blue.ID);
                        or.HaveSpecificDraconicExemplar(Guid.Parse(""), DraconicExemplars.Instances.Bronze.ID);
                    });
                });

            builder.GainSpecificDamageResistance(Guid.Parse(""), DamageTypes.Instances.Poison.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1, addendum: "Double this resistance against dragon's Breath weapons.")
                .AddPrerequisites(Guid.Parse(""), prerequisites =>
                {
                    prerequisites.HaveSpecificDraconicExemplar(Guid.Parse(""), DraconicExemplars.Instances.Green.ID);
                });

            builder.GainSpecificDamageResistance(Guid.Parse(""), DamageTypes.Instances.Fire.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1, addendum: "Double this resistance against dragon's Breath weapons.")
                .AddPrerequisites(Guid.Parse(""), prerequisites =>
                {
                    prerequisites.AddOr(Guid.Parse(""), or =>
                    {
                        or.HaveSpecificDraconicExemplar(Guid.Parse(""), DraconicExemplars.Instances.Red.ID);
                        or.HaveSpecificDraconicExemplar(Guid.Parse(""), DraconicExemplars.Instances.Brass.ID);
                        or.HaveSpecificDraconicExemplar(Guid.Parse(""), DraconicExemplars.Instances.Gold.ID);
                    });
                });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 13
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Kobold.ID;
        }
    }
}
