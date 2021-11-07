using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Brightsoul : Template
    {
        public static readonly Guid ID = Guid.Parse("0d7b33f8-d73b-4398-8b40-718413334a47");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Brightsoul",
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
            yield return new TextBlock { Id = Guid.Parse("73994898-0e9d-4576-89cf-9dc87f4651ec"), Type = TextBlockType.Text, Text = "The fire inside you asserts itself as beaming, radiant light. Your body is naturally luminescent, glowing with the effects of a primal (spell: light) cantrip. A cantrip is heightened to a spell level equal to half your level rounded up. The light is involuntary and constant; if counteracted, it returns in 1d4 rounds. You suffer a -2 circumstance penalty on Stealth checks to (action: Hide) or (action: Sneak) and gain a +1 circumstance bonus on saves against (trait: light) effects and effects that inflict the blinded or dazzled conditions." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("70618831-c73f-47b0-a8aa-3faafcff09f6"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
