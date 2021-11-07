using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AgonizingRebuke : Template
    {
        public static readonly Guid ID = Guid.Parse("d3b6d057-c310-4c83-800c-11af7f857def");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Agonizing Rebuke",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c2b20455-9e83-4b79-a3d0-da447924d8f7"), Type = TextBlockType.Text, Text = "When you terrorize your enemies, you also cause them painful mental distress. When you successfully (Action: Demoralize) a foe, that foe takes 1d4 mental damage at the start of each of its turns as long as it remains frightened and continues to engage in combat with you. If you have master proficiency in Intimidation, the damage increases to 2d4, and if you have legendary proficiency, the damage increases to 3d4." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("612990c4-04d1-4b6f-97af-1dd2a5dedb8f"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
