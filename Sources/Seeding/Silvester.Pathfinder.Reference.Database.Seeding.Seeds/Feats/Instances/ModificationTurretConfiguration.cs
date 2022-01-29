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
    public class ModificationTurretConfiguration : Template
    {
        public static readonly Guid ID = Guid.Parse("966a0f78-6862-4f62-9bd3-2d1fe0f7e666");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Turret Configuration",
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
            yield return new TextBlock { Id = Guid.Parse("fc1fa7d5-c076-4d5f-9a68-f5ab08c139c8"), Type = TextBlockType.Text, Text = $"Your innovation can transform from a mobile construct to a stationary turret. Your construct companion can transform as a single action, which has the {ToMarkdownLink<Models.Entities.Trait>("manipulate", Traits.Instances.Manipulate.ID)} trait, turning into a turret in its space (or transforming back from a turret into its normal configuration). While it's a turret, your innovation is immobilized, but the damage die from its projectile launcher increases to 1d6 and the range increment increases to 60 feet. You must have the {ToMarkdownLink<Models.Entities.Feat>("projectile launcher", Feats.Instances.ModificationProjectileLauncher.ID)} modification to select this modification." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e3725f0a-6b58-4ab8-b93d-d91b3969428c"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
