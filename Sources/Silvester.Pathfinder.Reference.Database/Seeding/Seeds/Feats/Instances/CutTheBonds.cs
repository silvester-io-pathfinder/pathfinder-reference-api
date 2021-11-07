using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CutTheBonds : Template
    {
        public static readonly Guid ID = Guid.Parse("5ddf88e7-90cb-4cc8-9f7f-5e62b289d38e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cut the Bonds",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0e24ec57-e661-4712-b1c1-9fbc6e742a1b"), Type = TextBlockType.Text, Text = "Select a magical effect that has made an adjacent member of your crop clumsy, grabbed, paralyzed, restrained, or slowed. Attempt a counteract check using your attack modifier (including your multiple attack penalty) with a melee weapon with which you have expert proficiency. Your counteract level is half your level rounded up. On a success, you free that member from the effect; on a failure, you can’t attempt to use Cut the Bonds on that effect on that crop member until 24 hours have passed." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("19c69658-9e18-45d0-a168-4ff385b55d77"), Feats.Instances.BellflowerTillerDedication.ID);
            builder.HaveAnyMeleeWeaponSpecificProficiency(Guid.Parse("a3bc842d-d65a-4fec-aac9-542c71869e2e"), Proficiencies.Instances.Expert.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("354da8b9-7afa-45a0-81a4-ceeb3383ce92"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
