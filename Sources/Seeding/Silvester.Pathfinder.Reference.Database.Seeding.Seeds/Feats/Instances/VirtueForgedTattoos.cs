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
    public class VirtueForgedTattoos : Template
    {
        public static readonly Guid ID = Guid.Parse("bf9dd292-6919-4484-8699-fa7ac2c5254f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Virtue-Forged Tattoos",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("78d53e91-eded-4213-bfaf-12ac549fdd36"), Type = TextBlockType.Text, Text = $"Your tattoos are a work of eldritch genius, a masterpiece of art, magic, and skin. Choose a 3rd-level arcane spell from the same school as your {ToMarkdownLink<Models.Entities.Feat>("Arcane Tattoos", Feats.Instances.ArcaneTattoos.ID)}, either a common spell or another to which you have access, including a lower-level spell heightened to 3rd level if you wish. You can cast that spell once per day as an innate arcane spell." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("13464889-5440-4467-b73b-db2a8603c8ec"), Feats.Instances.OrnateTattoo.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Human.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c00a2492-7ee2-4f34-869e-5a2efad00129"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
