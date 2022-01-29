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
    public class CleverCounterspell : Template
    {
        public static readonly Guid ID = Guid.Parse("3979d0fe-5e47-420c-9e89-45f6534dbc11");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Clever Counterspell",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e9706b98-3e22-4213-b006-17785d3c06db"), Type = TextBlockType.Text, Text = $"You creatively apply your prepared spells to {ToMarkdownLink<Models.Entities.Feat>("Counterspell", Feats.Instances.Counterspell.ID)} a much wider variety of your opponents' magic. Instead of being able to counter a foe's spell with {ToMarkdownLink<Models.Entities.Feat>("Counterspell", Feats.Instances.Counterspell.ID)} only if you have that same spell prepared, you can use {ToMarkdownLink<Models.Entities.Feat>("Counterspell", Feats.Instances.Counterspell.ID)} as long as you have the spell the foe is casting in your spellbook. When you use {ToMarkdownLink<Models.Entities.Feat>("Counterspell", Feats.Instances.Counterspell.ID)} in this way, the prepared spell you expend must share a trait other than its tradition with the triggering spell. At the GM's discretion, you can instead use a spell that has an opposing trait or that otherwise logically would counter the triggering spell (such as using a cold or water spell to counter {ToMarkdownLink<Models.Entities.Spell>("fireball", Spells.Instances.Fireball.ID)} or using {ToMarkdownLink<Models.Entities.Spell>("remove fear", Spells.Instances.RemoveFear.ID)} to counter a fear spell). Regardless of what spell you expend, you take a -2 penalty to your counteract check, though the GM can waive this penalty if the expended spell is especially appropriate." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("dddc431e-3485-4608-9fba-c1c55d78e5c8"), Feats.Instances.Counterspell.ID);
            builder.HaveSpecificFeat(Guid.Parse("9fb69c5a-2f06-429a-aa29-ec39fe3802b2"), Feats.Instances.QuickRecognition.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("934ab3f0-794f-46df-b19f-28265cba73fe"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
