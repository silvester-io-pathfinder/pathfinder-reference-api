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
    public class HatchlingFlight : Template
    {
        public static readonly Guid ID = Guid.Parse("bb8a218b-8c67-4dc6-9738-1a9b3ea54ae7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hatchling Flight",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per round"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0857c8fd-b644-4946-b9bd-a00d22b7a628"), Type = TextBlockType.Text, Text = $"You can fly a little! You {ToMarkdownLink<Models.Entities.Action>("Fly", Actions.Instances.Fly.ID)} up to half your Speed. If you don't end your movement on solid ground, you fall at the end of your turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("400df2e3-5e26-466e-a5dd-b1eeb451afb1"), Feats.Instances.Winglets.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Kobold.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e061dbab-ff3d-47e1-856f-205d987ca41b"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
