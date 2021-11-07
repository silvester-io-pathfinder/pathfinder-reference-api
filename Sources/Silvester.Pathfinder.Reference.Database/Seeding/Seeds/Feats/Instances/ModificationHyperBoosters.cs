using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationHyperBoosters : Template
    {
        public static readonly Guid ID = Guid.Parse("f0b26f1d-c95d-4c3d-91b3-490156d3b7d4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Hyper Boosters",
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
            yield return new TextBlock { Id = Guid.Parse("6f205157-d7fb-4c34-a22b-02dda3ea0a9e"), Type = TextBlockType.Text, Text = "You’ve improved your speed boosters’ power through a breakthrough that significantly increases the energy flow without risking exploding. You gain a +10-foot status bonus to your Speed, which increases to a +20-foot status bonus when you’re in (feat: Overdrive). If you’re legendary in Crafting, it instead increases to a +30-foot status bonus when you’re in (feat: Overdrive). You must have the (feat: speed boosters | Modification - Speed Boosters) modification to select this modification." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9a706743-ecc1-4ffc-8d21-99dfabfb1a52"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
