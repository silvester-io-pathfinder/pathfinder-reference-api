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
    public class TurnUndead : Template
    {
        public static readonly Guid ID = Guid.Parse("66d637c7-58a0-4581-9369-a41d42c30ada");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Turn Undead",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("15038f82-3a47-421a-aab5-57d2a7415782"), Type = TextBlockType.Text, Text = $"Undead harmed by your positive energy might flee, compelled by an innate aversion to the force opposite undeath. When you use a {ToMarkdownLink<Models.Entities.Spell>("heal", Spells.Instances.Heal.ID)} spell to damage undead, each undead of your level or lower that critically fails its save gains the fleeing condition for 1 round." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("05fcd59e-f23d-4e81-ae22-ccdd21735b18"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
