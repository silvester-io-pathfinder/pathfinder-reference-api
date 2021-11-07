using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GolomaCourage : Template
    {
        public static readonly Guid ID = Guid.Parse("851f1e8f-74e6-4c67-ac40-1d4663940952");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Goloma Courage",
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
            yield return new TextBlock { Id = Guid.Parse("67613070-328f-4dad-aa73-7b387b0aae47"), Type = TextBlockType.Text, Text = "The most important thing you’ve learned living with fear is how to overcome it. When you roll a success on a saving throw against a (trait: fear) effect, you get a critical success instead. In addition, you gain a +1 circumstance bonus to Will saves against (trait: fear) effects and a +2 circumstance bonus to your Will DC against attempts to (action: Demoralize) you." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("feb80891-ce4e-49cf-a439-9493f29cf129"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
