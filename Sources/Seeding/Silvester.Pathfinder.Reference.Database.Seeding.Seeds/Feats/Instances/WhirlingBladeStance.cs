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
    public class WhirlingBladeStance : Template
    {
        public static readonly Guid ID = Guid.Parse("2fed227d-77eb-4ee5-baea-d0948cb92098");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Whirling Blade Stance",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c9ff77fd-1142-493a-a557-0aae7f0f3777"), Type = TextBlockType.Text, Text = $"You enter a mindful stance that creates a deep connection between you and your monk weapons, allowing you to manipulate them with your ki even at a distance. All melee monk weapons you wield with the {ToMarkdownLink<Models.Entities.Trait>("finesse", Traits.Instances.Finesse.ID)} trait gain the {ToMarkdownLink<Models.Entities.Trait>("thrown 10 feet", Traits.Instances.Thrown.ID)} trait (unless they already have the {ToMarkdownLink<Models.Entities.Trait>("thrown", Traits.Instances.Thrown.ID)} trait with a greater range)." };
            yield return new TextBlock { Id = Guid.Parse("4de2a6d9-394b-4586-8d6c-681a55471004"), Type = TextBlockType.Text, Text = $"Once you've made a thrown {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} with such a weapon, you can use the precision of your throw to make additional strikes with it, even from a distance. Start from the space of the previous {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}'s target to determine the range increment and whether the new target has cover. At the end of your turn, the thrown weapon flies directly back to you in a straight line. If a solid barrier blocks its path, it falls to the ground after hitting the barrier." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e51c28b3-b6d0-4aa5-bc24-38f52d4cf52b"), Feats.Instances.MonasticWeaponry.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e7ed83c1-98b9-4ccd-a19c-ade970264426"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
