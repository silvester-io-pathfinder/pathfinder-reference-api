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
    public class FlyingBlade : Template
    {
        public static readonly Guid ID = Guid.Parse("5eba47ac-74e6-4dbd-a4ea-ed098325c10c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Flying Blade",
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
            yield return new TextBlock { Id = Guid.Parse("c94f27ca-6d01-4861-98a7-49fb1aae59c0"), Type = TextBlockType.Text, Text = $"You've learned to apply your flashy techniques to thrown weapons as easily as melee attacks. When you have panache, you apply your precise strike damage on ranged {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} you make with a thrown weapon within that weapon's first range increment. The {ToMarkdownLink<Models.Entities.Trait>("thrown", Traits.Instances.Thrown.ID)} weapon must be an {ToMarkdownLink<Models.Entities.Trait>("agile", Traits.Instances.Agile.ID)} or {ToMarkdownLink<Models.Entities.Trait>("finesse", Traits.Instances.Finesse.ID)} weapon. This also allows you to make a thrown weapon ranged {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} for {ToMarkdownLink<Models.Entities.Feat>("Confident Finisher", Feats.Instances.ConfidentFinisher.ID)} and any other {ToMarkdownLink<Models.Entities.Trait>("finisher", Traits.Instances.Finisher.ID)} that includes a {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} that can benefit from your precise strike." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClassFeature(Guid.Parse("d239be14-102c-41e1-b8e4-3f47847bbb4c"), ClassFeatures.Swashbucklers.PreciseStrike.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("2e5b97e1-d85c-4ed1-86da-f8ed94730987"), Traits.Instances.Swashbuckler.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b4ed6cb9-30b0-4fcb-8d3c-e9477e275595"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
