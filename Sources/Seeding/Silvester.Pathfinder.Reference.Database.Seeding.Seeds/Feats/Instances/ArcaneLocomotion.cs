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
    public class ArcaneLocomotion : Template
    {
        public static readonly Guid ID = Guid.Parse("1e398963-ae54-4340-ac9a-011e06c004af");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Arcane Locomotion",
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
            yield return new TextBlock { Id = Guid.Parse("303af694-d315-49bd-a59b-83cfc633dcef"), Type = TextBlockType.Text, Text = $"You've modified your body to allow you to augment your movement. You gain either a climb Speed of 20 feet or a swim Speed of 20 feet, your choice." };
            yield return new TextBlock { Id = Guid.Parse("78be7fe7-df7c-4ee5-8657-ed6ccf2a2233"), Type = TextBlockType.Text, Text = $"----" };
            yield return new TextBlock { Id = Guid.Parse("5b9cc408-8895-4858-9e60-788724d5ad4f"), Type = TextBlockType.Text, Text = $"~ Enhancement: Your body allows for even further forms of movement. You can either select the option from this feat you haven't chosen yet (climb Speed or swim Speed), or you can increase your land Speed by 5 feet and increase the Speed you chose from this feat increase to be equal to your adjusted land Speed." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2cfb61b8-297b-4885-a82b-147f8c1d29e9"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
