using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Archetypes
{
    public class ElementalMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Elemental Magic", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You’re a spellcaster that’s specialized in harnessing the four elements. Though you might feel a stronger kinship for one element over the others, you’re capable of shaping all of them. Due to your specialization in elemental magic, you have a smaller, more focused spell list than other spellcasters, though your magic is drawn from multiple traditions. If you choose this class archetype, you must select the Elementalist Dedication as your 2nd-level class feat." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Elementalist Adjustments" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Replace your spell list with the elemental spell list (page 203). Your actual magical tradition is unchanged, but you choose your spells from the elemental list instead." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "If you’re a sorcerer with the elemental bloodline, you can replace your initial bloodline spell with an initial elemental focus spell, and your advanced bloodline spell with an advanced elemental focus spell. The initial and advanced elemental focus spells you select must have the same trait as your elemental bloodline and come from the options starting on page 200." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Druid Elementalist Adjustment" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "If you’re a druid of the storm order, you can choose to replace your starting order spell, tempest surge, with updraft (page 201)." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Wizard Elementalist Adjustment" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "If you’re a wizard with an arcane school, instead of specializing in a school of magic, you specialize in one of the four elements: air, earth, fire, or water. Any benefits your arcane school would grant you that are associated with a selected spell school, you instead apply to your selected element. For example, if you select air as your element, you can prepare only spells that have the air trait in your extra arcane school slots, you can prepare an extra air cantrip, and you add an extra air spell from the elemental spell list to your spellbook. Additionally, in place of your arcane school spell, you learn the initial elemental focus spell of your selected element from the elemental focus spells starting on page 200. In all other ways, your arcane school functions as written in the Core Rulebook. If you later select the Advanced School Spell wizard feat, instead of gaining the listed school spell, you gain the advanced elemental focus spell of your selected element from the advanced elemental focus spells starting on page 200." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddPrerequisites(Guid.Parse(""), prerequisites => 
            {
                prerequisites.AddOr(Guid.Parse(""), or => 
                {
                    or.HaveSpecificMagicTradition(Guid.Parse(""), MagicTraditions.Instances.Arcane.ID);
                    or.HaveSpecificMagicTradition(Guid.Parse(""), MagicTraditions.Instances.Primal.ID);
                });
            });

            //TODO: Force 2nd level class feat to dedication feat.
            //TODO: Model the adjustments.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 206
            };
        }
    }
}
