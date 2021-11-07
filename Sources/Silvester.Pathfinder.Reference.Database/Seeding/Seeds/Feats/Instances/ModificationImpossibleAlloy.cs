using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationImpossibleAlloy : Template
    {
        public static readonly Guid ID = Guid.Parse("8bf316b4-71a1-4498-94f0-6481cff62036");

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
            yield return new TextBlock { Id = Guid.Parse("26e0d96e-6194-4d43-8316-e9fd24c04de9"), Type = TextBlockType.Text, Text = "Other inventors claim it’s not even technically possible, but you’ve managed to create several metal alloys that seem to work for only you. These alloys can damage opponents vulnerable to any one of the seven skymetals. Your innovation is treated as all seven skymetals (abysium, adamantine, djezet, inubrix, noqual, orichalcum, and siccatite). This means you deal more damage to a variety of creatures, though you don’t apply any of the other special effects for weapons made of those skymetals." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("93b2c8bd-bbae-496c-bd93-e8c3a53f2435"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
