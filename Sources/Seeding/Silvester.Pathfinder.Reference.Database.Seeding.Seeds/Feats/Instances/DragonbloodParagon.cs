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
    public class DragonbloodParagon : Template
    {
        public static readonly Guid ID = Guid.Parse("26fc4ea8-36cb-48c5-995f-7bab6c739d9c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dragonblood Paragon",
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
            yield return new TextBlock { Id = Guid.Parse("872b1d6e-d432-47c1-9615-d89d6e9633a6"), Type = TextBlockType.Text, Text = $"Your draconic anatomy becomes especially pronounced. You increase the power of one of the following kobold heritages or feats you have." };
            yield return new TextBlock { Id = Guid.Parse("0b32ed40-f361-4068-9c83-08444337dde9"), Type = TextBlockType.Text, Text = $"~ Dracomancer: Increase the number of times you can cast each of the granted 1st- and 2nd-level innate spells by 1. " };
            yield return new TextBlock { Id = Guid.Parse("1e68af78-742f-4d78-982f-c3c84eb97b5d"), Type = TextBlockType.Text, Text = $"~ Kobold Breath: Creatures that critically fail their save against your {ToMarkdownLink<Models.Entities.Feat>("Kobold Breath", Feats.Instances.KoboldBreath.ID)} take 3d4 persistent damage of the type dealt by your draconic patron." };
            yield return new TextBlock { Id = Guid.Parse("f32c0564-e1fd-4494-98f6-7a9d2748cd41"), Type = TextBlockType.Text, Text = $"~ Strongjaw Kobold: Your jaws unarmed attack gains the {ToMarkdownLink<Models.Entities.Trait>("deadly", Traits.Instances.Deadly.ID)} d6 trait." };
            yield return new TextBlock { Id = Guid.Parse("de162c32-36b8-447d-b88b-7bd7b11ad40f"), Type = TextBlockType.Text, Text = $"~ Venomtail Kobold: You produce enough venom to use the {ToMarkdownLink<Models.Entities.Feat>("Tail Toxin", Feats.Instances.TailToxin.ID)} action twice per day." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("d295587c-8f9d-48a5-912e-e2094f364acf"), or => 
            {
                or.HaveSpecificHeritage(Guid.Parse("0c082f9e-edf6-4d59-819e-29849ca334af"), Heritages.Instances.StrongjawKobold.ID);
                or.HaveSpecificHeritage(Guid.Parse("97bd2d23-3ac8-4322-9c8e-c5e3623eef87"), Heritages.Instances.VenomtailKobold.ID);
                or.HaveSpecificFeat(Guid.Parse("d7180f76-851f-4703-82bb-c03cc60c3d91"), Feats.Instances.Dracomancer.ID);
                or.HaveSpecificFeat(Guid.Parse("de803a6b-b79c-43c5-8e35-a5a52c7fa138"), Feats.Instances.KoboldBreath.ID);
            });
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("d88942a5-1ad1-4135-be78-ad41a5edb68f"), Traits.Instances.Kobold.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("50d3aae4-8195-48a7-8fb7-be8b93436105"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
