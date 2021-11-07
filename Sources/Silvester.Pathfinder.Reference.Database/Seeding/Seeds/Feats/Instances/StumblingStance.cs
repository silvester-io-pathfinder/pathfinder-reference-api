using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StumblingStance : Template
    {
        public static readonly Guid ID = Guid.Parse("c15f9ff1-7cf0-4f0e-a063-9299d9d78c8d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Stumbling Stance",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8266674e-4d86-4016-a1d4-638a1c72a102"), Type = TextBlockType.Text, Text = "You enter a seemingly unfocused stance that mimics the movements of the inebriated – bobbing, weaving, leaving false openings, and distracting your enemies from your true movements. While in this stance, you gain a +1 circumstance bonus to Deception checks to (action: Feint). The only (action: Strikes | Strike) you can make are stumbling swing unarmed attacks. These deal 1d8 bludgeoning damage; are in the brawling group; and have the (trait: agile), (trait: backstabber), (trait: finesse), (trait: nonlethal), and (trait: unarmed) traits. If an enemy hits you with a melee (action: Strike) while in this stance, it becomes flat-footed against the next stumbling swing (action: Strike) you make against it before the end of your next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("ec94e4bc-0002-4f44-954e-3c6fc49ffe33"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("84324f72-9672-4a58-b407-585c5d504503"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
