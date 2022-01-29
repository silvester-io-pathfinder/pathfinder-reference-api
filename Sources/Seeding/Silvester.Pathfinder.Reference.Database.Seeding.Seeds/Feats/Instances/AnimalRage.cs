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
    public class AnimalRage : Template
    {
        public static readonly Guid ID = Guid.Parse("36841f84-9d19-4ac6-96a2-83a17d173c36");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Animal Rage",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a334d445-f064-4012-81da-fb4634d2752e"), Type = TextBlockType.Text, Text = $"You transform into your animal. You gain the effects of the 3rd-level {ToMarkdownLink<Models.Entities.Spell>("animal form", Spells.Instances.AnimalForm.ID)} spell except you use your own statistics, temporary Hit Points, and unarmed attacks instead of those granted by animal form. You also retain the constant abilities of your gear. If your animal is a frog, your tongue's reach increases to 15 feet. {ToMarkdownLink<Models.Entities.Action>("Dismissing", Actions.Instances.Dismiss.ID)} the transformation gains the {ToMarkdownLink<Models.Entities.Trait>("rage", Traits.Instances.Rage.ID)} trait." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInstinct(Guid.Parse("9ec8f3ae-bda1-4181-a648-2587647ca82b"), Instincts.Instances.AnimalInstinct.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Barbarian.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Instinct.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Polymorph.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Primal.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Rage.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Transmutation.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f7867635-6815-42ea-8037-b7139a2d6fcb"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
