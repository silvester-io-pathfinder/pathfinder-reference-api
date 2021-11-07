using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnderhandedAssault : Template
    {
        public static readonly Guid ID = Guid.Parse("67d13ce9-28d7-4bd7-b894-51aa4023738b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Underhanded Assault",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("47556c66-5028-4a34-9ad1-c0b0fd2f6d86"), Type = TextBlockType.Text, Text = "You capitalize on the distraction provided by an ally. You (action: Sneak) up to a foe adjacent to one of your allies. You can roll against the foe you’re (action: Sneaking | Sneak) up on, even if it’s currently observing you, as though you were hidden. You take a –2 penalty on your Stealth check. If your Stealth check against the chosen foe succeeds, you can make a melee (action: Strike) against that foe at the end of your (action: Sneak)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("ef30e35d-aab6-4ac4-9d6f-de3d0eb43d95"), Proficiencies.Instances.Trained.ID, Skills.Instances.Stealth.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7e44f87f-7f7a-4835-abb3-c6e16dbad42e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
