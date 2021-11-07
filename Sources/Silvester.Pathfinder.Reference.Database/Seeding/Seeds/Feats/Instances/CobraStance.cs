using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CobraStance : Template
    {
        public static readonly Guid ID = Guid.Parse("30a89f2c-7d69-494c-b4c0-e4b0c696d8ec");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cobra Stance",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e15c48c2-f68f-401f-a5b0-9e508d4296c3"), Type = TextBlockType.Text, Text = "You enter a tight stance, coiled up like a lashing cobra with your hands poised as venomous fangs. While in this stance, the only (action: Strikes | Strike) you can make are cobra fang unarmed attacks. These deal 1d4 poison damage; are in the brawling group; and have the (trait: agile), (trait: deadly d10), (trait: finesse), (trait: nonlethal), (trait: poison), and (trait: unarmed) traits." };
            yield return new TextBlock { Id = Guid.Parse("10205bcc-a8a5-4882-9ae2-81c78748c600"), Type = TextBlockType.Text, Text = "While in Cobra Stance, you gain a +1 circumstance bonus to Fortitude saves and your Fortitude DC, and you gain poison resistance equal to half your level." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c5fe5551-bc57-4d0b-8c43-2190f48fa413"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
