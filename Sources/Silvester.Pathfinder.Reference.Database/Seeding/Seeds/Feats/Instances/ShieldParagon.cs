using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShieldParagon : Template
    {
        public static readonly Guid ID = Guid.Parse("5fa15f90-08f3-4213-8193-abf259e111a7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shield Paragon",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e0044b2d-3a61-462d-9be8-ccd30827a685"), Type = TextBlockType.Text, Text = "Your shield is a vessel of divine protection. When you’re wielding your chosen shield, it is always raised, even without you using the (action: Raise a Shield) action. Your chosen shield doubles its HP and BT, rather than increasing them by half. If it would be destroyed, it vanishes to your deity’s realm instead, where your divine ally repairs it. During your next daily preparations, the shield returns to you fully repaired." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDivineAlly(Guid.Parse("95ecdb96-04e2-4a3a-a4f5-d35fe7b9beab"), DivineAllies.Instances.Shield.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1e7a9330-0490-4ed6-94ab-556d8000d97a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
