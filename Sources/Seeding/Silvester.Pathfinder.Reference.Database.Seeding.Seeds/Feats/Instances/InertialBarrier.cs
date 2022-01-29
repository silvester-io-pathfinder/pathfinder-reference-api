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
    public class InertialBarrier : Template
    {
        public static readonly Guid ID = Guid.Parse("9459e9e6-d220-42ee-b022-307c63adb574");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Inertial Barrier",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8e0622d5-d1c6-44a6-8322-b90c1d255d3c"), Type = TextBlockType.Text, Text = $"Your spell leaves behind barriers that reduce shock and motion. Use this amp in place of the psi cantrip's normal amp entry." };
            yield return new TextBlock { Id = Guid.Parse("5e967067-08d6-4a78-8a97-2593dbdc736c"), Type = TextBlockType.Text, Text = $"----" };
            yield return new TextBlock { Id = Guid.Parse("85a3b005-8358-47c0-8b70-91b3b890442e"), Type = TextBlockType.Text, Text = $"~ Amp: You or one target of the spell gain resistance to physical damage equal to 2 + the spell's level until the start of your next turn." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5b3b7cc7-05f5-48f1-b733-e355561f03e4"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
