using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ImprovedKnockdown : Template
    {
        public static readonly Guid ID = Guid.Parse("94e68239-ed2f-440c-9014-a4825c3719fe");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Improved Knockdown",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("71302f27-0a7b-4f47-b26c-1b284ec987ed"), Type = TextBlockType.Text, Text = "You can dash your foe to the ground with a single blow. When you use (feat: Knockdown), instead of making a (action: Strike) followed by a (action: Trip), you can attempt a single (action: Strike). If you do and your (action: Strike) hits, you also apply the critical success effect of a (action: Trip). If you used a two-handed melee weapon for the (action: Strike), you can use the weapon's damage die size instead of the regular die size for the damage from a critical (action: Trip)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2314eb89-1928-42dd-ae99-cd354c82973f"), Feats.Instances.Knockdown.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9e9f93bd-e744-4aa6-94c0-9f66860496ca"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
