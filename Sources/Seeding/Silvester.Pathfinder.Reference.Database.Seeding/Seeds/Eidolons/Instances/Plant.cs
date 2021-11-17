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
        public static readonly Guid ID = Guid.Parse("3ad849eb-fbde-4441-ab43-250640788f1b");

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
            builder.GainSpecificSpellCasting(Guid.Parse("8dbafc00-e4b6-45ac-ab2d-ada48af5f8d9"), MagicTraditions.Instances.Primal.ID);
        }

        protected override IEnumerable<EidolonVariant> GetVariants()
        {
            yield return new EidolonVariant
            {
                Id = Guid.Parse("89c6fcbd-6d93-477b-ab6d-6f2e00181d76"),
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
                Id = Guid.Parse("4ee15db4-ed98-4c84-acbb-afa22460ec90"),
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
                Id = Guid.Parse("e664d6f1-722c-41e9-a14f-2321970f17fe"),
                Name = "Tendrul Strike",
                Level = 1,
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("92d2ccee-904a-4620-b7b3-e03e7dd79eb1"), Type = TextBlockType.Text, Text = "Your eidolon can stretch out vines and roots, attacking foes outside its reach. It gains the Tendril Strike action."},
                },
                Effect = BooleanEffectBuilder.CreateAnd(Guid.Parse("3e245cf0-f810-4019-aa22-7e3f46974c61"), and =>
                {
                    and.GainSpecificFeat(Guid.Parse("4f1ac73b-c898-44f3-bf6b-37ab2ed45299"), Feats.Instances.TendrilStrike.ID);
                })
                .Build()
            };

            yield return new EidolonAbility
            {
                Id = Guid.Parse("80d89706-f8e7-4a69-a7c1-f5f3364f2494"),
                Name = "Growing Vines",
                Level = 7,
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("fff39d8d-fbea-4ed8-bf2b-c6155fd8fad9"), Type = TextBlockType.Text, Text = "Your eidolon's vines and branches lengthen even more. All your eidolon's melee unarmed attacks gain the reach trait."},
                },
                Effect = BooleanEffectBuilder.CreateAnd(Guid.Parse("a08c4018-cd98-4ddb-85fd-0a7d543383f8"), and =>
                {
                    //TODO: Add effects.
                })
                .Build()
            };

            yield return new EidolonAbility
            {
                Id = Guid.Parse("4ae465be-ee17-49d6-826c-86a216cf3ae5"),
                Name = "Field of Roots",
                Level = 17,
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("6348d6bc-de4f-4b64-a2a9-04b453de3b68"), Type = TextBlockType.Text, Text = "Your eidolon learns how to send its roots underground to hinder foes. It gains the Field of Roots activity."},
                },
                Effect = BooleanEffectBuilder.CreateAnd(Guid.Parse("400cac4c-e684-436e-9c39-aa054e4b15c4"), and =>
                {
                    and.GainSpecificFeat(Guid.Parse("8d0ba8c9-0c40-41b2-94f5-2ae9773bbce3"), Feats.Instances.FieldOfRoots.ID);
                })
                .Build()
            };
        }

        protected override IEnumerable<EidolonHomePlane> GetHomePlanes()
        {
            yield return new EidolonHomePlane
            {
                Id = Guid.Parse("3a3a80b1-31b2-429b-80a7-dc7bd6249259"),
                PlaneId = Planes.Instances.MaterialPlane.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("edf5a157-b324-4af7-bbe8-6e702b5cde29"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page =  65
            };
        }
    }
}
