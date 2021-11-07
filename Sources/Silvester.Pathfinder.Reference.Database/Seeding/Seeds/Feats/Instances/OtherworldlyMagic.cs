using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OtherworldlyMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("9c3cf35d-c8af-4d5f-b56f-8158f4237ce6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Otherworldly Magic",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("edb3f2db-c8ac-4cd3-a9ed-bf7c42c703e2"), Type = TextBlockType.Text, Text = "Your elven magic manifests as a simple arcane spell, even if you aren’t formally trained in magic. Choose one cantrip from the arcane spell list. You can cast this cantrip as an arcane innate spell at will. A cantrip is heightened to a spell level equal to half your level rounded up." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("314ff78c-86c2-45a2-8c7a-8319fb5b7f89"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
