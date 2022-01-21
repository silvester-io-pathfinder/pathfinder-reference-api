using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Eidolons.Instances
{
    public class Construct : Template
    {
        public static readonly Guid ID = Guid.Parse("b2e2672c-dd2c-44a9-a6a2-78855d975c27");

        protected override Eidolon GetEidolon()
        {
            return new Eidolon
            {
                Id = ID, 
                Name = "Construct",
                Description = "Your eidolon is a mental construct based on an astral thoughtform and given physical presence and life by its connection to you, its shape limited only by your imagination. Your eidolon's appearance and physical form vary based on your shared vision for its construction, from clockworks to stuffed dolls and everything between, and it's not uncommon for that appearance to change greatly as your construct gains evolutions. Because it arises from an astral entity, your construct is no mindless servitor, but a fully thinking being with its own ideas, goals, and even emotions. These entities are extremely diverse; while many construct eidolons come from a powerful symbiotic connection with astral denizens, just as many arise from the forgotten memories of ancient empires and craftworks drifting across the Silver Sea of the Astral Plane.",
                SuggestedAttacks = "fist (bludgeoning)",
                LanguageId = Languages.Instances.Common.ID,
                MagicTraditionId = MagicTraditions.Instances.Arcane.ID,
            };
        }

        protected override IEnumerable<Guid> GetRequiredAlignments()
        {
            yield break;
        }

        protected override IEnumerable<Guid> GetSenses()
        {
            yield return Senses.Instances.Darkvision.ID;
        }

        protected override IEnumerable<Guid> GetSkills()
        {
            yield return Skills.Instances.Arcana.ID;
            yield return Skills.Instances.Crafting.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Astral.ID;
            yield return Traits.Instances.Construct.ID;
            yield return Traits.Instances.Eidolon.ID;
        }

        protected override IEnumerable<Guid> GetSizes()
        {
            yield return AncestrySizes.Instances.Medium.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellCasting(Guid.Parse("37eff77f-caa3-4d24-9a27-2629b017d6df"), MagicTraditions.Instances.Arcane.ID);
        }

        protected override IEnumerable<EidolonVariant> GetVariants()
        {
            yield return new EidolonVariant
            {
                Id = Guid.Parse("b0c83586-b465-41cb-a213-dd8258b3b59f"),
                Name = "Scout Construct",
                Strength = 14,
                Dexterity = 18,
                Constitution = 16,
                Intelligence = 12,
                Wisdom = 10,
                Charisma = 8,
                ArmorClass = 1,
                DexterityCap = 4
            };

            yield return new EidolonVariant
            {
                Id = Guid.Parse("3174ae04-2695-4b82-92fa-0a81408cea80"),
                Name = "Warrior Construct",
                Strength = 18,
                Dexterity = 14,
                Constitution = 16,
                Intelligence = 12,
                Wisdom = 10,
                Charisma = 8,
                ArmorClass = 2,
                DexterityCap = 3
            };
        }

        protected override IEnumerable<EidolonAbility> GetAbilities()
        {
            yield return new EidolonAbility
            {
                Id = Guid.Parse("a5716bfb-e740-4dd4-a1ea-e3ab5a62d84c"),
                Name = "Construct",
                Level = 1,
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("1bbcbb88-1035-447a-a627-cfa3297b1207"), Type = TextBlockType.Text, Text = "Your construct eidolon has a link directly to your life force, which renders it a living creature and therefore susceptible to many ailments that bother only the living, though it does possess some resistances to these effects. It doesn't have a construct's normal immunities, but does gain a +2 circumstance bonus to saving throws against death effects, disease, necromancy, and poison effects, as well as effects causing the fatigued or sickened conditions. Additionally, its astral essence bleeds off slowly, and it only needs to succeed at a DC 10 flat check to remove persistent bleed damage (or DC 5 after receiving particularly effective aid)."},
                },
                Effect = BooleanEffectBuilder.CreateAnd(Guid.Parse("4f5fa3ce-90cf-4146-9ed4-2c393a026480"), and =>
                {
                    //TODO: Add effects.
                })
                .Build()
            };

            yield return new EidolonAbility
            {
                Id = Guid.Parse("12595aeb-96fa-4304-b432-92ba1d63f2e4"),
                Name = "Reconfigured Evolution",
                Level = 7,
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("5829e54d-2c74-426d-b699-5be3a9e586fe"), Type = TextBlockType.Text, Text = "Your construct eidolon is particularly easy to reconfigure, gaining an additional evolution that suits both of your whims. Choose one additional evolution feat of 6th level or lower. Your eidolon gains that feat. You can Retrain this feat for any other evolution feat of 6th level or lower with only a single day of downtime if you succeed at a Crafting check, with a standard DC of your eidolon's level. If you fail, you can try again on a later day. Many summoners choose Eidolon's Wrath for this ability."},
                },
                Effect = BooleanEffectBuilder.CreateAnd(Guid.Parse("74bf0611-f082-48f7-ae92-0b6f740f7e24"), and =>
                {
                    //TODO: Add effects.
                })
                .Build()
            };

            yield return new EidolonAbility
            {
                Id = Guid.Parse("f7a1a4e3-bfce-46a4-bba5-8882e6abac9e"),
                Name = "Ultimate Reconfiguration",
                Level = 17,
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("0247e3ad-a51c-44a6-b93d-b7238afa3a60"), Type = TextBlockType.Text, Text = "Your construct eidolon becomes even more customizable. Choose an evolution feat of 16th level or lower. Your eidolon gains that feat. You can spend downtime to adjust it using Crafting, just like the feat from reconfigured evolution. Many summoners select Ever-Vigilant Senses for this ability."},
                },
                Effect = BooleanEffectBuilder.CreateAnd(Guid.Parse("74cba162-b750-4694-b363-fd539a5fa8c3"), and =>
                {
                    //TODO: Add effects.
                })
                .Build()
            };
        }

        protected override IEnumerable<EidolonHomePlane> GetHomePlanes()
        {
            yield return new EidolonHomePlane
            {
                Id = Guid.Parse("9a450d22-7e7b-4fac-b47a-569634d5a32d"),
                PlaneId = Planes.Instances.AstralPlane.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("14cfbb41-0257-4e17-9a67-341772a5a52f"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 61
            };
        }
    }
}
