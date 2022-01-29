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
    public class ModificationImpossibleAlloy : Template
    {
        public static readonly Guid ID = Guid.Parse("d6999e4e-f073-4886-aecc-b2590ad478e2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Impossible Alloy",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ba9c8849-e665-4be9-9ee6-2a9175036304"), Type = TextBlockType.Text, Text = $"Other inventors claim it's not even technically possible, but you've managed to create several metal alloys that seem to work for only you. These alloys can damage opponents vulnerable to any one of the seven skymetals. Your innovation is treated as all seven skymetals (abysium, adamantine, djezet, inubrix, noqual, orichalcum, and siccatite). This means you deal more damage to a variety of creatures, though you don't apply any of the other special effects for weapons made of those skymetals." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b2fb1a18-bda8-44b6-9bf9-40c47014f8e2"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
