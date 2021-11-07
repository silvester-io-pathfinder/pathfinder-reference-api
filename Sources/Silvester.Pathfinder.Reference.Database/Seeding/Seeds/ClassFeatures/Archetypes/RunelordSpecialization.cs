using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Archetypes
{
    public class RunelordSpecialization : Template
    {
        public static readonly Guid ID = Guid.Parse("");

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
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You draw untold power from runes, sometimes called sin magic. You associate with one of the seven vices, also known as the seven rewards of rule: envy (abjuration), gluttony (necromancy), greed (transmutation), lust (enchantment), pride (illusion), sloth (conjuration), and wrath (evocation). Studying these techniques often tempts you with the associated sin. While leaning into it could corrupt you, it might make you more powerful. If you choose this class archetype, you must select Runelord Dedication as your 2nd-level class feat." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Runelord Adjustments" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "In addition to the normal school spell for your chosen school of magic, you learn the initial rune spell associated with your school, with its school adjusted to your chosen school of magic if it wasn’t from that school already. The rune spells can be found on pages 238–239. Your pool of Focus Points increases to 2 Focus Points. At 8th level, you also learn the advanced rune spell associated with your school, also adjusting its school to match your chosen school of magic if it wasn’t already, and your pool of Focus Points increases to 3 Focus Points." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You can Refocus by indulging in your school’s sin in lieu of studying your spellbook. As you become more powerful, your indulgence grows. At 12th level, if you indulge in your sin to Refocus, if you have spent at least 2 Focus Points since the last time you Refocused, you recover 2 Focus Points when you Refocus instead of 1. At 18th level, if you indulge in your sin to Refocus, if you have spent at least 3 Focus Points since the last time you Refocused, you recover 3 Focus Points when you Refocus instead of 1." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You are trained in martial polearms. At 11th level, if you gain weapon expertise, you become an expert in martial polearms." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Finally, you lose the ability to prepare or cast any spell from your school’s prohibited schools (pages 238–239). You remove all spells of those schools from your spell list, meaning you can’t even activate scrolls or wands of such spells." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddPrerequisites(Guid.Parse(""), prerequisites => 
            {
                prerequisites.HaveSpecificClass(Guid.Parse(""), Classes.Instances.Wizard.ID);
                prerequisites.HaveAnyMagicSchool(Guid.Parse(""));
                prerequisites.HaveSpecificMagicSchool(Guid.Parse(""), MagicSchools.Instances.Divination.ID, isNegated: true);
            });

            builder.GainFocusPoolPoint(Guid.Parse(""));
            builder
                .GainFocusPoolPoint(Guid.Parse(""))
                .AddPrerequisites(Guid.Parse(""), prerequisites => 
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse(""), Comparator.GreaterThanOrEqualTo, requiredLevel: 8);
                });

            builder.GainSpecificWeaponGroupProficiency(Guid.Parse(""), Proficiencies.Instances.Expert.ID, WeaponGroups.Instances.Polearm.ID, WeaponCategories.Instances.Martial.ID);
            builder
                .GainSpecificWeaponGroupProficiency(Guid.Parse(""), Proficiencies.Instances.Master.ID, WeaponGroups.Instances.Polearm.ID, WeaponCategories.Instances.Martial.ID)
                .AddPrerequisites(Guid.Parse(""), prerequisites => 
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse(""), Comparator.GreaterThanOrEqualTo, requiredLevel: 11);
                });

            builder.AddOr(Guid.Parse(""), or => 
            {
                or.AddRuneMagicOption(RuneMagics.Instances.Envy.ID, MagicSchools.Instances.Abjuration.ID);
                or.AddRuneMagicOption(RuneMagics.Instances.Sloth.ID, MagicSchools.Instances.Conjuration.ID);
                or.AddRuneMagicOption(RuneMagics.Instances.Lust.ID, MagicSchools.Instances.Enchantment.ID);
                or.AddRuneMagicOption(RuneMagics.Instances.Wrath.ID, MagicSchools.Instances.Evocation.ID);
                or.AddRuneMagicOption(RuneMagics.Instances.Pride.ID, MagicSchools.Instances.Illusion.ID);
                or.AddRuneMagicOption(RuneMagics.Instances.Gluttony.ID, MagicSchools.Instances.Necromancy.ID);
                or.AddRuneMagicOption(RuneMagics.Instances.Greed.ID, MagicSchools.Instances.Transmutation.ID);
            });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 240
            };
        }
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static void AddRuneMagicOption(this BooleanEffectBuilder builder, Guid runeMagicId, Guid requirdMagicSchoolId)
        {
            builder
                .GainSpecificRuneMagic(Guid.Parse(""), runeMagicId)
                .AddPrerequisites(Guid.Parse(""), prerequisites =>
                {
                    prerequisites.HaveSpecificMagicSchool(Guid.Parse(""), requirdMagicSchoolId);
                });
        }
    }
}
