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
        public static readonly Guid ID = Guid.Parse("");

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
            builder.GainSpecificSpellCasting(Guid.Parse(""), MagicTraditions.Instances.Primal.ID);
        }

        protected override IEnumerable<EidolonVariant> GetVariants()
        {
            yield return new EidolonVariant
            {
                Id = Guid.Parse(""),
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
                Id = Guid.Parse(""),
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
                Id = Guid.Parse(""),
                Name = "Fey Gift Spells",
                Level = 1,
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your eidolon expands your primal magic with enchantment and illusion magic, allowing both of you to wield the power of fey charm and glamour. When you add spells to your repertoire, you can choose from the primal list as well as from enchantment and illusion spells that appear on the arcane spell list. As usual for when you add spells of a different tradition to your spell list, you're still a primal spellcaster, so all of your spells are primal spells."},
                    new TextBlock {Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your eidolon gains the Magical Understudy summoner feat, despite not meeting the prerequisite level, and it can choose fey gift cantrips in addition to primal cantrips. As usual for a feat you are granted by name, you can't retrain Magical Understudy into another feat."},
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
                Name = "Fey Mischief",
                Level = 7,
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your eidolon's fey magic becomes more powerful and mischievous. Your eidolon gains the Magical Adept feat, despite not meeting the prerequisite level, and can choose from fey gift spells in addition to primal spells."},
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
                Name = "Fey Chicanery",
                Level = 17,
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Ever full of tricks, your fey eidolon twists magical protections into your shared life force, granting it a contingency in its back pocket for desperate situations. During your daily preparations, your eidolon can cast a contingency spell. The 4th-level spell it chooses must come from the primal or fey gift list, and must either be common or be another spell you have access to."},
                },
                Effect = BooleanEffectBuilder.CreateAnd(Guid.Parse(""), and =>
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
                Id = Guid.Parse(""),
                PlaneId = Planes.Instances.FirstWorld.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 64
            };
        }
    }
}
