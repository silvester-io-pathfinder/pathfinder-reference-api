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
    public class ChosenOfLamashtu : Template
    {
        public static readonly Guid ID = Guid.Parse("0f8fddec-a39c-40dc-9a2c-3a5b26321225");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Chosen of Lamashtu",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e0b98aef-e50f-496a-905f-7ff38e191ad0"), Type = TextBlockType.Text, Text = $"You bear the favor and blessings of Lamashtu, the Mother of Monsters. She has bestowed a mutation upon you, granting you the benefits of another heritage. Choose one goblin heritage that you do not already have; you gain that heritage and its benefits." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.WorshipSpecificDeity(Guid.Parse("ab0e72d4-89a6-4c98-9c8f-b7bb52908cae"), Deities.Instances.Lamashtu.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("b6487020-7770-44f2-bd8f-dd3b81866726"), Traits.Instances.Goblin.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3356bbc6-a6b3-4607-a9c5-0fd88d5569ea"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
