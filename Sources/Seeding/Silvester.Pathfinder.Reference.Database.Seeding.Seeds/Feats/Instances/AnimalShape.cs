using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AnimalShape : Template
    {
        public static readonly Guid ID = Guid.Parse("7bdddd0d-feb6-4868-b2c7-4235062089d2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Animal Shape",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("20095a37-e286-47b3-b694-9813f16d3c18"), Type = TextBlockType.Text, Text = $"You have full control over your shape and can transform into your inherent animal. You can use {ToMarkdownLink<Models.Entities.Feat>("Change Shape", Feats.Instances.ChangeShapeBeastkin.ID)} to enter an animal shape. When you gain this feat, choose either {ToMarkdownLink<Models.Entities.Spell>("aerial form", Spells.Instances.AerialForm.ID)}, {ToMarkdownLink<Models.Entities.Spell>("animal form", Spells.Instances.AnimalForm.ID)}, or {ToMarkdownLink<Models.Entities.Spell>("dinosaur form", Spells.Instances.DinosaurForm.ID)}; after you choose a form, you can't change the form. While in animal shape, you gain the effects of a 5th-level casting of your chosen form spell, except you always transform into an animal matching your inherent animal and can use your humanoid form's AC if it's higher than what the animal form grants. If your inherent animal isn't among the animals listed in the form, you default to the statistics and abilities of the bird battle form, cat battle form, or deinonychus battle form for {ToMarkdownLink<Models.Entities.Spell>("aerial form", Spells.Instances.AerialForm.ID)}, {ToMarkdownLink<Models.Entities.Spell>("animal form", Spells.Instances.AnimalForm.ID)}, and {ToMarkdownLink<Models.Entities.Spell>("dinosaur form", Spells.Instances.DinosaurForm.ID)}, respectively (at the GM's discretion, you instead default to a different form that is closest to your inherent animal). You can remain in animal shape indefinitely and can use {ToMarkdownLink<Models.Entities.Feat>("Change Shape", Feats.Instances.ChangeShapeBeastkin.ID)} to return to your humanoid or hybrid shape at any time." };
            yield return new TextBlock { Id = Guid.Parse("c7762855-f65b-4d8c-a46b-5a66e1e665c6"), Type = TextBlockType.Text, Text = $"If you have the {ToMarkdownLink<Models.Entities.Feat>("Critter Shape", Feats.Instances.CritterShape.ID)} feat, you can choose to gain the effects of a 4th-level {ToMarkdownLink<Models.Entities.Spell>("pest form", Spells.Instances.PestForm.ID)}, can remain in critter shape indefinitely, and can return to your critter shape at any time after leaving the shape, just as you can with Animal Shape." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Beastkin.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7ef31ed0-5b11-427d-b72f-ce5b77414032"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
