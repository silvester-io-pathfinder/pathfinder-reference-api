using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AggravatingScratch : Template
    {
        public static readonly Guid ID = Guid.Parse("b5787c13-84d6-4828-8493-1bc3a34a3956");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Aggravating Scratch",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("280d1772-cd74-4e2f-8991-a9053978ec47"), Type = TextBlockType.Text, Text = "Your claws carry an irritant that is harmless to you but can be damaging to others. Your claw (action: Strikes | Strike) deal an additional 1d4 persistent poison damage on a critical hit." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificUnarmedAttack(Guid.Parse("87c42875-8e78-4dfc-bf79-c6eb7fb62feb"), UnarmedAttack.Claws);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cc68e6bc-688f-4074-b868-5134c31170ee"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
