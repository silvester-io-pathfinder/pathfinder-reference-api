using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationDeadlyStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("8ab86b34-b4e1-4df3-9f40-744a1b8fbb02");

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
            yield return new TextBlock { Id = Guid.Parse("bd863ebe-72d7-4b4a-a860-335998a9f472"), Type = TextBlockType.Text, Text = "Through precise calculation, you’ve found the perfect shape for your weapon to deal extreme damage on a well-placed strike. Your innovation gains the (trait: deadly d8) trait. If your innovation was already deadly, it increases its (trait: deadly die to d12 | deadly d12) instead of gaining (trait: deadly d8)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("929a5c02-c298-427c-9a4c-ab3396cf6cd0"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
