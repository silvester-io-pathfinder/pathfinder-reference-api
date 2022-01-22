using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HulkingSize : Template
    {
        public static readonly Guid ID = Guid.Parse("c6a4bdbb-cf3a-4a8d-a1f1-e600323c5ada");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hulking Size",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5d4ac491-9c7b-410c-ae27-588df0637d29"), Type = TextBlockType.Text, Text = $"Your eidolon grows substantially. Your eidolon becomes Large, instead of its previous size, and its reach increases to 10 feet. This doesn't change any of its other statistics." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("30fefc9e-f3e0-4236-9c43-0536c73e7461"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
