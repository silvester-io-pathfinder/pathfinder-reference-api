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
    public class PoisonCoat : Template
    {
        public static readonly Guid ID = Guid.Parse("14c85acf-1ce5-41b2-8c50-4c12389d9e1b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Poison Coat",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A creature adjacent to you hits you with a melee unarmed Strike.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ec8e0f42-04b4-4320-a899-d42f4737de42"), Type = TextBlockType.Text, Text = $"In nature, certain animals are covered in venomous spines, such that even touching them is deadly. To use this reaction, you must have brushed poison onto your clothing or woven sharp poisoned needles into the garment's fabric. This takes 10 minutes and uses one dose of {ToMarkdownLink<Models.Entities.Trait>("contact", Traits.Instances.Contact.ID)} or {ToMarkdownLink<Models.Entities.Trait>("injury", Traits.Instances.Injury.ID)} poison. You can have only one such poison suffused into your clothing at a time." };
            yield return new TextBlock { Id = Guid.Parse("b15db5b2-8218-41b1-966d-831209508cdb"), Type = TextBlockType.Text, Text = $"When you use this reaction, the triggering creature is exposed to the suffused poison." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("8eaac9cc-4be6-4d46-b9cb-9f45dad36201"), Feats.Instances.PoisonerDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ab6063da-3363-4790-85ee-510cfd5c1815"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
