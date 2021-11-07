using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationDeadlyStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("13e50c6d-d250-4b49-a9b4-c75e0bb3c2cc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Deadly Strike",
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
            yield return new TextBlock { Id = Guid.Parse("43e3bdca-c640-4d0a-91f7-70d8586c19ce"), Type = TextBlockType.Text, Text = "Through precise calculation, you’ve found the perfect shape for your weapon to deal extreme damage on a well-placed strike. Your innovation gains the (trait: deadly d8) trait. If your innovation was already deadly, it increases its (trait: deadly die to d12 | deadly d12) instead of gaining (trait: deadly d8)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("13cf424a-2847-488c-a0dc-c8aa00cda096"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
