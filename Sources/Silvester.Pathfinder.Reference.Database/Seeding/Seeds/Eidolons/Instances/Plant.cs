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
    public class Plant : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Eidolon GetEidolon()
        {
            return new Eidolon
            {
                Id = ID, 
                Name = "Plant",
                Description = "Your eidolon is an intelligent plant, formed from the same disembodied fragments of nature's life energy that become leshys. Plant eidolons tend to be curious and adaptable, with temperaments based on the parts of mortal culture they feel affinity toward. Despite coming from the same source, plant eidolons don't always look like leshys. Plant eidolons have forms that vary greatly and can look like almost any kind of plant creature in existence. Some even resemble plant creatures so strange they are impossible to identify.",
                SuggestedAttacks = "vine (bludgeoning), branch (bludgeoning), root (bludgeoning)",
                LanguageId = Languages.Instances.Sylvan.ID,
                MagicTraditionId = MagicTraditions.Instances.Primal.ID,
            };
        }

        protected override IEnumerable<Guid> GetRequiredAlignments()
        {
            yield break;
        }

        protected override IEnumerable<Guid> GetSenses()
        {
            yield return Senses.Instances.LowLightVision.ID;
        }

        protected override IEnumerable<Guid> GetSkills()
        {
            yield return Skills.Instances.Nature.ID;
            yield return Skills.Instances.Survival.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Eidolon.ID;
            yield return Traits.Instances.Plant.ID;
        }

        protected override IEnumerable<Guid> GetSizes()
        {
            yield return AncestrySizes.Instances.Medium.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellCasting(Guid.Parse(""), MagicTraditions.Instances.Primal.ID);
        }

        protected override IEnumerable<EidolonVariant> GetVariants()
        {
            yield return new EidolonVariant
            {
                Id = Guid.Parse(""),
                Name = "Creeping Plant",
                Strength = 12,
                Dexterity = 18,
                Constitution = 16,
                Intelligence = 8,
                Wisdom = 14,
                Charisma = 10,
                ArmorClass = 1,
                DexterityCap = 4
            };

            yield return new EidolonVariant
            {
                Id = Guid.Parse(""),
                Name = "Guardian Plant",
                Strength = 18,
                Dexterity = 14,
                Constitution = 16,
                Intelligence = 8,
                Wisdom = 12,
                Charisma = 10,
                ArmorClass = 2,
                DexterityCap = 3
            };
        }

        protected override IEnumerable<EidolonAbility> GetAbilities()
        {
            yield return new EidolonAbility
            {
                Id = Guid.Parse(""),
                Name = "Tendrul Strike",
                Level = 1,
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your eidolon can stretch out vines and roots, attacking foes outside its reach. It gains the Tendril Strike action."},
                },
                Effect = BooleanEffectBuilder.CreateAnd(Guid.Parse(""), and =>
                {
                    and.GainSpecificFeat(Guid.Parse(""), Feats.Instances.TendrilStrike.ID);
                })
                .Build()
            };

            yield return new EidolonAbility
            {
                Id = Guid.Parse(""),
                Name = "Growing Vines",
                Level = 7,
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your eidolon's vines and branches lengthen even more. All your eidolon's melee unarmed attacks gain the reach trait."},
                },
                Effect = BooleanEffectBuilder.CreateAnd(Guid.Parse(""), and =>
                {
                    //TODO: Add effects.
                })
                .Build()
            };

            yield return new EidolonAbility
            {
                Id = Guid.Parse(""),
                Name = "Field of Roots",
                Level = 17,
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your eidolon learns how to send its roots underground to hinder foes. It gains the Field of Roots activity."},
                },
                Effect = BooleanEffectBuilder.CreateAnd(Guid.Parse(""), and =>
                {
                    and.GainSpecificFeat(Guid.Parse(""), Feats.Instances.FieldOfRoots.ID);
                })
                .Build()
            };
        }

        protected override IEnumerable<EidolonHomePlane> GetHomePlanes()
        {
            yield return new EidolonHomePlane
            {
                Id = Guid.Parse(""),
                PlaneId = Planes.Instances.MaterialPlane.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page =  65
            };
        }
    }
}
