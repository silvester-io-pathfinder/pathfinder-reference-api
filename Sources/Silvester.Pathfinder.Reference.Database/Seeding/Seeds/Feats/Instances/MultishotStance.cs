using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MultishotStance : Template
    {
        public static readonly Guid ID = Guid.Parse("e8bc8557-2069-46a8-90c5-4c701ccd4496");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Multishot Stance",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7532bc34-582d-4abd-8da7-3619042588db"), Type = TextBlockType.Text, Text = "You lock yourself in a stable position so you can fire swiftly and accurately. While you are in this stance, your penalty for (feat: Double Shot) is reduced to -1, or -2 if you add the extra action to make three (action: Strikes | Strike). If you move from your position, this stance ends." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("3928c8e2-71ff-40b0-81e5-5c66c5d0fcc7"), Feats.Instances.TripleShot.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6bd1392d-2548-44c9-b019-ed119582a30b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
