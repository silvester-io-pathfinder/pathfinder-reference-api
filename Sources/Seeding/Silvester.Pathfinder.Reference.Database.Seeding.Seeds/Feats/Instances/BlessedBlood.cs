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
    public class BlessedBlood : Template
    {
        public static readonly Guid ID = Guid.Parse("7be6fe20-cb9c-4c09-83b9-2d2cfb67cd78");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Blessed Blood",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b8bb808c-26ce-4b55-a3a1-1f1a97741a22"), Type = TextBlockType.Text, Text = $"Your deity's blessings manifest in your blood-borne power. Add up to three of your deity's spells (spells your deity grants to clerics) to your spell list. They are not automatically added to your repertoire, but you can select them just as you would spells normally on the divine spell list." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveAnyBloodlineSpecificMagicTradition(Guid.Parse("2dca2590-48ec-4908-855e-761a13a6dc89"), MagicTraditions.Instances.Divine.ID);
            builder.FollowAnyReligion(Guid.Parse("c2344fdc-5a24-42cc-8ba2-cfbef4ecc2ab"));
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("4fc217bf-9069-463e-9fb2-969cd67951d3"), Traits.Instances.Sorcerer.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("06fed3e7-00bc-490a-834a-4d28f7fe7ea8"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = -1
            };
        }
    }
}
