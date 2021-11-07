using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SwordAndPistol : Template
    {
        public static readonly Guid ID = Guid.Parse("de8319e3-ae31-438b-b3ea-d00be4216430");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sword and Pistol",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e9770133-f9e1-4dd1-a68d-bfcddebd47cf"), Type = TextBlockType.Text, Text = "You’re comfortable wielding a firearm or crossbow in one hand and a melee weapon in the other, combining melee attacks with shots from the firearm. When you make a successful ranged (action: Strike) against an enemy within your reach with your one-handed firearm or one-handed crossbow, that enemy is flat-footed against your next melee attack with a one-handed melee weapon." };
            yield return new TextBlock { Id = Guid.Parse("9afc5714-d2a8-4dec-90e0-5399547b6634"), Type = TextBlockType.Text, Text = "When you make a successful melee (action: Strike) against an enemy with your one-handed melee weapon, the next ranged (action: Strike) you make against that enemy with a one-handed firearm or one-handed crossbow doesn’t trigger reactions that would trigger on a ranged attack but not a melee attack, such as (feat: Attack of Opportunity). Either of these benefits is lost if not used by the end of your next turn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fcc28ee7-865b-4ef2-9ca0-c97d8b30002d"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
