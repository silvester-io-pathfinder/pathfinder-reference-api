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
    public class TriangleShot : Template
    {
        public static readonly Guid ID = Guid.Parse("eec82db1-a91e-48b5-a233-65570e5e24b1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Triangle Shot",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("04939ccb-5c4e-4379-9ec0-699fcd1cf490"), Type = TextBlockType.Text, Text = $"You string three arrows to your bow and fire them all at once. Make three ranged {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} against a single target with the required weapon, each using your current multiple attack penalty, and you take an additional –2 penalty. This counts as two attacks when calculating your multiple attack penalty, and you combine the attacks' damage for the purpose of resistances and weaknesses. Your {ToMarkdownLink<Models.Entities.Feat>("Stunning Fist", Feats.Instances.StunningFist.ID)} benefit applies to Triangle Shot, even though it isn't a {ToMarkdownLink<Models.Entities.Feat>("Flurry of Blows", Feats.Instances.FlurryOfBlows.ID)}. If all three {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} hit, the target takes 3d6 persistent bleed damage." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f5f0690b-57c8-4e6b-ab2e-8afb19881c99"), Feats.Instances.MonasticArcherStance.ID);
            builder.HaveSpecificFeat(Guid.Parse("06990d72-f1d6-4327-a461-9028afd53033"), Feats.Instances.StunningFist.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("bdcd0718-fd37-49c5-a330-45a581626537"), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse("bb1210fc-daf9-418f-835e-6c1bf820235d"), Traits.Instances.Flourish.ID);
            builder.Add(Guid.Parse("7a7c1b26-bf8f-4993-a9fa-e485cd229709"), Traits.Instances.Monk.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3d9762ac-d2af-4817-8a73-04b2e20a832a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
