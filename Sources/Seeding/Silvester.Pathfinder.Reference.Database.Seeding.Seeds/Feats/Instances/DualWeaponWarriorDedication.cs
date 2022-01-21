using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DualWeaponWarriorDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("bb9e5549-e83a-4bd6-93f1-f189b1e8d044");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dual-Weapon Warrior Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you gain two other feats from the dual-weapon warrior archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("47442ce9-b5c1-4fc5-bd62-92e55bf6eb2d"), Type = TextBlockType.Text, Text = $"You're exceptional in your use of two weapons. You gain the {ToMarkdownLink<Models.Entities.Feat>("Double Slice", Feats.Instances.DoubleSlice.ID)} fighter feat. This serves as {ToMarkdownLink<Models.Entities.Feat>("Double Slice", Feats.Instances.DoubleSlice.ID)} for the purpose of meeting prerequisites." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1da0e77b-8ef7-4775-9ff4-6e5ba35ffa9c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
