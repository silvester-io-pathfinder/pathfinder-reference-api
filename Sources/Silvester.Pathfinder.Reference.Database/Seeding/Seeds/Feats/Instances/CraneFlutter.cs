using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CraneFlutter : Template
    {
        public static readonly Guid ID = Guid.Parse("ba3bf5eb-8bf9-4c90-ba5b-077259e13967");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Crane Flutter",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You are targeted with a melee attack by an attacker you can see.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f374519e-eb82-4d22-a148-87edd629b503"), Type = TextBlockType.Text, Text = "You interpose your arm between yourself and your opponent. Your circumstance bonus to AC from (feat: Crane Stance) increases to +3 against the triggering attack. If the attack misses you, you can immediately make a crane wing (action: Strike) against the attacker at a -2 penalty, even if the attacker isn’t within your reach." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("41583fd5-ae63-4787-b671-273ac5fdd97b"), Feats.Instances.CraneStance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("069da800-7124-448f-850a-0e5997c853d0"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
