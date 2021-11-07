using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GreaterDistractingShot : Template
    {
        public static readonly Guid ID = Guid.Parse("af519301-1bfd-4cc9-9f62-d1f6e8c77a30");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Greater Distracting Shot",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a98cf33c-89ac-4eb5-b5d0-94530304909a"), Type = TextBlockType.Text, Text = "Even a single missile can throw off your enemy’s balance, and more powerful attacks leave it flustered for longer. If you hit your hunted prey with a ranged weapon, it’s flat-footed until the start of your next turn. If you critically hit your prey or hit it twice on the same turn with a ranged weapon, it’s flat-footed until the end of your next turn instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("ba536d72-ded8-4fc2-a424-e60549ddca32"), Feats.Instances.DistractingShot.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("794c1aa8-7dc9-4b61-b5ec-6bc1ebbaa0d6"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
