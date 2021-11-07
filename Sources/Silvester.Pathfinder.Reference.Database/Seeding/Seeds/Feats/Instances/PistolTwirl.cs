using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PistolTwirl : Template
    {
        public static readonly Guid ID = Guid.Parse("512db585-9e03-4479-b2c9-f652b81effb9");

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
            yield return new TextBlock { Id = Guid.Parse("f89aa7e5-5667-45b6-9020-ab5d2a1336a9"), Type = TextBlockType.Text, Text = "Your quick gestures and flair for performance distract your opponent, leaving it vulnerable to your follow-up attacks. You (action: Feint) against an opponent within the required weapon’s first range increment, rather than an opponent within melee reach. If you succeed, the foe is flat-footed against your melee and ranged attacks, rather than only your melee attacks. On a critical failure, you’re flat-footed against the target’s melee and ranged attacks, rather than only its melee attacks." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("6965ee4a-b315-4bcd-8120-12cc018998b8"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f434c30b-3985-4895-a028-0588e453828f"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
