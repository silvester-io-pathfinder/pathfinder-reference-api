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
    public class Fey : Template
    {
        public static readonly Guid ID = Guid.Parse("b056f700-b377-4f32-a033-16804be34af1");

        protected override Eidolon GetEidolon()
        {
            return new Eidolon
            {
                Id = ID, 
                Name = "Fey",
                Description = "Your eidolon is a fey, a capricious being of the mysterious First World. Many fey appear similar to mortal humanoids with unusual features such as pointed ears, wings, or bodies composed of natural elements, but the full variety of fey is endless, and many others appear completely inhuman. Fey from the First World never truly die, instead forming a new creature. Fey eidolons usually come about when a summoner helps stabilize a difficult reformation. This means your fey eidolon likely lived a different life just before meeting you and might remember fragments of its old memories. Together, you might have to unravel a memory from your eidolon's past life among the fey.",
                SuggestedAttacks = "fist (bludgeoning), wing (bludgeoning), attacks shaped like a weapon",
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
            yield return Skills.Instances.Deception.ID;
            yield return Skills.Instances.Nature.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Eidolon.ID;
            yield return Traits.Instances.Fey.ID;
        }

        protected override IEnumerable<Guid> GetSizes()
        {
            yield return AncestrySizes.Instances.Small.ID;
            yield return AncestrySizes.Instances.Medium.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellCasting(Guid.Parse("8ebb4a3a-bcf7-4654-8aa0-5e6b15e1664a"), MagicTraditions.Instances.Primal.ID);
        }

        protected override IEnumerable<EidolonVariant> GetVariants()
        {
            yield return new EidolonVariant
            {
                Id = Guid.Parse("03627bfc-b6c6-4d9b-b78d-3fc1c211e2e5"),
                Name = "Skirmisher Fey",
                Strength = 14,
                Dexterity = 18,
                Constitution = 14,
                Intelligence = 10,
                Wisdom = 10,
                Charisma = 12,
                ArmorClass = 1,
                DexterityCap = 4
            };

            yield return new EidolonVariant
            {
                Id = Guid.Parse("bf175be6-b1fa-47ff-a0b9-7da8ea80d010"),
                Name = "Trickster Fey",
                Strength = 12,
                Dexterity = 18,
                Constitution = 12,
                Intelligence = 12,
                Wisdom = 8,
                Charisma = 16,
                ArmorClass = 1,
                DexterityCap = 4
            };
        }

        protected override IEnumerable<EidolonAbility> GetAbilities()
        {
            yield return new EidolonAbility
            {
                Id = Guid.Parse("5db252d6-24c7-47fb-91d8-c353982cde17"),
                Name = "Fey Gift Spells",
                Level = 1,
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("585e6b1a-be4b-4c93-ab8c-bda3cd303538"), Type = TextBlockType.Text, Text = "Your eidolon expands your primal magic with enchantment and illusion magic, allowing both of you to wield the power of fey charm and glamour. When you add spells to your repertoire, you can choose from the primal list as well as from enchantment and illusion spells that appear on the arcane spell list. As usual for when you add spells of a different tradition to your spell list, you're still a primal spellcaster, so all of your spells are primal spells."},
                    new TextBlock {Id = Guid.Parse("7cd52967-7160-4ffb-ac7b-f1fcc4242570"), Type = TextBlockType.Text, Text = "Your eidolon gains the Magical Understudy summoner feat, despite not meeting the prerequisite level, and it can choose fey gift cantrips in addition to primal cantrips. As usual for a feat you are granted by name, you can't retrain Magical Understudy into another feat."},
                },
                Effect = BooleanEffectBuilder.CreateAnd(Guid.Parse("75a0058a-236f-4b21-ba9f-632d8365199a"), and =>
                {
                    //TODO: Add effects.
                })
                .Build()
            };

            yield return new EidolonAbility
            {
                Id = Guid.Parse("195e54ed-ea50-46dd-b935-7972a59e6023"),
                Name = "Fey Mischief",
                Level = 7,
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("740d0a4d-52c7-4c4a-944b-c6b53512d0ea"), Type = TextBlockType.Text, Text = "Your eidolon's fey magic becomes more powerful and mischievous. Your eidolon gains the Magical Adept feat, despite not meeting the prerequisite level, and can choose from fey gift spells in addition to primal spells."},
                },
                Effect = BooleanEffectBuilder.CreateAnd(Guid.Parse("c7a6e6d6-5bab-4b58-944f-a96c36b3fa3c"), and =>
                {
                    //TODO: Add effects.
                })
                .Build()
            };

            yield return new EidolonAbility
            {
                Id = Guid.Parse("df70c14d-f998-4023-a319-db7b80028ce4"),
                Name = "Fey Chicanery",
                Level = 17,
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("d0eb9df0-2e50-4ce9-9744-f10ca07b9d12"), Type = TextBlockType.Text, Text = "Ever full of tricks, your fey eidolon twists magical protections into your shared life force, granting it a contingency in its back pocket for desperate situations. During your daily preparations, your eidolon can cast a contingency spell. The 4th-level spell it chooses must come from the primal or fey gift list, and must either be common or be another spell you have access to."},
                },
                Effect = BooleanEffectBuilder.CreateAnd(Guid.Parse("c9f5b5f5-5333-4ae6-86b5-22af8849844b"), and =>
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
                Id = Guid.Parse("258d435a-9389-4b27-acbf-214b68fbfc9e"),
                PlaneId = Planes.Instances.FirstWorld.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("87a4a815-f251-4d79-956d-b59e5cc10737"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 64
            };
        }
    }
}
