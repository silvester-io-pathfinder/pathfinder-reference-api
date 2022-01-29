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
    public class IrriseniIceWitch : Template
    {
        public static readonly Guid ID = Guid.Parse("e402afb6-8c69-4e07-8232-d83a6379d6e4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Irriseni Ice-Witch",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5cb324aa-9d92-40e0-a658-4a0c37e64751"), Type = TextBlockType.Text, Text = $"~ Access: Jadwiga ethnicity" };
            yield return new TextBlock { Id = Guid.Parse("418c7126-11c1-4701-ae6e-0580ad2a040c"), Type = TextBlockType.Text, Text = $"You can trace your direct descent from one of the Queens of Irrisen and thus from Baba Yaga herself. Your resistance to cold increases to 5 + half your level, and you can cast 5th-level {ToMarkdownLink<Models.Entities.Spell>("wall of ice", Spells.Instances.WallOfIce.ID)} as an innate arcane spell once per day." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("0b904089-ed7b-485b-9f04-f1a6b84d7245"), Heritages.Instances.WintertouchedHuman.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b2a80ff0-89a9-471f-b404-12ed909d1e83"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
