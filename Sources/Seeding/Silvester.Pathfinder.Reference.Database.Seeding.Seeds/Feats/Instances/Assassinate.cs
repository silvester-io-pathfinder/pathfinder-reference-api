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
    public class Assassinate : Template
    {
        public static readonly Guid ID = Guid.Parse("75b8c2b9-b521-47f7-8ef2-f4856b1e8e42");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Assassinate",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8b933bb4-ad2d-4941-8b0a-8f1fd95a2651"), Type = TextBlockType.Text, Text = $"You strike with one swift movement, trying to instantly slay your mark. Make a {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against your mark. If you hit, your mark takes 6d6 extra precision damage with a basic Fortitude save against your class DC or spell DC, whichever is higher." };
            yield return new TextBlock { Id = Guid.Parse("6e802353-5f0d-482e-bdb5-d697cd75e929"), Type = TextBlockType.Text, Text = $"If the mark critically fails, they die. This is an {ToMarkdownLink<Models.Entities.Trait>("incapacitation", Traits.Instances.Incapacitation.ID)} effect. The creature then becomes temporarily immune to your Assassinate for 1 day." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("66d43d69-4b1e-4ce7-9638-5022bc562f76"), Feats.Instances.AssassinDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b917cbc9-429b-4f8f-989c-3cdb8ff607d3"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
