using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Extensions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Archetypes
{
    public class RunelordSpecialization : Template
    {
        public static readonly Guid ID = Guid.Parse("6d36667a-6e02-4e4b-980f-ae2a7461c98b");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Runelord Specialization", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("db6f3ff3-9a8c-4a6b-8fbc-dc22e711ef29"), Type = TextBlockType.Text, Text = "You draw untold power from runes, sometimes called sin magic. You associate with one of the seven vices, also known as the seven rewards of rule: envy (abjuration), gluttony (necromancy), greed (transmutation), lust (enchantment), pride (illusion), sloth (conjuration), and wrath (evocation). Studying these techniques often tempts you with the associated sin. While leaning into it could corrupt you, it might make you more powerful. If you choose this class archetype, you must select Runelord Dedication as your 2nd-level class feat." };
            yield return new TextBlock { Id = Guid.Parse("5e457e34-2534-4d2c-aa17-591b8b456723"), Type = TextBlockType.Heading, Text = "Runelord Adjustments" };
            yield return new TextBlock { Id = Guid.Parse("6c2e2daf-7517-443e-b9eb-b74b5e6876bc"), Type = TextBlockType.Text, Text = "In addition to the normal school spell for your chosen school of magic, you learn the initial rune spell associated with your school, with its school adjusted to your chosen school of magic if it wasn't from that school already. The rune spells can be found on pages 238-239. Your pool of Focus Points increases to 2 Focus Points. At 8th level, you also learn the advanced rune spell associated with your school, also adjusting its school to match your chosen school of magic if it wasn't already, and your pool of Focus Points increases to 3 Focus Points." };
            yield return new TextBlock { Id = Guid.Parse("922d65ab-6ad9-4b5d-a989-91cbb75de43c"), Type = TextBlockType.Text, Text = "You can Refocus by indulging in your school's sin in lieu of studying your spellbook. As you become more powerful, your indulgence grows. At 12th level, if you indulge in your sin to Refocus, if you have spent at least 2 Focus Points since the last time you Refocused, you recover 2 Focus Points when you Refocus instead of 1. At 18th level, if you indulge in your sin to Refocus, if you have spent at least 3 Focus Points since the last time you Refocused, you recover 3 Focus Points when you Refocus instead of 1." };
            yield return new TextBlock { Id = Guid.Parse("873c4a79-a7fb-4be6-adf5-a60ad56d6925"), Type = TextBlockType.Text, Text = "You are trained in martial polearms. At 11th level, if you gain weapon expertise, you become an expert in martial polearms." };
            yield return new TextBlock { Id = Guid.Parse("80b74329-377f-43fc-8fbe-8742979a7cf7"), Type = TextBlockType.Text, Text = "Finally, you lose the ability to prepare or cast any spell from your school's prohibited schools (pages 238-239). You remove all spells of those schools from your spell list, meaning you can't even activate scrolls or wands of such spells." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddPrerequisites(Guid.Parse("2411dddf-a0be-4c26-9f82-9aa75540e2e6"), prerequisites => 
            {
                prerequisites.HaveSpecificClass(Guid.Parse("3b92a3a8-7cf0-4d16-97da-5dcc6a87ac52"), Classes.Instances.Wizard.ID);
                prerequisites.HaveAnyMagicSchool(Guid.Parse("bdf89638-57c7-4cd7-ae70-e5c0c964cb2d"));
                prerequisites.HaveSpecificMagicSchool(Guid.Parse("e2398620-1304-4a6d-b9cf-66afd5f6124c"), MagicSchools.Instances.Divination.ID, isNegated: true);
            });

            builder.GainFocusPoolPoint(Guid.Parse("06e7fb65-6888-4487-a932-360739e3d314"));
            builder
                .GainFocusPoolPoint(Guid.Parse("cb32d13a-0b1a-4219-b431-11eecaa0ca86"))
                .AddPrerequisites(Guid.Parse("0d095758-8a26-45bb-8512-ac3f8882aaa2"), prerequisites => 
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse("0c1ae16e-1619-4c8b-b630-a37ff5174fab"), Comparator.GreaterThanOrEqualTo, requiredLevel: 8);
                });

            builder.GainSpecificWeaponGroupProficiency(Guid.Parse("3d6e4f1d-3c2e-4a11-9d0a-1dc253074284"), Proficiencies.Instances.Expert.ID, WeaponGroups.Instances.Polearm.ID, WeaponCategories.Instances.Martial.ID);
            builder
                .GainSpecificWeaponGroupProficiency(Guid.Parse("32e7e91a-ed0e-4538-a562-3e1aca598217"), Proficiencies.Instances.Master.ID, WeaponGroups.Instances.Polearm.ID, WeaponCategories.Instances.Martial.ID)
                .AddPrerequisites(Guid.Parse("99e118ab-689f-4ec2-a7d1-25c1dbc9e0f5"), prerequisites => 
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse("01fd49b4-e18f-4af5-8fce-cc99fc63d4b2"), Comparator.GreaterThanOrEqualTo, requiredLevel: 11);
                });

            builder.AddOr(Guid.Parse("94472811-6f98-4a46-8df2-9f3f1d424030"), or => 
            {
                or.AddRuneMagicOption(Guid.Parse("992711a2-06da-4bca-a887-cf2ac8283022"), RuneMagics.Instances.Envy.ID, MagicSchools.Instances.Abjuration.ID);
                or.AddRuneMagicOption(Guid.Parse("cd899683-3dab-4065-9ac5-d0ac84ec5f67"), RuneMagics.Instances.Sloth.ID, MagicSchools.Instances.Conjuration.ID);
                or.AddRuneMagicOption(Guid.Parse("aa254cb9-4d04-4b75-af23-5078cb0d13ab"), RuneMagics.Instances.Lust.ID, MagicSchools.Instances.Enchantment.ID);
                or.AddRuneMagicOption(Guid.Parse("e83d7f6c-24bc-4224-966e-8ec66de39bee"), RuneMagics.Instances.Wrath.ID, MagicSchools.Instances.Evocation.ID);
                or.AddRuneMagicOption(Guid.Parse("22b7e6d1-d6e8-4ea8-95ff-2dc68290afd3"), RuneMagics.Instances.Pride.ID, MagicSchools.Instances.Illusion.ID);
                or.AddRuneMagicOption(Guid.Parse("41095b84-ef3f-403c-9bde-1c1ff4e7c0aa"), RuneMagics.Instances.Gluttony.ID, MagicSchools.Instances.Necromancy.ID);
                or.AddRuneMagicOption(Guid.Parse("c060a5ca-fdca-4967-ac18-b0f71106ca02"), RuneMagics.Instances.Greed.ID, MagicSchools.Instances.Transmutation.ID);
            });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6805e9f8-b5b9-42ca-befa-6daa455913f9"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 240
            };
        }
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static void AddRuneMagicOption(this BooleanEffectBuilder builder, Guid id, Guid runeMagicId, Guid requiredMagicSchoolId)
        {
            builder
                .GainSpecificRuneMagic(id, runeMagicId)
                .AddPrerequisites(id.Increment(1), prerequisites =>
                {
                    prerequisites.HaveSpecificMagicSchool(id.Increment(2), requiredMagicSchoolId);
                });
        }
    }
}
