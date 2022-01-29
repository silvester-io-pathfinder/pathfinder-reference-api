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
    public class CleverShadow : Template
    {
        public static readonly Guid ID = Guid.Parse("d6bdd893-a4f5-4161-bdcb-da40847a3842");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Clever Shadow",
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
            yield return new TextBlock { Id = Guid.Parse("d01ee4b6-2773-4380-91c0-6ed658bf57b7"), Type = TextBlockType.Text, Text = $"You can perform simple {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)} actions with your shadow, such as opening an unlocked door. Anything your shadow {ToMarkdownLink<Models.Entities.Action>("Interacts", Actions.Instances.Interact.ID)} with must be within your reach. Your shadow can't perform actions that require significant manual dexterity, including any action that would require a check to accomplish, and you can't use it to hold items." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("ffda1cc2-b8dc-44ce-a6de-2b4862df35e5"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("34d3a99b-48bf-4c55-b86b-74d3462dc227"), Traits.Instances.Fetchling.ID);
            builder.Add(Guid.Parse("40c06ea3-0d4b-44b3-90f7-cd5a479b8d43"), Traits.Instances.Occult.ID);
            builder.Add(Guid.Parse("e47ce730-87f0-4195-a76a-d34ea50b8401"), Traits.Instances.Shadow.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f1d3a63d-4436-4fb6-821f-cbe57a18ba3e"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
