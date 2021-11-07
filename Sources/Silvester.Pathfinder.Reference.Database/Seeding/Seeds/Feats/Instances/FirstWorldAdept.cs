using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FirstWorldAdept : Template
    {
        public static readonly Guid ID = Guid.Parse("fd5e536a-8c01-4260-bfa3-2ed8551ae67b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "First World Adept",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8e06b044-7750-4adb-8214-c44ffff55138"), Type = TextBlockType.Text, Text = "Over time your fey magic has grown stronger. You gain (spell: faerie fire) and (spell: invisibility) as 2nd-level primal innate spells. You can cast each of these primal innate spells once per day." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            //TODO: Add prerequisites.
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bd4cace2-c1f9-4802-8ec8-cb8d36065264"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
