using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MultishotStance : Template
    {
        public static readonly Guid ID = Guid.Parse("8badd9ab-63a7-4101-af11-153347915215");

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
            yield return new TextBlock { Id = Guid.Parse("de4e6f18-8db4-4cee-b130-55f6387019b2"), Type = TextBlockType.Text, Text = "You lock yourself in a stable position so you can fire swiftly and accurately. While you are in this stance, your penalty for (feat: Double Shot) is reduced to -1, or -2 if you add the extra action to make three (action: Strikes | Strike). If you move from your position, this stance ends." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2c9f5538-8c5a-4f72-a6ef-4ed449cc465e"), Feats.Instances.TripleShot.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b0fbdf89-d5ba-4089-9183-695a4f032bc2"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
