using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AccursedClaws : Template
    {
        public static readonly Guid ID = Guid.Parse("de945a56-d84c-4b21-ae99-85925ef0ba82");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Accursed Claws",
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
            yield return new TextBlock { Id = Guid.Parse("45bb743c-a28b-494f-b33e-f0463e647d1e"), Type = TextBlockType.Text, Text = "Your claws carry your mother&#39;s hag magic. When you critically hit with a claw (action: Strike), the target takes an additional 1d4 persistent mental damage." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificUnarmedAttack(Guid.Parse("a4a680e0-6019-4934-a8a5-fe0da34cf9b6"), UnarmedAttack.Claws);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("71f6180d-6409-4f7c-b443-4fe3950acf45"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
