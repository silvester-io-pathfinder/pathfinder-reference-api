using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ArmorProficiency : Template
    {
        public static readonly Guid ID = Guid.Parse("0d21f99b-6cbe-493b-9658-6b8b113d2a06");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Armor Proficiency",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = true,
                Special = "You can select this feat more than once. Each time, you become trained in the next type of armor above.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("81a767f2-18b9-4566-b875-51829a4622aa"), Type = TextBlockType.Text, Text = "You become trained in light armor. If you already were trained in light armor, you gain training in medium armor. If you were trained in both, you become trained in heavy armor." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a6dd9c7c-a084-47c3-850b-1fe5653d74cc"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
