using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HarryingStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("8c28f053-e966-42a5-92e8-cc9697fc6e3b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Harrying Strike",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e6f5cb7b-7dff-4b73-97c5-cc5024babd8b"), Type = TextBlockType.Text, Text = "Your attack prevents a foe from pursuing your allies. Make a melee (action: Strike), adding the following effects in addition to the normal effects of the (action: Strike)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("9cc95bbb-2dbc-4793-9aca-928faa5d7185"), Feats.Instances.SwordmasterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("eaf6bb42-5dba-46c1-8baa-7e23eb7dcf49"),
                CriticalSuccess = "The target takes a -15-foot status penalty to its Speeds until the start of your next turn.",
                Success = "The target takes a -10-foot status penalty to its Speeds until the start of your next turn.",
                Failure = "The target takes a -5-foot status penalty to its Speeds until the start of your next turn.",
                 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("63fc302f-3199-4833-a6df-6a3508e81b04"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
