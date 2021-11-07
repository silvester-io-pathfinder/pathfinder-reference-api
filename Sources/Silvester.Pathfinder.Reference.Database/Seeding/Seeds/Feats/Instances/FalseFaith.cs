using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FalseFaith : Template
    {
        public static readonly Guid ID = Guid.Parse("d568974d-d457-4260-af16-ec6e4a8621b4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "False Faith",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4cf19063-49a2-41da-ba86-3b885946392b"), Type = TextBlockType.Text, Text = "Droskar knows you may need to disguise yourself in societies that oppose your faith. After spending 1 hour in prayer to Droskar, you can cast spells using the religious symbol of a different deity as your divine focus, and you can address verbal prayers to that deity. Droskar intercepts your prayers and answers them without the named god knowing." };
            yield return new TextBlock { Id = Guid.Parse("7813fc64-b8e8-474a-a98e-3ae6993dc235"), Type = TextBlockType.Text, Text = "This ability applies to the religious symbol of only one god at a time – making a different religious symbol work in this fashion requires another hour of prayer and causes the old one to cease functioning. You can always use a religious symbol of Droskar without affecting this ability." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.WorshipSpecificDeity(Guid.Parse("11e1df09-71a1-474e-a74b-b291207c081d"), Deities.Instances.Droskar.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("14fa9168-3773-441d-a7d0-526c46389fd5"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
