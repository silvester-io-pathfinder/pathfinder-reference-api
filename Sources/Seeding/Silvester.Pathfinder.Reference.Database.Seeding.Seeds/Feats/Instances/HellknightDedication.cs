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
    public class HellknightDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("75ac94f3-3d01-4b09-b0d6-f7419bf6717f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hellknight Dedication",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have gained two other feats from the Hellknight or Hellknight armiger archetypes.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("03980dd2-8267-4faf-b851-8aa86af1bfbc"), Type = TextBlockType.Text, Text = $"You have forged your body to comply with the commands of your mind – orders steeped in the Measure and the Chain. You gain expert proficiency in Intimidation (or in another skill in which you're trained of your choice, if you were already an expert in Intimidation). You gain the armor specialization effects of Hellknight plate, and your resistance from that armor specialization is 1 higher than normal. In addition, you gain a +1 circumstance bonus to Intimidation checks while wearing your Hellknight plate." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1cbedc86-f477-4a40-b85a-25622662f021"), Feats.Instances.HellknightArmigerDedication.ID);
            builder.AddOr(Guid.Parse("09eb5c19-1eda-4c42-b806-ec0b1f5ed070"), or => 
            {
                or.HaveSpecificAlignment(Guid.Parse("f24505b8-456e-4fad-9963-67581b7dde43"), Alignments.Instances.LawfulGood.ID);
                or.HaveSpecificAlignment(Guid.Parse("2011cd11-8b2b-41cf-9b78-7b60f5127719"), Alignments.Instances.LawfulEvil.ID);
            });
            builder.Manual(Guid.Parse("808f3581-419e-46db-9742-1cd556d9d03e"), "Member of a Hellknight order.");
            builder.Manual(Guid.Parse("afdc3895-ca62-41c8-a89c-7bdebd9de397"), "Passed the Hellknight Test.");
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Dedication.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ce7ebad0-dc61-4916-8d6b-e8825c7d82b0"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
