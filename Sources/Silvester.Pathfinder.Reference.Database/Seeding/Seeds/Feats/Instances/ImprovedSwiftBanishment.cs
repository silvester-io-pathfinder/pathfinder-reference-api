using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ImprovedSwiftBanishment : Template
    {
        public static readonly Guid ID = Guid.Parse("3fc50d2b-6799-4e2a-b417-d5369978e8a5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Improved Swift Banishment",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f85740b4-d834-444b-b531-0bbe50e6e6a4"), Type = TextBlockType.Text, Text = "You easily banish creatures with your weapon. You can use (action: Swift Banishment) as long as you have a spell slot of 5th level or higher remaining, even if you don’t have (spell: banishment) prepared. You must sacrifice a prepared spell of 5th level or higher, and the banishment effect you create is heightened to the level of that spell. Your weapon serves as the special material component of banishment, causing the target to take the -2 penalty to its save against any (spell: banishment) you cast using (action: Swift Banishment)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f8e51c21-bf0a-46d2-bce6-620bee7f47fe"), Feats.Instances.SwiftBanishment.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6175cdee-5def-450e-a06c-145ae0fca805"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
