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
    public class PlumDeluge : Template
    {
        public static readonly Guid ID = Guid.Parse("d8e867b5-22bc-4341-9221-731f9e85fd06");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Plum Deluge",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6e11966e-3610-4bd4-ba51-a51b862dfef7"), Type = TextBlockType.Text, Text = $"You have learned to saturate an area with poison in imitation of the techniques of your rival, Blue Viper. As part of this ability, you {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)} to draw three vials of the same contact poison and throw them in the air, where they shatter and spread a poisonous deluge affecting a 20-foot burst within 60 feet. All creatures in the burst are automatically exposed to the poison, immediately bypassing any onset time, and must attempt a saving throw against that poison. The three vials must be identical, even if the poison can come in multiple types or different levels." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("eb9ab2de-3783-4dfd-90c3-39243d28047a"), Traits.Instances.Alchemist.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c752bc33-65bf-4bd3-b079-c8d60e568bb3"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
