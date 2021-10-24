using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Instincts.Instances
{
    public class AnimalInstinct : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Instinct GetInstinct()
        {
            return new Instinct
            {
                Id = ID, 
                ClassId = Classes.Instances.Barbarian.ID,
                Name = "Animal Instinct",
                Description = "The fury of a wild predator fills you when you Rage, granting you ferocious unarmed attacks. Cultures that revere vicious animals (such as apes or bears) give rise to barbarians with this instinct. You might also be at war with an uncontrollable, animalistic side of your personality, or you might be a descendant of a werewolf or another werecreature. Select an animal from the table Animal Instincts that best matches your chosen animal.",
                Anathema = "Flagrantly disrespecting an animal of your chosen kind is anathema to your instinct, as is using weapons while raging.",
                SpecializationAbility = "Increase the damage die size for the unarmed attacks granted by your chosen animal by one step, and increase the additional damage from Rage from 2 to 5 for your chosen animal's unarmed attacks. The frog's tongue attack and deer's antler attack gain reach 10 feet. If you have greater weapon specialization, increase the damage from Rage from 5 to 12 for your chosen animal's unarmed attacks.",
            };
        }

        protected override void GetInstinctAbilityEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificInstinctAbility(Guid.Parse(""), InstinctAbilities.Instances.BestialRage.ID);
        }

        protected override void GetRagingEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificDamageResistance(Guid.Parse(""), DamageTypes.Instances.Piercing.ID);
            builder.GainSpecificDamageResistance(Guid.Parse(""), DamageTypes.Instances.Slashing.ID);
        }

        protected override Table? GetTable()
        {
            return new TableBuilder()
                .AddColumn("", "Animal")
                .AddColumn("", "Attack")
                .AddColumn("", "Damage")
                .AddColumn("", "Traits")
                .AddRow("", row =>
                {
                    row
                        .AddCell("", "Ape")
                        .AddCell("", "Fist")
                        .AddCell("", "1d10 B")
                        .AddCell("", "Grapple, Unarmed");
                })
                .AddRow("", row =>
                {
                    row
                        .AddCell("", "Bear")
                        .AddCell("", "Jaws")
                        .AddCell("", "1d10 P")
                        .AddCell("", "Unarmed");
                })
                .AddRow("", row =>
                {
                    row
                        .AddCell("", "Bear")
                        .AddCell("", "Claw")
                        .AddCell("", "1d6 S")
                        .AddCell("", "Agile, Unarmed");
                })
                .AddRow("", row =>
                {
                    row
                        .AddCell("", "Bull")
                        .AddCell("", "Horn")
                        .AddCell("", "1d10 P")
                        .AddCell("", "Shove, Unarmed");
                })
                .AddRow("", row =>
                {
                    row
                        .AddCell("", "Cat")
                        .AddCell("", "Jaws")
                        .AddCell("", "1d10 P")
                        .AddCell("", "Unarmed");
                })
                .AddRow("", row =>
                {
                    row
                        .AddCell("", "Cat")
                        .AddCell("", "Claw")
                        .AddCell("", "1d6 S")
                        .AddCell("", "Agile, Unarmed");
                })
                .AddRow("", row =>
                {
                    row
                        .AddCell("", "Deer")
                        .AddCell("", "Antler")
                        .AddCell("", "1d10 P")
                        .AddCell("", "Grapple, Unarmed");
                })
                .AddRow("", row =>
                {
                    row
                        .AddCell("", "Frog")
                        .AddCell("", "Jaws")
                        .AddCell("", "1d10 B")
                        .AddCell("", "Unarmed");
                })
                .AddRow("", row =>
                {
                    row
                        .AddCell("", "Frog")
                        .AddCell("", "Tongue")
                        .AddCell("", "1d10 B")
                        .AddCell("", "Agile, Unarmed");
                })
                .AddRow("", row =>
                {
                    row
                        .AddCell("", "Shark")
                        .AddCell("", "Jaws")
                        .AddCell("", "1d10 P")
                        .AddCell("", "Grapple, Unarmed");
                })
                .AddRow("", row =>
                {
                    row
                        .AddCell("", "Snake")
                        .AddCell("", "Jaws")
                        .AddCell("", "1d10 P")
                        .AddCell("", "Grapple, Unarmed");
                })
                .AddRow("", row =>
                {
                    row
                        .AddCell("", "Wolf")
                        .AddCell("", "Jaws")
                        .AddCell("", "1d10 P")
                        .AddCell("", "Trip, Unarmed");
                })
                .Build("");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 86
            };
        }
    }
}
