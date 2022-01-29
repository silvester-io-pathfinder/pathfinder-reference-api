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
    public class RenewedVigor : Template
    {
        public static readonly Guid ID = Guid.Parse("737d8533-d309-445d-ba93-305f0ae17313");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Renewed Vigor",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c8946932-2e42-43d1-8f72-ff3e45a0f4c8"), Type = TextBlockType.Text, Text = $"You pause to recover your raging vigor. You gain temporary Hit Points equal to half your level plus your Constitution modifier." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("7413cbc1-e5f8-4bf5-a8bf-47b3ae8fc978"), Traits.Instances.Barbarian.ID);
            builder.Add(Guid.Parse("c0f64416-35a3-45e0-acdd-959ae5d827ab"), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse("8f51ebcf-41cc-4cf7-bcb3-411fb3054a41"), Traits.Instances.Rage.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("97b66100-a1a2-4b59-b087-fb209e2c829a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
