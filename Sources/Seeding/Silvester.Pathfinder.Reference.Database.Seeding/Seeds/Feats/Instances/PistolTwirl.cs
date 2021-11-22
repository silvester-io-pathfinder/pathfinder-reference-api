using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PistolTwirl : Template
    {
        public static readonly Guid ID = Guid.Parse("7f9282f0-a488-4f19-a2c9-c55fd83f3563");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Pistol Twirl",
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
            yield return new TextBlock { Id = Guid.Parse("a677961e-605d-4b9a-89e7-0a02b9e9e6b0"), Type = TextBlockType.Text, Text = "Your quick gestures and flair for performance distract your opponent, leaving it vulnerable to your follow-up attacks. You (action: Feint) against an opponent within the required weapon's first range increment, rather than an opponent within melee reach. If you succeed, the foe is flat-footed against your melee and ranged attacks, rather than only your melee attacks. On a critical failure, you're flat-footed against the target's melee and ranged attacks, rather than only its melee attacks." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("de5b3979-56c5-4fc1-9bef-c2ba17441093"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fcc8b182-a527-476f-b169-d8e7ed24e5c4"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
