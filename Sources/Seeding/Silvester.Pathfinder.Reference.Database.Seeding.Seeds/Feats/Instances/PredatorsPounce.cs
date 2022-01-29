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
    public class PredatorsPounce : Template
    {
        public static readonly Guid ID = Guid.Parse("d81208e9-3eaa-49da-834b-26be7258249e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Predator's Pounce",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a1fb8851-72f4-450e-b044-d67e789a9cc5"), Type = TextBlockType.Text, Text = $"You close the distance to your prey in a blur, pouncing on the creature before it can react. You {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)} up to your Speed and make a {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} at the end of your movement." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInstinct(Guid.Parse("e149d334-47f2-4855-b0e5-27563fe270d3"), Instincts.Instances.AnimalInstinct.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("27387b7e-e24d-41de-9266-7ed8405b0f43"), Traits.Instances.Barbarian.ID);
            builder.Add(Guid.Parse("90caed04-21e0-4e01-9852-4140f1687286"), Traits.Instances.Flourish.ID);
            builder.Add(Guid.Parse("ced2a839-5bcd-4ccb-9048-ad191c9446b0"), Traits.Instances.Instinct.ID);
            builder.Add(Guid.Parse("4f2e5b3f-aad4-42d7-bde1-e8f24187b814"), Traits.Instances.Open.ID);
            builder.Add(Guid.Parse("e06f7965-dcbd-48d5-9d45-75452917d036"), Traits.Instances.Rage.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f40602f9-7809-4a0c-86c9-3d2f1294d569"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
