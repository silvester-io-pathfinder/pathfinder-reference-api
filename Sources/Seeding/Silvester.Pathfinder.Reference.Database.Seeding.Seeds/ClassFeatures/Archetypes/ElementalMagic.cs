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
        public static readonly Guid ID = Guid.Parse("88be4fb9-a9d1-4869-9993-92e11ecff20a");

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
            yield return new TextBlock { Id = Guid.Parse("e347bae8-1d2f-4974-a881-1321ecb96cf6"), Type = TextBlockType.Text, Text = "you're a spellcaster that's specialized in harnessing the four elements. Though you might feel a stronger kinship for one element over the others, you're capable of shaping all of them. Due to your specialization in elemental magic, you have a smaller, more focused spell list than other spellcasters, though your magic is drawn from multiple traditions. If you choose this class archetype, you must select the Elementalist Dedication as your 2nd-level class feat." };
            yield return new TextBlock { Id = Guid.Parse("383b4ce6-916b-496d-9031-88fb5705b7c8"), Type = TextBlockType.Heading, Text = "Elementalist Adjustments" };
            yield return new TextBlock { Id = Guid.Parse("81169017-022a-4881-80eb-f35946b91a26"), Type = TextBlockType.Text, Text = "Replace your spell list with the elemental spell list (page 203). Your actual magical tradition is unchanged, but you choose your spells from the elemental list instead." };
            yield return new TextBlock { Id = Guid.Parse("3168f03c-05aa-4f64-ab38-28fb2d8e8ed2"), Type = TextBlockType.Text, Text = "If you're a sorcerer with the elemental bloodline, you can replace your initial bloodline spell with an initial elemental focus spell, and your advanced bloodline spell with an advanced elemental focus spell. The initial and advanced elemental focus spells you select must have the same trait as your elemental bloodline and come from the options starting on page 200." };
            yield return new TextBlock { Id = Guid.Parse("f5b55571-059e-4f95-933b-fdc38c4b1bd9"), Type = TextBlockType.Heading, Text = "Druid Elementalist Adjustment" };
            yield return new TextBlock { Id = Guid.Parse("bbe0f263-ee13-43dd-b964-5a2386ce9897"), Type = TextBlockType.Text, Text = "If you're a druid of the storm order, you can choose to replace your starting order spell, tempest surge, with updraft (page 201)." };
            yield return new TextBlock { Id = Guid.Parse("3c979864-369f-4cb1-b358-fcf4424dfe18"), Type = TextBlockType.Heading, Text = "Wizard Elementalist Adjustment" };
            yield return new TextBlock { Id = Guid.Parse("7c5417c3-0d7f-47bb-b1d3-a9c13e168f62"), Type = TextBlockType.Text, Text = "If you're a wizard with an arcane school, instead of specializing in a school of magic, you specialize in one of the four elements: air, earth, fire, or water. Any benefits your arcane school would grant you that are associated with a selected spell school, you instead apply to your selected element. For example, if you select air as your element, you can prepare only spells that have the air trait in your extra arcane school slots, you can prepare an extra air cantrip, and you add an extra air spell from the elemental spell list to your spellbook. Additionally, in place of your arcane school spell, you learn the initial elemental focus spell of your selected element from the elemental focus spells starting on page 200. In all other ways, your arcane school functions as written in the Core Rulebook. If you later select the Advanced School Spell wizard feat, instead of gaining the listed school spell, you gain the advanced elemental focus spell of your selected element from the advanced elemental focus spells starting on page 200." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddPrerequisites(Guid.Parse("df6953f6-8e38-42d3-96a3-669735de49ee"), prerequisites => 
            {
                prerequisites.AddOr(Guid.Parse("cc0179b6-f721-4e6c-b69a-7abf878d7b54"), or => 
                {
                    or.HaveSpecificMagicTradition(Guid.Parse("4e133cc1-8c83-4db0-a683-e39c512600f1"), MagicTraditions.Instances.Arcane.ID);
                    or.HaveSpecificMagicTradition(Guid.Parse("31c13b96-3d32-4b95-a1ab-27c776d6ecdf"), MagicTraditions.Instances.Primal.ID);
                });
            });

            //TODO: Force 2nd level class feat to dedication feat.
            //TODO: Model the adjustments.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("293ed0d3-9207-4314-a430-ffcb0963f2d6"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 206
            };
        }
    }
}
