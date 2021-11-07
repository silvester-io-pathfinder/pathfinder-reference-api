using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Earworm : Template
    {
        public static readonly Guid ID = Guid.Parse("86bc8f2f-5ea5-4f2b-8e39-6fa0bf838650");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Earworm",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b991b79a-464a-4544-b13d-4743f55d0d4f"), Type = TextBlockType.Text, Text = "By endlessly repeating a motif, you implant an earworm, a memorable song that repeats over and over again in your allies’ heads, preparing them to respond to it later. Choose a composition cantrip and spend 10 minutes repeating a melody, chant, speech, series of motions, or a similar performance that embodies that cantrip. This activity gains the traits appropriate to the type of performance. You implant the earworm within all allies who can see or hear you (as appropriate for the type of performance) for the entire activity." };
            yield return new TextBlock { Id = Guid.Parse("55dd13e0-5fe5-40a5-9903-3ba123425502"), Type = TextBlockType.Text, Text = "Once you’ve created the earworm, you can attempt a Performance check as a free action to activate it. This check uses a very hard DC of a level equal to that of the highestlevel target of the earworm present at the time of activation. On a success, you cast the cantrip on all allies who learned the earworm and can perceive your performance; on a failure, the earworm is corrupted and lost. Because it is based on the earlier repetitions, you can’t use further free actions like lingering performance or (spell: inspire heroics) to modify the activated earworm. Allies forget the earworm after it is activated, if you spend 10 minutes to implant another earworm, or during your next daily preparations, whichever comes first." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("22a70288-92b6-4bad-8f5d-9a943276c607"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
