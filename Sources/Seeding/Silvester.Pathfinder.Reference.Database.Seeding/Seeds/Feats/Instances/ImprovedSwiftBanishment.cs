using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ImprovedSwiftBanishment : Template
    {
        public static readonly Guid ID = Guid.Parse("8bc012fa-b513-4969-9f13-d35448883feb");

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
            yield return new TextBlock { Id = Guid.Parse("c58a9617-0b43-44a3-9c1b-66ab2756768d"), Type = TextBlockType.Text, Text = "You easily banish creatures with your weapon. You can use (action: Swift Banishment) as long as you have a spell slot of 5th level or higher remaining, even if you don't have (spell: banishment) prepared. You must sacrifice a prepared spell of 5th level or higher, and the banishment effect you create is heightened to the level of that spell. Your weapon serves as the special material component of banishment, causing the target to take the -2 penalty to its save against any (spell: banishment) you cast using (action: Swift Banishment)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("11033733-5de8-41cd-a668-e32e48e3866e"), Feats.Instances.SwiftBanishment.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("37a411fa-ffaa-44ee-a058-fd941fdc94ac"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
